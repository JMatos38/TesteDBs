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
        
        [ForeignKey(nameof(Servicos))] 
        public int servicoFK { get; set; }   
        public Servicos IdServico { get; set; }   

        [ForeignKey(nameof(Funcionarios))]  
        public int FuncionarioFK { get; set; }   
        public Funcionarios IdFuncionario { get; set; }   
        
    }
}
