using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ScheduleApp.User {
    internal class UserContext: DbContext {
        //
        // Данные о сервере и базе данных
        private const string _SERVER = @"Server = DESKTOP-MVOB93U\SQLEXPRESS;";
        private const string _DATABASE = @"Database = user_data;";
        private const string _TRUSTED_CONNECTION = @"Trusted_Connection = True;";
        private const string _TRUST_SERVER = @"TrustServerCertificate = True;";

        //
        // Данные в соответствии с полями класса User, созданного на основе получаемых полей из БД.
        public DbSet<User> User { get; set; }

        //
        // Настройка подключения
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(_SERVER + _DATABASE + _TRUSTED_CONNECTION + _TRUST_SERVER);
        }

        //
        // Данные о таблице в базе данных из которой получаем данные
        private readonly string _tableName = "login_data";
        private readonly string _tableScheme = "dbo";
        private readonly int _rowLength = 30;
        //
        // Настройка модели для соответствия таблице dbo.login_data (_tableScheme + "." + _tableName)
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<User>(entity => {
                //
                // Задаем имя таблицы и ее схему
                entity.ToTable(_tableName, _tableScheme);
                //
                // Указываем первичный ключ (в классе User)
                entity.HasKey(e => e.ID);

                SetPropertiesToEntity(entity);
            });
        }

        //
        // Установка связи между полями класса User и столбцов таблицы dbo.login_data
        private void SetPropertiesToEntity(EntityTypeBuilder<User> entity) {
            entity.Property(e => e.ID).HasColumnName("id");
            entity.Property(e => e.Email).HasColumnName("email").HasMaxLength(_rowLength).IsRequired();
            entity.Property(e => e.Password).HasColumnName("password").HasMaxLength(_rowLength).IsRequired();
            entity.Property(e => e.Surname).HasColumnName("surname").HasMaxLength(_rowLength).IsRequired();
            entity.Property(e => e.Name).HasColumnName("name").HasMaxLength(_rowLength).IsRequired();
            entity.Property(e => e.Patronymic).HasColumnName("patronymic").HasMaxLength(_rowLength);
        }
    }
}
