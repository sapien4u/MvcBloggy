//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcBloggy.Data.DataAccess.SqlServer
{
    using System;
    using System.Collections.Generic;
    
    public partial class BlogRoll
    {
        public int BlogRollId { get; set; }
        public int LanguageId { get; set; }
        public string BlogName { get; set; }
        public string BlogAuthor { get; set; }
        public string BlogUrl { get; set; }
        public string FeedUrl { get; set; }
        public Nullable<int> Order { get; set; }
        public bool IsApproved { get; set; }
    
        public virtual Language Language { get; set; }
    }
}
