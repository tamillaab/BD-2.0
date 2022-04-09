namespace BD_2._0
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BD_2 : DbContext
    {
        // Контекст настроен для использования строки подключения "BD_2" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "BD_2._0.BD_2" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "BD_2" 
        // в файле конфигурации приложения.
        public BD_2()
            : base("name=BD 2.0")
        {
        }
        public DbSet<Student> sts { get; set; }
        public DbSet<Event> evs { get; set; }
        public DbSet<Theatre> thrs { get; set; }
        public DbSet<Museum> msms { get; set; }
        public DbSet<Expo> exps { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}