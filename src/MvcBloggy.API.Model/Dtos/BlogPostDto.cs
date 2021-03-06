﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBloggy.API.Model.Dtos {

    public class BlogPostDto : IDto {

        public Guid Key { get; set; }
        public Guid LanguageKey { get; set; }
        public int? SecondaryKey { get; set; }
        public string Title { get; set; }
        public string BriefInfo { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }
        public bool IsApproved { get; set; }
        public string CreationIp { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string LastUpdateIp { get; set; }
        public DateTimeOffset? LastUpdatedOn { get; set; }
    }
}