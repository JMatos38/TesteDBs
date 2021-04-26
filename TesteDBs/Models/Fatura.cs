using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TesteDBs.Models
{
    public class Fatura
    {
        /// <summary>
        /// Atributo unico identificador de cada fatura
        /// </summary>
        [Key]
        public int IdFatura { get; set; }

        /// <summary>
        /// Nome referente à fatura
        /// </summary>
        [Required(ErrorMessage = "O Nome é de preenchimento obrigatório")]
        public string Nome { get; set; }

        /// <summary>
        /// Numero de contribuinte(opcional)
        /// </summary>
        [Display(Name ="Número de Contribuinte")]
        public int Numero_de_contribuinte { get; set; }

        /// <summary>
        /// Nome da empresa (opcional)
        /// </summary>
        public string Empresa { get; set; }

        // ********************************************************

        /// <summary>
        /// FK para a Marcacao
        /// </summary>
        [ForeignKey(nameof(Marcacao))]  // esta 'anotação' indica que o atributo 'RacaFK' está a executar o mesmo que o atributo 'Raca',
                                        // e que representa uma FK para a classe Raca
        public int marcacaoFK { get; set; }   // atributo para ser usado no SGBD e no C#. Representa a FK para a Raça do cão
        public Marcacao IdMarcacao { get; set; }   // atributo para ser usado no C#. Representa a FK para a Raça do cão


    }
}
