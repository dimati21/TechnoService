﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ООО_Техносервис.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RequestEntities : DbContext
    {
        public RequestEntities()
            : base("name=RequestEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<Priority> Priority { get; set; }
        public virtual DbSet<Problem> Problem { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Stage> Stage { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<User> User { get; set; }
    
        public virtual ObjectResult<GetInfoRequestFromMaster_Result> GetInfoRequestFromMaster(Nullable<int> idMaster)
        {
            var idMasterParameter = idMaster.HasValue ?
                new ObjectParameter("IdMaster", idMaster) :
                new ObjectParameter("IdMaster", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetInfoRequestFromMaster_Result>("GetInfoRequestFromMaster", idMasterParameter);
        }
    }
}
