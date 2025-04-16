using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Examples",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examples", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GunQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ExampleId = table.Column<int>(type: "INTEGER", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    OptionA = table.Column<string>(type: "TEXT", nullable: false),
                    OptionB = table.Column<string>(type: "TEXT", nullable: false),
                    OptionC = table.Column<string>(type: "TEXT", nullable: false),
                    OptionD = table.Column<string>(type: "TEXT", nullable: false),
                    OptionE = table.Column<string>(type: "TEXT", nullable: false),
                    TrueOption = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GunQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GunQuestions_Examples_ExampleId",
                        column: x => x.ExampleId,
                        principalTable: "Examples",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ExampleId = table.Column<int>(type: "INTEGER", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    OptionA = table.Column<string>(type: "TEXT", nullable: false),
                    OptionB = table.Column<string>(type: "TEXT", nullable: false),
                    OptionC = table.Column<string>(type: "TEXT", nullable: false),
                    OptionD = table.Column<string>(type: "TEXT", nullable: false),
                    OptionE = table.Column<string>(type: "TEXT", nullable: false),
                    TrueOption = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Examples_ExampleId",
                        column: x => x.ExampleId,
                        principalTable: "Examples",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Examples",
                columns: new[] { "Id", "CreateDate", "Title", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ÖZEL GÜVENLİK 112. TEMEL EĞİTİM YAZILI SINAV SORULARI (A GRUBU)", null });

            migrationBuilder.InsertData(
                table: "GunQuestions",
                columns: new[] { "Id", "Content", "CreateDate", "ExampleId", "OptionA", "OptionB", "OptionC", "OptionD", "OptionE", "TrueOption", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "1. Fişek yatağında fişek bulunan tabancanın güvenli bir şekilde boşaltılması için sırasıyla izlenmesigereken yol nasıl olmalıdır?  \n                    I - Tabanca ölü noktaya çevrilir  \n                    II- Sürgü çekilip gözle fişek yatağı \n                    kontrol edilir ve bırakılır \n                    III- Şarjör çıkartılır \n                    IV- Ölü bölgeye tetik düşürülerek silah \n                    kılıfa konulur ", new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A) I, III, II, IV ", "B) III, II, I,IV", "C) IV, I,II, III ", "D) III, IV, I, II ", "E) II, IV, III, I", "A", null },
                    { 2, "2. Aşağıdakilerden hangileri silahın dolduruş yapmasına engel nedenlerden değildir?  \n                I. Şarjörde fişek olmayabilir \n                II. İğne yayı kırık olabilir \n                III. Şarjör tutucu pimi arızalı olabilir \n                IV. Barut miktarı az olabilir  \n                V.  Şarjörde hatalı fişek olabilir.   ", new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A) I-II ", "B) I-III-V ", "C) II-IV", "D) III-IV ", "E) I-II-IV", "C", null },
                    { 3, "3. Aşağıdakilerden hangisinde tabancanın sökülme sırası doğru olarak verilmiştir?  \n                I. Kapak takımını çıkart (sürgü) \n                II. Şarjörü çıkart  \n                III. Yerine getiren yayı çıkart \n                IV. Namluyu çıkart \n                V. Fişek yatağını kontrol et ", new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A) II-I-IV-III-V ", "B) V-IV-III-II-I ", "C) II-V-I-III-IV ", "D) III-II-I-V-IV", "E) IV-I-V-III-II ", "C", null }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "CreateDate", "ExampleId", "OptionA", "OptionB", "OptionC", "OptionD", "OptionE", "TrueOption", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "1. Türkiye’de özel güvenlik anlayışınıntemeli 1981 yılında 2945 sayılı Kanun ileatılmıştır.BuKanunuyürürlüktenkaldıran ve halen yürürlükte olan 5188sayılı Özel Güvenlik Hizmetlerine DairKanun hangi tarihte yürürlüğe girmiştir?", new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A) 2000", "B) 2002", "C) 2004", "D) 2006", "E) 2008", "C", null },
                    { 2, "2. 5188sayılı Özel Güvenlik Hizmetlerine Dair   Kanunun   7’inci   maddesinde belirtilen  “Özel  güvenlik  görevlilerinin yetkileri”  ile  ilgili  aşağıdaki  ifadelerden hangisi yanlıştır?", new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A) Terk  edilmiş  ve  bulunmuş  eşyayı emanete alma", "B) Olay  yerinde delil  toplama  ve  mağdurun ifadesini alma", "C) Tabiî  afet  durumlarında  ve  imdat istenmesi halinde görev alanındaki işyeri ve konutlara girme", "D) Görev  alanında,  haklarında  yakalama emri bulunan kişileri yakalama ve arama", "E) Kişinin vücudu veya sağlığı bakımından mevcut  bir  tehlikeden  korunması  amacıyla yakalama", "B", null },
                    { 3, "3.Yabancıkişilerin özel güvenlik şirketi kurabilmesi   ve   yabancı   şirketlerin Türkiye’de   özel   güvenlik   hizmeti verebilmesinde aranan temel ilke nedir? ", new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A) Mülkilik", "B) Şahsilik", "C) Koruma", "D) Evrensellik", "E) Mütekabiliyet", "E", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GunQuestions_ExampleId",
                table: "GunQuestions",
                column: "ExampleId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ExampleId",
                table: "Questions",
                column: "ExampleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GunQuestions");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Examples");
        }
    }
}
