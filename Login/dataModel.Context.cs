﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Login
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class loginEntities : DbContext
    {
        public loginEntities()
            : base("name=loginEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<usuario> usuario { get; set; }
    
        public virtual ObjectResult<Nullable<int>> sesion(string uusuario, string ccontraseña)
        {
            var uusuarioParameter = uusuario != null ?
                new ObjectParameter("uusuario", uusuario) :
                new ObjectParameter("uusuario", typeof(string));
    
            var ccontraseñaParameter = ccontraseña != null ?
                new ObjectParameter("ccontraseña", ccontraseña) :
                new ObjectParameter("ccontraseña", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sesion", uusuarioParameter, ccontraseñaParameter);
        }
    }
}