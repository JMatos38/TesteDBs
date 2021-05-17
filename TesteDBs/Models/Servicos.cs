using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
// esta tabela ainda nao esta completa
namespace TesteDBs.Models
{
    public class Servicos
    {
        /// <summary>
        /// Identificador de cada Serviço
        /// </summary>
        [Key]
        public int IdServico { get; set; }  

        /// <summary>
        /// Nome do Serviço
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Atributo boolean para verificar se se trata de uma testagem
        /// </summary>
       // public Boolean Testagem { get; set; }

        /// <summary>
        /// Atributo boolean para verificar se se trata de uma Desinfetação
        /// </summary>
        //public Boolean Desinfestacao { get; set; }

        /// <summary>
        /// Tipos de testes caso seja um serviço de testes de rastreio
        /// </summary>
       // public string Tipo_Testagem { get; set; }
        /// <summary>
        /// Quantidades de testes encomendados caso seja um serviço de testes de rastreio
        /// </summary>
        //public int Quantidade_testes { get; set; }
        /// <summary>
        /// Preçario para o serviço selecionado
        /// </summary>
        public decimal Preco { get; set; }
        /// <summary>
        /// Descrição informativa sobre o serviço
        /// </summary>
        public string Descricao { get; set; }
        /// <summary>
        /// Em caso de ser uma desinfestação escolha da area de Desinfestaçao
        /// </summary>
        ///public string Area_Desinfest { get; set; }

        [ForeignKey(nameof(Marcacao))]  
        public int MarcacaoFK { get; set; }  
        public Marcacoes Marcacao { get; set; }  
    }
}
