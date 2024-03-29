using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data.Mappings
{
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id=Guid.Parse("8546782B-AC8C-41A8-8DCE-851C8BE76CC0"),
                FileName="images/testimage",
                FileType="jpg",
                CreatedBy="Admin test",
                CreatedDate=DateTime.Now,
                IsDeleted=false,


            },
            new Image
            {
                Id=Guid.Parse("0742DD33-C4AC-4591-B245-F36AED3621E9"),
                FileName="images/vstest",
                FileType="png",
                CreatedBy="Admin test",
                CreatedDate=DateTime.Now,
                IsDeleted=false,


            }
            );
        }
    }
}
