using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TesteDBs.Models
{
    public class Clientes
    {

        /// <summary>
        /// Identificador de cada Cliente
        /// </summary>
        [Key]
        public int IdCliente { get; set; }

        /// <summary>
        /// Nome do cliente
        /// </summary>
        [Required(ErrorMessage = "O Nome é de preenchimento obrigatório")]
        [StringLength(60, ErrorMessage = "O {0} não pode ter mais de {1} caracteres.")]
        public string Nome { get; set; }

        /// <summary>
        /// Numero de telemovel do Cliente
        /// </summary>
        [StringLength(14, MinimumLength = 9, ErrorMessage = "O {0} deve ter entre {2} e {1} caracteres.")]
        [RegularExpression("(00)?([0-9]{2,3})?[1-9][0-9]{8}", ErrorMessage = "Escreva, pf, um nº Telemóvel com 9 algarismos. Se quiser, pode acrescentar o indicativo nacional e o internacional. ")]
        [Display(Name = "Telemóvel")]
        public int Telemovel { get; set; }

        /// <summary>
        /// email do cliente 
        /// </summary>
        [StringLength(50, ErrorMessage = "O {0} não pode ter mais de {1} caracteres.")]
        [EmailAddress(ErrorMessage = "o {0} introduzido não é válido")]
        [RegularExpression("([a-z]+(.[a-z]+[0-9]+)*))@[a-z].[a-z]")]


        public string email { get; set; }

        // ********************************************************

        /// <summary>
        /// FK para a Marcação do Cliente
        /// </summary>
        [ForeignKey(nameof(Marcacao))]  // esta 'anotação' indica que o atributo 'marcacaoFK' está a executar o mesmo que o atributo 'IdMarcacao',
                                    // e que representa uma FK para a classe Marcacao
        public int marcacaoFK { get; set; }   // atributo para ser usado no SGBD e no C#. Representa a FK para a Marcacao do Cliente
        public Marcacao IdMarcacao { get; set; }   // atributo para ser usado no C#. Representa a FK para a Marcacao do Cliente

    }
