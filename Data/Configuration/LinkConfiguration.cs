using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalPortfolioWebSite.Entities.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolioWebSite.Data.Configuration
{
    public class LinkConfiguration : IEntityTypeConfiguration<Link>
    {
        public void Configure(EntityTypeBuilder<Link> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired();
            builder.HasData(
            new Link
            {
                Id = 1,
                Name = "Odaklandığım yazılım dili, frameworkler ve veri tabanları"
            },
            new Link
            {
                Id = 2,
                Name = "My focus is on Software Languages, Frameworks and Databases"
            }
                    );

        }
    }
    
}
