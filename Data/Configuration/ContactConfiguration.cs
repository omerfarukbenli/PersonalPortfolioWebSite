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
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.FullName).IsRequired();
            builder.Property(x => x.Phone).IsRequired();
            builder.Property(x => x.Address).IsRequired();
            builder.HasData(
                    new Contact
                    {
                        Id = 1,
                        FullName = "Ömer Faruk Benli",
                        Phone = "0(544) 205 98 45",
                        Address = "İstanbul/Ümraniye"
                    }
                    );
        }
    }
}
