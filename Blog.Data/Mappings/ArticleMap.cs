using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id=Guid.NewGuid(),
                Title="Asp. Net Core Deneme Makalesi 1",
                Content="Asp. Net Core Eget egestas purus viverra accumsan in nisl nisi. Arcu cursus euismod quis viverra nibh. Ac orci phasellus egestas tellus. Aliquam eleifend mi in nulla. Ullamcorper malesuada proin libero nunc consequat interdum varius sit amet. Fames ac turpis egestas integer eget. Et sollicitudin ac orci phasellus egestas tellus rutrum tellus. Neque egestas congue quisque egestas diam in arcu cursus euismod. Viverra maecenas accumsan lacus vel facilisis volutpat est velit egestas. Sollicitudin ac orci phasellus egestas tellus rutrum. Aliquet eget sit amet tellus. Aliquam vestibulum morbi blandit cursus risus. Sollicitudin tempor id eu nisl nunc mi ipsum. Semper eget duis at tellus at urna. Accumsan sit amet nulla facilisi morbi tempus iaculis urna id. Ultrices vitae auctor eu augue ut. Porttitor rhoncus dolor purus non. Lobortis scelerisque fermentum dui faucibus in ornare. Orci ac auctor augue mauris. Aliquet sagittis id consectetur purus ut faucibus pulvinar.",
                ViewCount=15,
                CategoryId=Guid.Parse("3F744EBC-DCCA-4B01-ACCB-16CB88E8EE7B"),
                ImageId=Guid.Parse("8546782B-AC8C-41A8-8DCE-851C8BE76CC0"),
                CreatedBy="Admin test",
                CreatedDate=DateTime.Now,
                IsDeleted=false,
                UserId=Guid.Parse("8BC8F0F5-3A0D-440D-B13B-EB6DACAFEDD2"),


            },
            new Article
            {
                Id=Guid.NewGuid(),
                Title="Visual Studio Deneme Makalesi 1",
                Content="Visual Studio Eget egestas purus viverra accumsan in nisl nisi. Arcu cursus euismod quis viverra nibh. Ac orci phasellus egestas tellus. Aliquam eleifend mi in nulla. Ullamcorper malesuada proin libero nunc consequat interdum varius sit amet. Fames ac turpis egestas integer eget. Et sollicitudin ac orci phasellus egestas tellus rutrum tellus. Neque egestas congue quisque egestas diam in arcu cursus euismod. Viverra maecenas accumsan lacus vel facilisis volutpat est velit egestas. Sollicitudin ac orci phasellus egestas tellus rutrum. Aliquet eget sit amet tellus. Aliquam vestibulum morbi blandit cursus risus. Sollicitudin tempor id eu nisl nunc mi ipsum. Semper eget duis at tellus at urna. Accumsan sit amet nulla facilisi morbi tempus iaculis urna id. Ultrices vitae auctor eu augue ut. Porttitor rhoncus dolor purus non. Lobortis scelerisque fermentum dui faucibus in ornare. Orci ac auctor augue mauris. Aliquet sagittis id consectetur purus ut faucibus pulvinar.",
                ViewCount=15,
                CategoryId=Guid.Parse("EEF25E17-D0B9-4EDD-A1D1-1EF30CF36FFB"),
                ImageId=Guid.Parse("0742DD33-C4AC-4591-B245-F36AED3621E9"),
                CreatedBy="Admin test",
                CreatedDate=DateTime.Now,
                IsDeleted=false,
                UserId=Guid.Parse("366086F4-55A3-44C2-98FA-63C56775CDFB"),

            });
           
        }
    }
}
