namespace BibleVerseApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class VersesDB : DbContext
    {
        public VersesDB()
            : base("name=VersesEntities")
        {
        }

        public virtual DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table>()
                .Property(e => e.Testament)
                .IsUnicode(false);

            modelBuilder.Entity<Table>()
                .Property(e => e.Book)
                .IsUnicode(false);

            modelBuilder.Entity<Table>()
                .Property(e => e.Text)
                .IsUnicode(false);
        }
    }
}
