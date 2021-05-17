using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TesteDBs.Models
{
    public class Funcionarios
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
        /// Código postal da morada do funcionario
        /// </summary>

        public string CodigoPostal { get; set; }

        /// <summary>
        /// Numero de telemovel do Funcionario
        /// </summary>
        public int Telemovel { get; set; }


        /// <summary>
        /// email do funcionario 
        /// </summary>

        public string email { get; set; }

        
    }
}
