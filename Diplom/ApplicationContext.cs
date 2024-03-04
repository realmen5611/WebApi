using Diplom.Model;
using Microsoft.EntityFrameworkCore;

namespace Diplom
{
    public class ApplicationContext : DbContext
    {
        private const string Password = "admin";
        private const string DbName = "DbSecurity";
        private const int Port = 3306;
        private const string Server = "127.0.0.1";
        private const string UserName = "root";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql($"Server={Server};database={DbName};Port={Port};User id={UserName};Password={Password}", new MySqlServerVersion(new Version(8, 0, 35)));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>().HasOne(x => x.Role).WithMany().HasForeignKey(x => x.idRole).IsRequired();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<UserEntity> user {  get; set; }
        public DbSet<RoleEntity> role { get; set; }
        public DbSet<DolshnostEntity> dolshnost { get; set; }
        public DbSet<EmployeeEntity> employee { get; set; }
        public DbSet<NarusheniaEmpEntity> narusheniaEmp {  get; set; }
        public DbSet<NarushiteliEntity> narushiteli { get; set; }
        public DbSet<PolEntity> pol { get; set; }
        public DbSet<PrestupleniaEntity> prestuplenia { get; set; }
        public DbSet<SanctionEntity> sanction { get; set; }
        public DbSet<VidPrestupleniaEntity> vidPrestuplenia { get; set; }
    }
}
