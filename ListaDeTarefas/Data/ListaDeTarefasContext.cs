using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ListaDeTarefas.Modelos;

namespace ListaDeTarefas.Data
{
    public class ListaDeTarefasContext : DbContext
    {
        public ListaDeTarefasContext (DbContextOptions<ListaDeTarefasContext> options)
            : base(options)
        {
        }

        public DbSet<ListaDeTarefas.Modelos.Tarefa> Tarefa { get; set; } = default!;
    }
}
