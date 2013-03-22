﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inamu.Sidoc.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SIDOCEntities : DbContext
    {
        public SIDOCEntities()
            : base("name=SIDOCEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<TematicaGeografica> TematicaGeograficas { get; set; }
        public DbSet<CiudadEditorial> CiudadEditorials { get; set; }
        public DbSet<Estado> Estadoes { get; set; }
        public DbSet<InformacionDescriptiva> InformacionDescriptivas { get; set; }
        public DbSet<NivelBibliografico> NivelBibliograficoes { get; set; }
        public DbSet<NivelDeRegistro> NivelDeRegistroes { get; set; }
        public DbSet<Periocidad> Periocidads { get; set; }
        public DbSet<Documento> Documentoes { get; set; }
        public DbSet<TipoDeFecha> TipoDeFechas { get; set; }
        public DbSet<TipoDeLiteratura> TipoDeLiteraturas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<NivelEducativo> NivelEducativoes { get; set; }
        public DbSet<Genero> Generoes { get; set; }
        public DbSet<TipoDeIdentificacion> TipoDeIdentificacions { get; set; }
        public DbSet<Perfil> Perfils { get; set; }
        public DbSet<Autoria> Autorias { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<TiposDeAutoria> TiposDeAutorias { get; set; }
        public DbSet<AutoriasDelLibro> AutoriasDelLibroes { get; set; }
    }
}
