using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id=Guid.Parse("3F744EBC-DCCA-4B01-ACCB-16CB88E8EE7B"),
                Name="Asp.Net Core",
                CreatedBy="Admin test",
                CreatedDate=DateTime.Now,
                IsDeleted=false,

            },
            new Category
            {
                Id=Guid.Parse("EEF25E17-D0B9-4EDD-A1D1-1EF30CF36FFB"),
                Name="Visual Studio 2022",
                CreatedBy="Admin test",
                CreatedDate=DateTime.Now,
                IsDeleted=false,

            });


    }
    }
}
