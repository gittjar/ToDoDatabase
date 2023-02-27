using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    /* public class TodoContext : DbContext
     {
         public TodoContext(DbContextOptions<TodoContext> options)
             : base(options)
         {
         }

         public DbSet<TodoItem> TodoItems { get; set; }
     */

    public class AppSettingsDbContext : DbContext
    {


        public AppSettingsDbContext() : base()
        {

        }

        public AppSettingsDbContext(DbContextOptions<AppSettingsDbContext> options) : base(options)
        {

        }

        public virtual DbSet<TodoItem> TodoItems { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    => optionsBuilder.UseMySql("server=localhost;user=testihahmo;password=pass12345;database=tododatabase", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.9.4-mariadb"));



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<TodoItem>(entity =>
            {
                entity.HasKey(s => s.Id).HasName("PRIMARY");

                entity.Property(s => s.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)");
                entity.Property(s => s.Name).HasMaxLength(100);
            });
          //  OnModelCreatingPartial(modelBuilder);

        }

      //  partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}


    // lisätty tämä ja muokattu tietokantaa varten --> TodoContext : DbContext !!!
    /*
    public class TodoContext : DbContext
         {
             public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }
             protected override void OnModelCreating(ModelBuilder modelBuilder)
             {
                 base.OnModelCreating(modelBuilder);
                 modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
             }
         public DbSet<TodoItem> TodoItems { get; set; }


       
    } */




