using Microsoft.EntityFrameworkCore.Migrations;

namespace SpencersQualityQuotes.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Quote = table.Column<string>(nullable: false),
                    Author = table.Column<string>(nullable: false),
                    Date = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Citation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "Citation", "Date", "Quote", "Subject" },
                values: new object[] { 1, "Dale Carnegie", "How to Win Friends and Influence People", null, "You can make more friends in two months by becoming interested in other people than you can in two years by trying to get other people interested in you.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "Citation", "Date", "Quote", "Subject" },
                values: new object[] { 2, "Malcolm Gladwell", "The Tipping Point: How Little Things Can Make a Big Difference", null, "A study at the University of Utah found that if you ask someone why he is friendly with someone else, he’ll say it is because he and his friend share similar attitudes. But if you actually quiz the two of them on their attitudes, you’ll find out that what they actually share is similar activities. We’re friends with the people we do things with, as much as we are with the people we resemble. We don’t seek out friends, in other words. We associate with the people who occupy the same small, physical spaces that we do.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "Citation", "Date", "Quote", "Subject" },
                values: new object[] { 3, "Dave Ramsey", "The Total Money Makeover: A Proven Plan for Financial Fitness", null, "Winning at money is 80 percent behavior and 20 percent head knowledge. What to do isn’t the problem; doing it is. Most of us know what to do, but we just don’t do it. If I can control the guy in the mirror, I can be skinny and rich.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "Citation", "Date", "Quote", "Subject" },
                values: new object[] { 4, "Shad Baird", null, null, "This is a test quote to delete", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "Citation", "Date", "Quote", "Subject" },
                values: new object[] { 5, "Shad Baird", null, null, "This is a test quote to delete 2", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quotes");
        }
    }
}
