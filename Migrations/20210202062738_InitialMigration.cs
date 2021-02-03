﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace NetStore.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    GenreId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                    table.ForeignKey(
                        name: "FK_Genres_Genres_GenreId1",
                        column: x => x.GenreId1,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    ImageThumbnailUrl = table.Column<string>(nullable: true),
                    IsBookOfTheWeek = table.Column<bool>(nullable: false),
                    InStock = table.Column<bool>(nullable: false),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Description", "GenreId1", "GenreName" },
                values: new object[] { 1, null, null, "Fantasy" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Description", "GenreId1", "GenreName" },
                values: new object[] { 2, null, null, "Science Fiction" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Description", "GenreId1", "GenreName" },
                values: new object[] { 3, null, null, "Crime" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "GenreId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsBookOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "https://images-na.ssl-images-amazon.com/images/I/71ykU-RQ0nL._AC_SL1000_.jpg", "https://images-na.ssl-images-amazon.com/images/I/71ykU-RQ0nL._AC_SL1000_.jpg", true, true, "Harry Potter is midway through his training as a wizard and his coming of age. Harry wants to get away from the pernicious Dursleys and go to the International Quidditch Cup. He wants to find out about the mysterious event that's supposed to take place at Hogwarts this year, an event involving two other rival schools of magic, and a competition that hasn't happened for a hundred years. He wants to be a normal, fourteen-year-old wizard. But unfortunately for Harry Potter, he's not normal - even by wizarding standards. And in his case, different can be deadl", "Harry Potter and the Goblet of Fire", 12.95m, "The paperback edition of the legendary, record-breaking, best-selling fourth Harry Potter novel." },
                    { 2, 1, "https://images-na.ssl-images-amazon.com/images/I/51tW-UJVfHL._SX321_BO1,204,203,200_.jpg", "https://images-na.ssl-images-amazon.com/images/I/51tW-UJVfHL._SX321_BO1,204,203,200_.jpg", true, false, "In ancient times the Rings of Power were crafted by the Elven-smiths, and Sauron, the Dark Lord, forged the One Ring, filling it with his own power so that he could rule all others. But the One Ring was taken from him, and though he sought it throughout Middle-earth, it remained lost to him. After many ages it fell into the hands of Bilbo Baggins, as told in The Hobbit. In a sleepy village in the Shire, young Frodo Baggins finds himself faced with an immense task, as his elderly cousin Bilbo entrusts the Ring to his care. Frodo must leave his home and make a perilous journey across Middle-earth to the Cracks of Doom, there to destroy the Ring and foil the Dark Lord in his evil purpose.", "The Fellowship of the Ring: Being the First Part of The Lord of the Rings (1)", 18.95m, "The first volume in J.R.R. Tolkien's epic adventure THE LORD OF THE RINGS One Ring to rule them all, One Ring to find them, One Ring to bring them all and in the darkness bind them." },
                    { 7, 1, "https://images-na.ssl-images-amazon.com/images/I/51erHMLhIzL.jpg", "https://images-na.ssl-images-amazon.com/images/I/51erHMLhIzL.jpg", false, false, "Four adventurous siblings—Peter, Susan, Edmund, and Lucy Pevensie—step through a wardrobe door and into the land of Narnia, a land frozen in eternal winter and enslaved by the power of the White Witch. But when almost all hope is lost, the return of the Great Lion, Aslan, signals a great change . . . and a great sacrifice. Open the door and enter a new world! The Lion, the Witch and the Wardrobe is the second book in C.S.Lewis's classic fantasy series, which has been captivating readers of all ages with a magical land and unforgettable characters for over sixty years", "The Lion, the Witch and the Wardrobe (The Chronicles of Narnia)", 15.95m, "A beautiful paperback edition of The Lion, the Witch and the Wardrobe, book two in the classic fantasy series The Chronicles of Narnia" },
                    { 9, 1, "https://m.media-amazon.com/images/I/51nf5h+qfNL._SY346_.jpg", "https://m.media-amazon.com/images/I/51nf5h+qfNL._SY346_.jpg", true, true, "When Alexander loses his brother to an assassin’s arrow, he learns that his family protects an ancient secret and reluctantly finds himself at the center of a war that was supposed to have ended long ago. Pursued by dark minions of an ancient enemy, Alexander flees to the mountain city of Glen Morillian where he discovers that he is the heir to the throne of Ruatha,  one of the Seven Isles.", "Thinblade (Sovereign of the Seven Isles Book 1)", 15.95m, "The air stilled. The room fell silent. A shockwave passed through them. Everyone froze, faces white with fear. The ancient evil had awakened…" },
                    { 10, 1, "https://images-na.ssl-images-amazon.com/images/I/91RQ5d-eIqL.jpg", "https://images-na.ssl-images-amazon.com/images/I/91RQ5d-eIqL.jpg", true, false, "Percy Jackson is a good kid, but he can't seem to focus on his schoolwork or control his temper. And lately, being away at boarding school is only getting worse-Percy could have sworn his pre-algebra teacher turned into a monster and tried to kill him.", "The Lightning Thief (Percy Jackson and the Olympians, Book 1)", 15.95m, "Percy Jackson is about to be kicked out of boarding school...again. And that's the least of his troubles." },
                    { 3, 2, "https://images-na.ssl-images-amazon.com/images/I/91oK-po6+GL.jpg", "https://images-na.ssl-images-amazon.com/images/I/91oK-po6+GL.jpg", true, false, "During a routine survey mission on an uncolonized planet, Kira finds an alien relic. At first she's delighted, but elation turns to terror when the ancient dust around her begins to move. As war erupts among the stars, Kira is launched into a galaxy - spanning odyssey of discovery and transformation.First contact isn't at all what she imagined, and events push her to the very limits of what it means to be human. While Kira faces her own horrors, Earth and its colonies stand upon the brink of annihilation. Now, Kira might be humanity's greatest and final hope . . .", "To Sleep in a Sea of Stars", 18.95m, "To Sleep in a Sea of Stars is a brand new epic novel from #1 New York Times bestselling author of Eragon, Christopher Paolini." },
                    { 4, 2, "https://images-na.ssl-images-amazon.com/images/I/51glJgVC1IL.jpg", "https://images-na.ssl-images-amazon.com/images/I/51glJgVC1IL.jpg", true, false, "The last remnants of the human race left a dying Earth, desperate to find a new home among the stars. Following in the footsteps of their ancestors, they discover the greatest treasure of the past age -- a world terraformed and prepared for human life. But all is not right in this new Eden. In the long years since the planet was abandoned, the work of its architects has borne disastrous fruit. The planet is not waiting for them, pristine and unoccupied. New masters have turned it from a refuge into mankind's worst nightmare.", "Children of Time", 15.95m, "Adrian Tchaikovksy's award-winning novel Children of Time, is the epic story of humanity's battle for survival on a terraformed planet." },
                    { 11, 2, "https://images-na.ssl-images-amazon.com/images/I/41iyBtDoRUL.jpg", "https://images-na.ssl-images-amazon.com/images/I/41iyBtDoRUL.jpg", false, false, "When Jack Harrison climbed down the short ladder from the airlock and stepped onto the debris covered soil, the ground crackled with the sound of dried leaves and twigs. Warm sunlight shined through his helmet, making him almost forget the decade he just spent captaining Earth’s first ship to another star system. The serene tropical surroundings, though, stood in stark contrast to the long abandoned structures that lay nearby.", "Prelude to Extinction", 18.95m, "Earth’s first interstellar mission … An alien colony in ruins … Their fight for survival has only just begun." },
                    { 5, 3, "https://images-na.ssl-images-amazon.com/images/I/71QB5OnbfML.jpg", "https://images-na.ssl-images-amazon.com/images/I/71QB5OnbfML.jpg", true, false, "On the morning of July 12, 2017, the FBI Boston field office receives what appears to be a hoax call: a man rescued from the waters off Massachusetts has claimed that his sailboat was hijacked and used to smuggle weapons and terrorists into the United States. With local agents tasked to prepare for an evening Presidential visit to downtown Boston, and with procedures requiring a response to any threat, no matter how unreliable it may seem, FBI administrative staffer Ben Porter is dispatched to investigate the call. Can Ben, untrained in field work and relying only on his wits and intuition, uncover the deadly plot … in time to stop it?", "False Assurances: Ben Porter Series - Book One", 13.95m, "A thoroughly riveting two-novel debut introducing a compelling new hero" },
                    { 6, 3, "https://images-na.ssl-images-amazon.com/images/I/618r1qu-s1L.jpg", "https://images-na.ssl-images-amazon.com/images/I/618r1qu-s1L.jpg", true, false, "When Ella Longfield overhears two attractive young men flirting with teenage girls on a train, she thinks nothing of it—until she realises they are fresh out of prison and her maternal instinct is put on high alert. But just as she’s decided to call for help, something stops her. The next day, she wakes up to the news that one of the girls—beautiful, green-eyed Anna Ballard—has disappeared. A year later, Anna is still missing. Ella is wracked with guilt over what she failed to do, and she’s not the only one who can’t forget. Someone is sending her threatening letters—letters that make her fear for her life.", "I Am Watching You", 17.95m, "What would it take to make you intervene?" },
                    { 8, 3, "https://images-na.ssl-images-amazon.com/images/I/71LzPTNae8L.jpg", "https://images-na.ssl-images-amazon.com/images/I/71LzPTNae8L.jpg", true, true, "Kathi Spiars can't believe she's found such a good man to marry as Stephen Marcum. Twelve years later, she starts to suspect that he isn't who he says he is. As she digs into his past, she doesn't realize that learning the truth will lead to a lifetime of fear and hiding. (with Andrew Bourelle)", "Till Murder Do Us Part", 12.95m, "From the world's #1 bestselling author comes a collection of Discovery ID true crime stories where the bonds of matrimony and love can tear you brutally apart." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Genres_GenreId1",
                table: "Genres",
                column: "GenreId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
