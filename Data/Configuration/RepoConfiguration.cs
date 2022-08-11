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
    public class RepoConfiguration : IEntityTypeConfiguration<Repo>
    {
        public void Configure(EntityTypeBuilder<Repo> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.ContentSummary).IsRequired();
            builder.HasData(
                    new Repo
                    {
                        Id = 1,
                        Title = "Crud-Many-to-Many",
                        ContentSummary = "Çoka çok ilişki kurularak, çoklu crud işlemleri yapıldı",
                        Url = "https://github.com/omerfarukbenli/Crud-Many-to-Many"
                    },
                    new Repo
                    {
                        Id = 2,
                        Title = "Asp.Net-6-Auth",
                        ContentSummary = "Asp.Net'te Authentication ve Authorization işlemleri yapıldı",
                        Url = "https://github.com/omerfarukbenli/Asp.Net-6-Auth"
                    },
                    new Repo
                    {
                        Id = 3,
                        Title = "Asp.Net-6-Öğrenci-Kayıt-Sistemi",
                        ContentSummary = "Asp.Net'te Crud operasyonları yapılarak öğrenci kayıt işlemleri yapıldı",
                        Url = "https://github.com/omerfarukbenli/Asp.Net-6-OgrenciKayitSistemi-Backend-Frontend"
                    },
                    new Repo
                    {
                        Id = 4,
                        Title = "Angular Crud",
                        ContentSummary = "Angular 14 frameworkü kullanılarak temel düzeyde crud işlemleri yapıldı",
                        Url = "https://github.com/omerfarukbenli/Angular-Crud-islemleri"
                    }

                    );
        }
    }
}
