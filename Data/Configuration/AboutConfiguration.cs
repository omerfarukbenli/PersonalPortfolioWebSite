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
    public class AboutConfiguration : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CvTurk).IsRequired();
            builder.Property(x => x.CvEnglish).IsRequired();
            builder.HasData(
                    new About
                    {
                        Id = 1,
                        CvTurk = "Merhabalar, kendimi kısaca tanıtmam gerekirse adım ve soyadım Ömer Faruk Benli, 26.0.1993 tarihinde, İstanbul'da doğdum. Üniversite eğitimimi, Sakarya Üniversitesi-Çalışma Ekonomisi ve Endüstri İlişkileri Bölümünde 3.52 not ortalaması ile tamamladım. Yüksek Lisansıma yine Sakarya Üniversitesinde başlamış olup, yüksek lisans tezini 2023 yılında tamamlamayıp mezun olmayı planlamaktayım. Üniversite sonrası 3.5 yıl boyunca özel sektörde, gayrimenkul değerleme uzmanı olarak görev yaptım. 2021 yılında yazılım alanında kariyer yapmak adına yazılım eğitimi almaya başladım. Asansor com adlı siteyi, backend ve frontend kısımlarını geliştirip yayınladım. Yazılım dili olarak C#, Framework olarak Asp.Net ve Angular'a yoğunlaşmış bulunmaktayım.  ",
                        CvEnglish = "Hello, my name is Ömer Faruk Benli, I was born on 26.01.1993 in Istanbul. My university education, Sakarya  An average of 3.52 processes was completed in the Department of University-Labor Economy and Industry. I started my master's degree again at Sakarya University and completed my master's thesis. I am not completing and graduating in 2023. For 3.5 years post-university I worked as private security, management evaluations. software in 2021 No preparation has been made for filing. Elevator com, backend and I develop and publish the front parts. C# as software language, C# as Framework I am focused on Asp.Net and Angular"
                    }
                    );
        }
    }
}
