using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
//iincompleto
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
        [RegularExpression("([A-ZÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑa-záàâãéèêíïóôõöúçñ '-]+)+", ErrorMessage = "O nome está incorreto.")]
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

        /// <summary>
        /// FK para a Marcacao
        /// </summary>
        [ForeignKey(nameof(Marcacoes))]  
        public int marcacaoFK { get; set; }   
        public Marcacoes IdMarcacao { get; set; }  


    }
}
