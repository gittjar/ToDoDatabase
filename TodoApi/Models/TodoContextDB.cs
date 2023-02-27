/*using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{

        // lisätty tämä tietokantaa varten
        public class TodoDBcontext : DbContext
        {
            public TodoDBcontext(DbContextOptions<TodoDBcontext> options) : base(options) { }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            }

        public DbSet<TodoItem> TodoItems { get; set; }
    }







    }

*/
