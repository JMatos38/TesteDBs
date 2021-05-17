using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteDBs.Models
{
    public class Desinfecao : Servicos
    {
        /// <summary>
        /// Em caso de ser uma desinfestação escolha da area de Desinfestaçao
        /// </summary>
        public string Area_Desinfest { get; set; }

    }
}
