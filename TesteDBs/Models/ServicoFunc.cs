using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TesteDBs.Models
{
    public class ServicoFunc
    {
        [Key]
        public int ID { get; set; }
        
        [ForeignKey(nameof(Servico))]  // esta 'anotação' indica que o atributo 'RacaFK' está a executar o mesmo que o atributo 'Raca',
                                       // e que representa uma FK para a classe Raca
        public int servicoFK { get; set; }   // atributo para ser usado no SGBD e no C#. Representa a FK para a Raça do cão
        public Servico IdServico { get; set; }   // atributo para ser usado no C#. Representa a FK para a Raça do cão

        [ForeignKey(nameof(Funcionario))]  // esta 'anotação' indica que o atributo 'RacaFK' está a executar o mesmo que o atributo 'Raca',
                                       // e que representa uma FK para a classe Raca
        public int FuncionarioFK { get; set; }   // atributo para ser usado no SGBD e no C#. Representa a FK para a Raça do cão
        public Funcionario IdFuncionario { get; set; }   // atributo para ser usado no C#. Representa a FK para a Raça do cão

        
    }
}
