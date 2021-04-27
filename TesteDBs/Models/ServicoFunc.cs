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
        
        [ForeignKey(nameof(Servico))] 
        public int servicoFK { get; set; }   
        public Servico IdServico { get; set; }   

        [ForeignKey(nameof(Funcionario))]  
        public int FuncionarioFK { get; set; }   
        public Funcionario IdFuncionario { get; set; }   
        
    }
}
