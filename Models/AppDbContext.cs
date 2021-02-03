using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NetStore.Models
{
    public class AppDbContext: IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed genres
            modelBuilder.Entity<Genre>().HasData(new Genre { GenreId = 1, GenreName = "Fantasy" });
            modelBuilder.Entity<Genre>().HasData(new Genre { GenreId = 2, GenreName = "Science Fiction" });
            modelBuilder.Entity<Genre>().HasData(new Genre { GenreId = 3, GenreName = "Crime" });

            //seed Books

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 1,
                Name = "Harry Potter and the Goblet of Fire",
                Price = 12.95D,
                ShortDescription = "The paperback edition of the legendary, record-breaking, best-selling fourth Harry Potter novel.",
                LongDescription =
                    "Harry Potter is midway through his training as a wizard and his coming of age. Harry wants to get away from the pernicious Dursleys and go to the International Quidditch Cup. He wants to find out about the mysterious event that's supposed to take place at Hogwarts this year, an event involving two other rival schools of magic, and a competition that hasn't happened for a hundred years. He wants to be a normal, fourteen-year-old wizard. But unfortunately for Harry Potter, he's not normal - even by wizarding standards. And in his case, different can be deadl",
                GenreId = 1,
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/71ykU-RQ0nL._AC_SL1000_.jpg",
                InStock = true,
                IsBookOfTheWeek = true,
                ImageThumbnailUrl = "https://images-na.ssl-images-amazon.com/images/I/71ykU-RQ0nL._AC_SL1000_.jpg"
               
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 2,
                Name = "The Fellowship of the Ring: Being the First Part of The Lord of the Rings (1)",
                Price = 18.95D,
                ShortDescription = "The first volume in J.R.R. Tolkien's epic adventure THE LORD OF THE RINGS One Ring to rule them all, One Ring to find them, One Ring to bring them all and in the darkness bind them.",
                LongDescription =
                    "In ancient times the Rings of Power were crafted by the Elven-smiths, and Sauron, the Dark Lord, forged the One Ring, filling it with his own power so that he could rule all others. But the One Ring was taken from him, and though he sought it throughout Middle-earth, it remained lost to him. After many ages it fell into the hands of Bilbo Baggins, as told in The Hobbit. In a sleepy village in the Shire, young Frodo Baggins finds himself faced with an immense task, as his elderly cousin Bilbo entrusts the Ring to his care. Frodo must leave his home and make a perilous journey across Middle-earth to the Cracks of Doom, there to destroy the Ring and foil the Dark Lord in his evil purpose.",
                GenreId = 1,
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51tW-UJVfHL._SX321_BO1,204,203,200_.jpg",
                InStock = true,
                IsBookOfTheWeek = true,
                ImageThumbnailUrl =
                    "https://images-na.ssl-images-amazon.com/images/I/51tW-UJVfHL._SX321_BO1,204,203,200_.jpg"
                
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 3,
                Name = "To Sleep in a Sea of Stars",
                Price = 18.95D,
                ShortDescription = "To Sleep in a Sea of Stars is a brand new epic novel from #1 New York Times bestselling author of Eragon, Christopher Paolini.",
                LongDescription =
                    "During a routine survey mission on an uncolonized planet, Kira finds an alien relic. At first she's delighted, but elation turns to terror when the ancient dust around her begins to move. As war erupts among the stars, Kira is launched into a galaxy - spanning odyssey of discovery and transformation.First contact isn't at all what she imagined, and events push her to the very limits of what it means to be human. While Kira faces her own horrors, Earth and its colonies stand upon the brink of annihilation. Now, Kira might be humanity's greatest and final hope . . .",
                GenreId = 2,
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/91oK-po6+GL.jpg",
                InStock = true,
                IsBookOfTheWeek = false,
                ImageThumbnailUrl = "https://images-na.ssl-images-amazon.com/images/I/91oK-po6+GL.jpg"
                
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 4,
                Name = "Children of Time",
                Price = 15.95D,
                ShortDescription = "Adrian Tchaikovksy's award-winning novel Children of Time, is the epic story of humanity's battle for survival on a terraformed planet.",
                LongDescription =
                    "The last remnants of the human race left a dying Earth, desperate to find a new home among the stars. Following in the footsteps of their ancestors, they discover the greatest treasure of the past age -- a world terraformed and prepared for human life. But all is not right in this new Eden. In the long years since the planet was abandoned, the work of its architects has borne disastrous fruit. The planet is not waiting for them, pristine and unoccupied. New masters have turned it from a refuge into mankind's worst nightmare.",
                GenreId = 2,
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51glJgVC1IL.jpg",
                InStock = true,
                IsBookOfTheWeek = false,
                ImageThumbnailUrl = "https://images-na.ssl-images-amazon.com/images/I/51glJgVC1IL.jpg"

            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 5,
                Name = "False Assurances: Ben Porter Series - Book One",
                Price = 13.95D,
                ShortDescription = "A thoroughly riveting two-novel debut introducing a compelling new hero",
                LongDescription =
                    "On the morning of July 12, 2017, the FBI Boston field office receives what appears to be a hoax call: a man rescued from the waters off Massachusetts has claimed that his sailboat was hijacked and used to smuggle weapons and terrorists into the United States. With local agents tasked to prepare for an evening Presidential visit to downtown Boston, and with procedures requiring a response to any threat, no matter how unreliable it may seem, FBI administrative staffer Ben Porter is dispatched to investigate the call. Can Ben, untrained in field work and relying only on his wits and intuition, uncover the deadly plot … in time to stop it?",
                GenreId = 3,
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/71QB5OnbfML.jpg",
                InStock = true,
                IsBookOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://images-na.ssl-images-amazon.com/images/I/71QB5OnbfML.jpg"
              
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 6,
                Name = "I Am Watching You",
                Price = 17.95D,
                ShortDescription = "What would it take to make you intervene?",
                LongDescription =
                    "When Ella Longfield overhears two attractive young men flirting with teenage girls on a train, she thinks nothing of it—until she realises they are fresh out of prison and her maternal instinct is put on high alert. But just as she’s decided to call for help, something stops her. The next day, she wakes up to the news that one of the girls—beautiful, green-eyed Anna Ballard—has disappeared. A year later, Anna is still missing. Ella is wracked with guilt over what she failed to do, and she’s not the only one who can’t forget. Someone is sending her threatening letters—letters that make her fear for her life.",
                GenreId = 3,
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/618r1qu-s1L.jpg",
                InStock = true,
                IsBookOfTheWeek = false,
                ImageThumbnailUrl = "https://images-na.ssl-images-amazon.com/images/I/618r1qu-s1L.jpg"
                
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 7,
                Name = "The Lion, the Witch and the Wardrobe (The Chronicles of Narnia)",
                Price = 15.95D,
                ShortDescription = "A beautiful paperback edition of The Lion, the Witch and the Wardrobe, book two in the classic fantasy series The Chronicles of Narnia",
                LongDescription =
                    "Four adventurous siblings—Peter, Susan, Edmund, and Lucy Pevensie—step through a wardrobe door and into the land of Narnia, a land frozen in eternal winter and enslaved by the power of the White Witch. But when almost all hope is lost, the return of the Great Lion, Aslan, signals a great change . . . and a great sacrifice. Open the door and enter a new world! The Lion, the Witch and the Wardrobe is the second book in C.S.Lewis's classic fantasy series, which has been captivating readers of all ages with a magical land and unforgettable characters for over sixty years",
                GenreId = 1,
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51erHMLhIzL.jpg",
                InStock = false,
                IsBookOfTheWeek = false,
                ImageThumbnailUrl = "https://images-na.ssl-images-amazon.com/images/I/51erHMLhIzL.jpg"
                
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 8,
                Name = "Till Murder Do Us Part",
                Price = 12.95D,
                ShortDescription = "From the world's #1 bestselling author comes a collection of Discovery ID true crime stories where the bonds of matrimony and love can tear you brutally apart.",
                LongDescription =
                    "Kathi Spiars can't believe she's found such a good man to marry as Stephen Marcum. Twelve years later, she starts to suspect that he isn't who he says he is. As she digs into his past, she doesn't realize that learning the truth will lead to a lifetime of fear and hiding. (with Andrew Bourelle)",
                GenreId = 3,
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/71LzPTNae8L.jpg",
                InStock = true,
                IsBookOfTheWeek = true,
                ImageThumbnailUrl = "https://images-na.ssl-images-amazon.com/images/I/71LzPTNae8L.jpg"
                
            });


            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 9,
                Name = "Thinblade (Sovereign of the Seven Isles Book 1)",
                Price = 15.95D,
                ShortDescription = "The air stilled. The room fell silent. A shockwave passed through them. Everyone froze, faces white with fear. The ancient evil had awakened…",
                LongDescription =
                    "When Alexander loses his brother to an assassin’s arrow, he learns that his family protects an ancient secret and reluctantly finds himself at the center of a war that was supposed to have ended long ago. Pursued by dark minions of an ancient enemy, Alexander flees to the mountain city of Glen Morillian where he discovers that he is the heir to the throne of Ruatha,  one of the Seven Isles.",
                GenreId = 1,
                ImageUrl = "https://m.media-amazon.com/images/I/51nf5h+qfNL._SY346_.jpg",
                InStock = true,
                IsBookOfTheWeek = true,
                ImageThumbnailUrl = "https://m.media-amazon.com/images/I/51nf5h+qfNL._SY346_.jpg"
                
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 10,
                Name = "The Lightning Thief (Percy Jackson and the Olympians, Book 1)",
                Price = 15.95D,
                ShortDescription = "Percy Jackson is about to be kicked out of boarding school...again. And that's the least of his troubles.",
                LongDescription =
                    "Percy Jackson is a good kid, but he can't seem to focus on his schoolwork or control his temper. And lately, being away at boarding school is only getting worse-Percy could have sworn his pre-algebra teacher turned into a monster and tried to kill him.",
                GenreId = 1,
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/91RQ5d-eIqL.jpg",
                InStock = true,
                IsBookOfTheWeek = false,
                ImageThumbnailUrl = "https://images-na.ssl-images-amazon.com/images/I/91RQ5d-eIqL.jpg"
                
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 11,
                Name = "Prelude to Extinction", 
                Price = 18.95D,
                ShortDescription = "Earth’s first interstellar mission … An alien colony in ruins … Their fight for survival has only just begun.",
                LongDescription =
                    "When Jack Harrison climbed down the short ladder from the airlock and stepped onto the debris covered soil, the ground crackled with the sound of dried leaves and twigs. Warm sunlight shined through his helmet, making him almost forget the decade he just spent captaining Earth’s first ship to another star system. The serene tropical surroundings, though, stood in stark contrast to the long abandoned structures that lay nearby.",
                GenreId = 2,
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/41iyBtDoRUL.jpg",
                InStock = false,
                IsBookOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://images-na.ssl-images-amazon.com/images/I/41iyBtDoRUL.jpg"
               
            });
        }
    }
}
