using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Atm.datanuser
{
    public partial class appatm : DbContext
    {
        public appatm()
            : base("name=appatm2")
        {
        }

        public virtual DbSet<taikhoan> taikhoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<taikhoan>()
                .Property(e => e.tentaikhoan)
                .IsUnicode(false);

            modelBuilder.Entity<taikhoan>()
                .Property(e => e.matkhau)
                .IsUnicode(false);
        }
    }
}
