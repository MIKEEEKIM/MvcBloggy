//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcBloggy.Domain.Entities
{
    using GenericRepository;
    using System;
    using System.Collections.Generic;
    
    public partial class BlogPostUrl : IEntity<Guid>
    {
        public System.Guid Id { get; set; }
        public System.Guid BlogPostId { get; set; }
        public string UrlPortion { get; set; }
        public string CreationIp { get; set; }
        public System.DateTimeOffset CreatedOn { get; set; }
        public string LastUpdateIp { get; set; }
        public Nullable<System.DateTimeOffset> LastUpdatedOn { get; set; }
    
        public virtual BlogPost BlogPost { get; set; }
    }
}
