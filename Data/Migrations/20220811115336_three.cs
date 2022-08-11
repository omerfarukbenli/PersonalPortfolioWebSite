using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalPortfolioWebSite.Data.Migrations
{
    public partial class three : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "Id", "CvEnglish", "CvTurk" },
                values: new object[] { 1, "Hello, my name is Ömer Faruk Benli, I was born on 26.01.1993 in Istanbul. My university education, Sakarya  An average of 3.52 processes was completed in the Department of University-Labor Economy and Industry. I started my master's degree again at Sakarya University and completed my master's thesis. I am not completing and graduating in 2023. For 3.5 years post-university I worked as private security, management evaluations. software in 2021 No preparation has been made for filing. Elevator com, backend and I develop and publish the front parts. C# as software language, C# as Framework I am focused on Asp.Net and Angular", "Merhabalar, kendimi kısaca tanıtmam gerekirse adım ve soyadım Ömer Faruk Benli, 26.0.1993 tarihinde, İstanbul'da doğdum. Üniversite eğitimimi, Sakarya Üniversitesi-Çalışma Ekonomisi ve Endüstri İlişkileri Bölümünde 3.52 not ortalaması ile tamamladım. Yüksek Lisansıma yine Sakarya Üniversitesinde başlamış olup, yüksek lisans tezini 2023 yılında tamamlamayıp mezun olmayı planlamaktayım. Üniversite sonrası 3.5 yıl boyunca özel sektörde, gayrimenkul değerleme uzmanı olarak görev yaptım. 2021 yılında yazılım alanında kariyer yapmak adına yazılım eğitimi almaya başladım. Asansor com adlı siteyi, backend ve frontend kısımlarını geliştirip yayınladım. Yazılım dili olarak C#, Framework olarak Asp.Net ve Angular'a yoğunlaşmış bulunmaktayım.  " });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "Id", "Address", "FullName", "Phone" },
                values: new object[] { 1, "İstanbul/Ümraniye", "Ömer Faruk Benli", "0(544) 205 98 45" });

            migrationBuilder.InsertData(
                table: "Home",
                columns: new[] { "Id", "TitleOne", "TitleTwo" },
                values: new object[] { 1, "Merhaba, kişisel websiteme hoş geldiniz. Hakkımda sekmesinden benim ile ilgili daha fazla bilgi edinebilir, İletişim sekmesinden,iletişim bilgieri ve sosyal ağ adreslerime ulaşabilirsiniz. iletişim bilgieri ve sosyal ağ adreslerime ulaşabilirsiniz. repolara göz gezdirebilirsiniz  ", "Hello, welcome to my personal website. More about me on the About me tab You can get more information, from the Contact tab, You can reach my contact information and social network addresses. From the My Repos tab, you can browse through the repos that I have published on the github network" });

            migrationBuilder.InsertData(
                table: "Link",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Odaklandığım yazılım dili, frameworkler ve veri tabanları" },
                    { 2, "My focus is on Software Languages, Frameworks and Databases" }
                });

            migrationBuilder.InsertData(
                table: "Repo",
                columns: new[] { "Id", "ContentSummary", "Title", "Url" },
                values: new object[,]
                {
                    { 1, "Çoka çok ilişki kurularak, çoklu crud işlemleri yapıldı", "Crud-Many-to-Many", "https://github.com/omerfarukbenli/Crud-Many-to-Many" },
                    { 2, "Asp.Net'te Authentication ve Authorization işlemleri yapıldı", "Asp.Net-6-Auth", "https://github.com/omerfarukbenli/Asp.Net-6-Auth" },
                    { 3, "Asp.Net'te Crud operasyonları yapılarak öğrenci kayıt işlemleri yapıldı", "Asp.Net-6-Öğrenci-Kayıt-Sistemi", "https://github.com/omerfarukbenli/Asp.Net-6-OgrenciKayitSistemi-Backend-Frontend" },
                    { 4, "Angular 14 frameworkü kullanılarak temel düzeyde crud işlemleri yapıldı", "Angular Crud", "https://github.com/omerfarukbenli/Angular-Crud-islemleri" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "About",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Home",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Link",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Link",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Repo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Repo",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Repo",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Repo",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
