using Microsoft.EntityFrameworkCore;
using Trilha_NET_API_Desafio.Models;

namespace Trilha_NET_API_Desafio.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {

        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
