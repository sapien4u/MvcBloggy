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
    using System;
    using System.Collections.Generic;
    
    public partial class Language
    {
        public Language()
        {
            this.BlogPosts = new HashSet<BlogPost>();
            this.BlogRolls = new HashSet<BlogRoll>();
            this.DynamicPages = new HashSet<DynamicPage>();
            this.RestrictedPageNames = new HashSet<RestrictedPageName>();
            this.Tags = new HashSet<Tag>();
        }
    
        public int LanguageId { get; set; }
        public string DisplayName { get; set; }
        public string Culture { get; set; }
        public string CultureOne { get; set; }
        public int Order { get; set; }
        public bool IsApproved { get; set; }
        public string CreationIp { get; set; }
        public System.DateTimeOffset CreatedOn { get; set; }
        public string LastUpdateIp { get; set; }
        public Nullable<System.DateTimeOffset> LastUpdatedOn { get; set; }
    
        public virtual ICollection<BlogPost> BlogPosts { get; set; }
        public virtual ICollection<BlogRoll> BlogRolls { get; set; }
        public virtual ICollection<DynamicPage> DynamicPages { get; set; }
        public virtual ICollection<RestrictedPageName> RestrictedPageNames { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
