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
    
    public partial class vw_LiveBlogPosts
    {
        public int BlogPostId { get; set; }
        public int LanguageId { get; set; }
        public Nullable<int> SecondaryId { get; set; }
        public string Title { get; set; }
        public string BriefInfo { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }
        public string URLString { get; set; }
        public string CreationIp { get; set; }
        public System.DateTimeOffset CreatedOn { get; set; }
        public Nullable<System.DateTimeOffset> LastUpdatedOn { get; set; }
        public string DisplayName { get; set; }
        public string Culture { get; set; }
        public string CultureOne { get; set; }
    }
}
