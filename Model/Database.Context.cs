﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBCosmetiqueEntities : DbContext
    {
        public DBCosmetiqueEntities()
            : base("name=DBCosmetiqueEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Заказы> Заказы { get; set; }
        public virtual DbSet<КлиентФЛ> КлиентФЛ { get; set; }
        public virtual DbSet<Клиенты> Клиенты { get; set; }
        public virtual DbSet<КлиентЮЛ> КлиентЮЛ { get; set; }
        public virtual DbSet<Сотрудники> Сотрудники { get; set; }
        public virtual DbSet<СтатусУслугиВЗаказе> СтатусУслугиВЗаказе { get; set; }
        public virtual DbSet<Услуги> Услуги { get; set; }
        public virtual DbSet<УслугиВЗаказе> УслугиВЗаказе { get; set; }
        public virtual DbSet<УслугиСотрудников> УслугиСотрудников { get; set; }
    }
}
