namespace MW.DAL.Migrations
{
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MW.DAL.MwDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MW.DAL.MwDbContext context)
        {
            UserRole role1 = new UserRole { RoleName = "Admin" };

            UserRole role2 = new UserRole { RoleName = "Standard" };

            UserRole role3 = new UserRole { RoleName = "Restricted" };

            context.UserRoles.Add(role1);
            context.UserRoles.Add(role2);
            context.UserRoles.Add(role3);

            context.SaveChanges();



            User adminUser = new User()
            {
                BirthDate = new DateTime(1990, 8, 10),
                EMail = "newton@mw.com",
                Name = "Isaac",
                Surname = "Newton",
                Role=role1
                
            };


            adminUser.Passwords.Add(new Password()
            {
                PasswordText = "gravity"
            });

            context.Users.Add(adminUser);

            context.SaveChanges();

            User standardUser = new User()
            {
                BirthDate = new DateTime(1992, 4, 20),
                EMail = "albert@mw.com",
                Name = "Albert",
                Surname = "Einstein",
                Role = role2,   

            };


            standardUser.Passwords.Add(new Password()
            {
                PasswordText = "relativity"
            });

            context.Users.Add(standardUser);

            context.SaveChanges();

            User user1 = new User()
            {
                BirthDate = new DateTime(1993, 6, 15),
                EMail = "marie@mw.com",
                Name = "Marie",
                Surname = "Curie",
                Role = role3,
                IsActive = false
                
            };

            user1.Passwords.Add(new Password()
            {
                PasswordText = "nobel"
            });

            context.Users.Add(user1);

            context.SaveChanges();

            IList<Word> words = new List<Word>();

            words.Add(new Word() { EnglishText="relativity", TurkishText="görelilik" });
            words.Add(new Word() { EnglishText = "acceleration", TurkishText = "ivme" });
            words.Add(new Word() { EnglishText = "velocity", TurkishText = "hýz" });
            words.Add(new Word() { EnglishText = "gravity", TurkishText = "yerçekimi" });
            words.Add(new Word() { EnglishText = "prize", TurkishText = "ödül" });
            words.Add(new Word() { EnglishText = "car", TurkishText = "araba" });
            words.Add(new Word() { EnglishText = "house", TurkishText = "ev" });
            words.Add(new Word() { EnglishText = "horse", TurkishText = "at" });
            words.Add(new Word() { EnglishText = "pencil", TurkishText = "kalem" });
            words.Add(new Word() { EnglishText = "mother", TurkishText = "anne" });
            words.Add(new Word() { EnglishText = "father", TurkishText = "baba" });
            words.Add(new Word() { EnglishText = "cloud", TurkishText = "bulut" });
            words.Add(new Word() { EnglishText = "rainy", TurkishText = "yaðmurlu" });
            words.Add(new Word() { EnglishText = "sun", TurkishText = "güneþ" });
            words.Add(new Word() { EnglishText = "world", TurkishText = "dünya" });


            context.Words.AddRange(words);

            context.SaveChanges();


        }
    }
}
