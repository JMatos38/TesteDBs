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
        public DbSet<Marcacoes> Marcacao { get; set; }
        public DbSet<Funcionarios> Funcionario { get; set; }
        public DbSet<Servicos> Servico { get; set; }
        public DbSet<Servicos> ServicoFunc { get; set; }
        public DbSet<Fatura> Fatura { get; set; }
        public DbSet<Testes> Testes { get; set; }
        public DbSet<Desinfecao> Desinfecao { get; set; }

    }
}
