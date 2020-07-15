using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL.Entities
{
    public class BlogInitializer : DropCreateDatabaseAlways<PostContext>
    {
        protected override void Seed(PostContext context)
        {

            var user1 = new User { FirstName = "Stephen", LastName = "Strange", Birthday = new DateTime(1950, 7, 20), Email = "strange@gmail.com", Avatar = "~/assets/images/strange.png" };
            var user2 = new User { FirstName = "Tony", LastName = "Stark", Birthday = new DateTime(1950, 7, 20), Email = "stark@gmail.com", Avatar = "~/assets/images/tony.png" };
            var user3 = new User { FirstName = "Natasha", LastName = "Romanoff", Birthday = new DateTime(1950, 7, 20), Email = "nata@gmail.com", Avatar = "~/assets/images/nat.png" };
            var user4 = new User { FirstName = "Bruce", LastName = "Banner", Birthday = new DateTime(1950, 7, 20), Email = "bruce@gmail.com", Avatar = "~/assets/images/bruce.png" };
            var user5 = new User { FirstName = "Steven", LastName = "Rogers", Birthday = new DateTime(1950, 7, 20), Email = "steven@gmail.com", Avatar = "~/assets/images/steven.png" };
            var user6 = new User { FirstName = "Wanda", LastName = "Maximoff", Birthday = new DateTime(1950, 7, 20), Email = "wanda@gmail.com", Avatar = "~/assets/images/wanda.png" };
            var user7 = new User { FirstName = "Peter", LastName = "Parker", Birthday = new DateTime(1950, 7, 20), Email = "peter@gmail.com", Avatar = "~/assets/images/peter.png" };
            var user8 = new User { FirstName = "Stephen", LastName = "Strange", Birthday = new DateTime(1950, 7, 20), Email = "strange@gmail.com", Avatar = "~/assets/images/thor.png" };
            var user9 = new User { FirstName = "Peter", LastName = "Quill", Birthday = new DateTime(1950, 7, 20), Email = "quill@gmail.com", Avatar = "~/assets/images/thor.png" };

            context.Users.Add(user1);
            context.Users.Add(user2);
            context.Users.Add(user3);
            context.Users.Add(user4);
            context.Users.Add(user5);
            context.Users.Add(user6);
            context.Users.Add(user7);
            context.Users.Add(user8);
            context.Users.Add(user9);
            context.SaveChanges();

            var category1 = new Category { Name = "Action", Description = "Action films usually include high energy, big-budget physical stunts and chases, possibly with rescues, battles, fights, escapes, destructive crises", };
            var category2 = new Category { Name = "Adventure", Description = "Adventure films are usually exciting stories, with new experiences or exotic locales, very similar to or often paired with the action film genre. They can include traditional swashbucklers or pirate films, serialized films, and historical spectacles" };
            var category3 = new Category { Name = "Comedy", Description = "Comedies are light-hearted plots consistently and deliberately designed to amuse and provoke laughter (with one-liners, jokes, etc.) by exaggerating the situation, the language, action, relationships and characters." };
            var category4 = new Category { Name = "Horror", Description = "Horror films are designed to frighten and to invoke our hidden worst fears, often in a terrifying, shocking finale, while captivating and entertaining us at the same time in a cathartic experience." };
            var category5 = new Category { Name = "Sci-fi", Description = "Sci-fi films are often quasi-scientific, visionary and imaginative - complete with heroes, aliens, distant planets, impossible quests, improbable settings, fantastic places, great dark and shadowy villains, futuristic technology, unknown and unknowable forces, and extraordinary monsters" };
            var category6 = new Category { Name = "Drama", Description = "Dramas are serious, plot-driven presentations, portraying realistic characters, settings, life situations, and stories involving intense character development and interaction. Usually, they are not focused on special-effects, comedy, or action, Dramatic films are probably the largest film genre, with many subsets." };

            context.Categories.Add(category1);
            context.Categories.Add(category2);
            context.Categories.Add(category3);
            context.Categories.Add(category4);
            context.Categories.Add(category5);
            context.Categories.Add(category6);
            context.SaveChanges();


            var post1 = new Post
            {
                Title = "Fantastic Beasts 3: What We Know So Far",
                Body = "Warner Bros. finally issued an official release date in late April 2019: Fantastic Beasts 3 is currently scheduled to open November 12, 2021. Fantastic Beasts 3 was initially hoped expected to release on November 20, 2020, " +
                "then WB gave Dune that release date. Production on Fantastic Beasts 3 was initially delayed from starting to film this July, 2019, to starting instead in late fall 2019." +
                " Filming was delayed yet again to start in the spring of 2020 to match the new November 2021 release date.",
                Image = "~/assets/images/beasts.jpg",
                UserId = 1,
                CategoryId = 2
            };


            var post2 = new Post
            {
                Title = "Is Once Upon a Deadpool Better Than Deadpool 2?",
                Body = "This holiday season, Deadpool has his eye on getting on Santa's nice list with the PG-13 re-release of Deadpool 2, thoughtfully known as Once Upon a Deadpool. The limited holiday engagement features an involuntary," +
                " middle-aged Fred Savage back in an exact replica of his character's room in The Princess Bride as the Merc with a Mouth reads him the summer hit through filtered through the prison of childlike innocence.",
                Image = "~/assets/images/deadpool.jpg",
                UserId = 2,
                CategoryId = 1
            };


            var post3 = new Post
            {
                Title = "The Gentlemen Review: A Delightful Cacophony Of Humor And Violence",
                Body = "Once the film finds its groove, it doesn’t take long for Guy Ritchie’s charm to sink in, as The Gentlemen finds its rhythm and proceeds to conduct its own symphony of action, comedy, and choice swearing." +
                "Before he climbed into the cockpit of franchise starters like Sherlock Holmes and The Man From U.N.C.L.E., or even Disney’s live-action remake of Aladdin, director Guy Ritchie was known for a particular brand of film.",
                Image = "~/assets/images/gentlemens.jpg",
                UserId = 3,
                CategoryId = 3
            };

            var post4 = new Post
            {
                Title = "More Fat Thor In Thor Love And Thunder? Here's What Taika Waititi Says",
                Body = "One of the most surprising (and delightful) elements of Avengers: Endgame had to be Thor’s story arc, which transformed the God of Thunder from a strapping brute to an overweight shut-in. This iteration of the character," +
                " called “Fat Thor” or “Bro Thor” by fans, left a lasting impression. As a result, fans are hoping to see him once again in Thor’s next solo outing, Thor: Love and Thunder. But is writer-director Taika Waititi planning to include " +
                "the Odison’s rotund form?",
                Image = "~/assets/images/fatthor.jpg",
                UserId = 4,
                CategoryId = 1
            };


            var post5 = new Post
            {
                Title = "Wild John Wick Fan Theory Claims He’s In A Video Game… Or The Matrix?",
                Body = "When you think about everything Keanu Reeves’ John Wick has lived through in the span of the action franchise, it’s pretty inhuman right? Like how in the heck is that guy still kicking to show up for John Wick 4? It’s crazy. " +
                "Now, most of the time we likely chock it up to the fact that Wick's a movie character and that’s just what movie characters do. But one fan theorist believes the answer is this: John Wick lives in a video game... a little Matrix-y no?",
                Image = "~/assets/images/johnwick3.jpg",
                UserId = 5,
                CategoryId = 2
            };

            context.Posts.Add(post1);
            context.Posts.Add(post2);
            context.Posts.Add(post3);
            context.Posts.Add(post4);
            context.Posts.Add(post5);
            context.SaveChanges();


            Tag tag1 = new Tag { Name = "#guyritchie" };
            Tag tag2 = new Tag { Name = "#tarantino" };
            Tag tag3 = new Tag { Name = "#christophernolan" };

            context.Tags.Add(tag1);
            context.Tags.Add(tag2);
            context.Tags.Add(tag3);

            context.SaveChanges();

            base.Seed(context);

        }

    }
}
