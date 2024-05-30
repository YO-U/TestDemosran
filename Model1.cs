using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TestDemosran
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Requests> Requests { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .HasMany(e => e.Comments)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.masterID);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Requests)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.clientID);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Requests1)
                .WithOptional(e => e.Users1)
                .HasForeignKey(e => e.masterID);
        }
    }
}
