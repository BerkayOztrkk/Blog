﻿using Blog.Entity.Entities;
using Blog.Entity.ViewModels.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.ViewModels.Articles
{
    public class ArticleViewModel
    {

		public string Title { get; set; }
		public string Content { get; set; }
		public int ViewCount { get; set; } = 0;

		public Guid CategoryId { get; set; }
		public Category Category { get; set; }

		public Guid? ImageId { get; set; }
		public Image Image { get; set; }

		public Guid UserId { get; set; }
		public AppUser User { get; set; }





	}
}
