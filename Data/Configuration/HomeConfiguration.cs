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
    public class HomeConfiguration : IEntityTypeConfiguration<Home>
    {
        public void Configure(EntityTypeBuilder<Home> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.TitleOne).IsRequired();
            builder.Property(x => x.TitleTwo).IsRequired();
            builder.HasData(
                    new Home
                    {
                        Id = 1,
                        TitleOne = "Merhaba, kişisel websiteme hoş geldiniz. Hakkımda sekmesinden benim ile ilgili daha fazla bilgi edinebilir, İletişim sekmesinden,iletişim bilgieri ve sosyal ağ adreslerime ulaşabilirsiniz. iletişim bilgieri ve sosyal ağ adreslerime ulaşabilirsiniz. repolara göz gezdirebilirsiniz  ",
                        TitleTwo = "Hello, welcome to my personal website. More about me on the About me tab You can get more information, from the Contact tab, You can reach my contact information and social network addresses. From the My Repos tab, you can browse through the repos that I have published on the github network"
                    }
                    );
        }
    }
}
