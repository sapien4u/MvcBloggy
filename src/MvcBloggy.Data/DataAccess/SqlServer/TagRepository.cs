﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenericRepository.EF;
using MvcBloggy.Data.DataAccess.Infrastructure;

namespace MvcBloggy.Data.DataAccess.SqlServer {

    public class TagRepository : Repository<MvcBloggyContext, Tag>, ITagRepository {

    }
}