﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace MvcBloggy.Data.DataAccess.SqlServer
{
    public partial class MvcBloggyEntities : DbContext
    {
        public MvcBloggyEntities()
            : base("name=MvcBloggyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BlogPostComment> BlogPostComments { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<BlogRoll> BlogRolls { get; set; }
        public DbSet<DynamicPage> DynamicPages { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<RestrictedPageName> RestrictedPageNames { get; set; }
    }
}
