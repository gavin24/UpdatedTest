namespace DevloperTest.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MenuItemDataModel : DbContext
    {
        public MenuItemDataModel()
            : base("name=MenuItemDataModel")
        {
        }

        public virtual DbSet<MenuItem> MenuItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuItem>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<MenuItem>()
                .Property(e => e.URL)
                .IsUnicode(false);
        }
    }
}
