﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace @__InformationTechnology__Circle.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class InformationTechnologyCircleEntities : DbContext
    {
        public InformationTechnologyCircleEntities()
            : base("name=InformationTechnologyCircleEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Administrator> Administrator { get; set; }
        public virtual DbSet<AutorizationStaff> AutorizationStaff { get; set; }
        public virtual DbSet<AutorizationUser> AutorizationUser { get; set; }
        public virtual DbSet<ExtracurricularActivities> ExtracurricularActivities { get; set; }
        public virtual DbSet<GeneralManager> GeneralManager { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}