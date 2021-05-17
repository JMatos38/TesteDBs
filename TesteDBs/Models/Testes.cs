using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteDBs.Models
{
    public class Testes : Servicos
    {
        public string Tipo_Testagem { get; set; }
        /// <summary>
        /// Quantidades de testes encomendados caso seja um serviço de testes de rastreio
        /// </summary>
        public int Quantidade_testes { get; set; }
        /// <summary>
        /// Preçario para o serviço selecionado
        /// </summary>
        
    }
}
