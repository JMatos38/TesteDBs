using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TesteDBs.Models
{
    public class Marcacao
    {
        /// <summary>
        /// Identificador de cada Marcação
        /// </summary>
        [Key]
        public int IdMarcacao { get; set; }

        /// <summary>
        /// Morada da marcação
        /// </summary>
        [Required(ErrorMessage = "A Morada é de preenchimento obrigatório!")]
        [StringLength(60, ErrorMessage = "A {0} não pode ter mais de {1} caracteres.")]

        public string Morada { get; set; }

        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório!")]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "O {0} deve ter entre {2} e {1} caracteres.")]
        [Display(Name = "Código Postal")]
        [RegularExpression("[1-9][0-9]{3}-[0-9]{3} [A-Z]+( [a-zA-Z-áÁéÉçÇãõ]+)+",ErrorMessage = "Código Postal inválido.")]
        public string CodigoPostal { get; set; }

        /// <summary>
        /// Data e Hora da marcacao
        /// </summary>
        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório!")]

        public DateTime Data { get; set; }

       // public string Nome { get; set; }

        //public string Empresa { get; set; }


        //[Display(Name = "Número de Contribuinte")]
        //public int NIF { get; set; }


        //-------------------------------------------------------------------------------------

        [ForeignKey(nameof(Clientes))]  
        public int clientesFK { get; set; }   
        public Clientes IdCliente { get; set; }  
       
        [ForeignKey(nameof(Servico))]  
        public int servicoFK { get; set; }   
        public Servico IdServico { get; set; }  

    }
}
