using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TesteDBs.Models
{
    public class Funcionario
    {
        /// <summary>
        /// Identificador de cada Funcionario
        /// </summary>
        [Key]
        public int IdFuncionario { get; set; }

        /// <summary>
        /// Nome do Funcionario
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Morada do Funcionario
        /// </summary>
        public string Morada { get; set; }

        /// <summary>
        /// Numero de telefone do Funcionario
        /// </summary>
        public int Telefone { get; set; }

        
        /// <summary>
        /// email do funcionario 
        /// </summary>
        public string email { get; set; }

        
    }
}
