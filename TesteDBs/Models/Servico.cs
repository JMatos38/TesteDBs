using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
// esta tabela ainda nao esta completa
namespace TesteDBs.Models
{
    public class Servico
    {
        /// <summary>
        /// Identificador de cada Serviço
        /// </summary>
        [Key]
        public int IdServiço { get; set; }  

        /// <summary>
        /// Nome do cliente
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Morada do Cliente
        /// </summary>
        public string Morada { get; set; }

        /// <summary>
        /// Numero de telefone do Cliente
        /// </summary>
        public int Telefone { get; set; }

        /// <summary>
        /// NIF
        /// </summary>
        public int NIF { get; set; }

        /// <summary>
        /// email do cliente 
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// Nome da empresa 
        /// </summary>
        public string Empresa { get; set; }

        [ForeignKey(nameof(Marcacao))]  // esta 'anotação' indica que o atributo 'RacaFK' está a executar o mesmo que o atributo 'Raca',
                                        // e que representa uma FK para a classe Raca
        public int marcacaoFK { get; set; }   // atributo para ser usado no SGBD e no C#. Representa a FK para a Raça do cão
        public Marcacao IdMarcacao { get; set; }   // atributo para ser usado no C#. Representa a FK para a Raça do cão

    }
}
