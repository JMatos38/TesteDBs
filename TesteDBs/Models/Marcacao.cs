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
        /// Local da marcação
        /// </summary>
        public string Local { get; set; }

        /// <summary>
        /// Data e Hora da marcacao
        /// Muchaxo esse Datetime consegue registar tanto a hora como a data ou seja torna futil a gente ter 2 atributos
        /// </summary>
        public DateTime Data { get; set; }

        [ForeignKey(nameof(Clientes))]  // esta 'anotação' indica que o atributo 'RacaFK' está a executar o mesmo que o atributo 'Raca',
                                        // e que representa uma FK para a classe Raca
        public int clientesFK { get; set; }   // atributo para ser usado no SGBD e no C#. Representa a FK para a Raça do cão
        public Clientes IdCliente { get; set; }   // atributo para ser usado no C#. Representa a FK para a Raça do cão

        [ForeignKey(nameof(Servico))]  // esta 'anotação' indica que o atributo 'RacaFK' está a executar o mesmo que o atributo 'Raca',
                                        // e que representa uma FK para a classe Raca
        public int servicoFK { get; set; }   // atributo para ser usado no SGBD e no C#. Representa a FK para a Raça do cão
        public Marcacao IdServico { get; set; }   // atributo para ser usado no C#. Representa a FK para a Raça do cão


    }
}
