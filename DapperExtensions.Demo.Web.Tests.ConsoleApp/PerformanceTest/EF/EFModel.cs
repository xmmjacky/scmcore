namespace DapperExtensions.Demo.Tests.PerformanceTest.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EFModel : DbContext
    {
        public EFModel()
            : base("name=EFModel")
        {
        }

        public virtual DbSet<UserInfo> UserInfo { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
