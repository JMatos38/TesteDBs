using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TesteDBs.Models;

namespace TesteDBs.Data
{
    public class DesintestLabsDB : IdentityDbContext
    {
        public DesintestLabsDB(DbContextOptions<DesintestLabsDB> options)
            : base(options)
        {
        }
        //Representar as Tabelas da BD
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Marcacao> Marcacao { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Servico> Servico { get; set; }
        public DbSet<Servico> ServicoFunc { get; set; }
        // public DbSet<CriadoresCaes> CriadoresCaes { get; set; }


    }
}
