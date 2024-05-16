using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QL_KhachSan
{
    public partial class BillContext : DbContext
    {
        public BillContext()
            : base("name=BillContext")
        {
        }

        public virtual DbSet<View_All_Bill_Test> View_All_Bill_Test { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<View_All_Bill_Test>()
                .Property(e => e.idkh)
                .IsUnicode(false);

            modelBuilder.Entity<View_All_Bill_Test>()
                .Property(e => e.transmonth)
                .IsUnicode(false);

            modelBuilder.Entity<View_All_Bill_Test>()
                .Property(e => e.trangthai)
                .IsUnicode(false);

            modelBuilder.Entity<View_All_Bill_Test>()
                .Property(e => e.Muc)
                .IsUnicode(false);
        }
    }
}
