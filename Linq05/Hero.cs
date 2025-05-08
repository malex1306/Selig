using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq05 {
public class Hero {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? HeroName { get; set; }
        public string? Gang { get; set; }

        public DateTime DateOfBirth;
        public int Age {
            get {
                if (DateOfBirth >= DateTime.Now) {
                    return 0;
                }
                int age = DateTime.Today.Year - DateOfBirth.Year;
                if (DateOfBirth.AddYears(age) > DateTime.Today) {
                    age--;
                }
                return age;
            }
        }
        public override string ToString() {
            return $"{HeroName}, {Gang} ({FirstName} {LastName}, {DateOfBirth.ToShortDateString()}|{Age})";
        }

        public static List<Hero> GetHeroes() {
            return new List<Hero>() {
                new Hero() { HeroName = "Batman", FirstName = "Bruce", LastName = "Wayne", Gang = "Justice League", DateOfBirth = new DateTime(1980, 1, 1) },
                new Hero() { HeroName = "Superman", FirstName = "Clark", LastName = "Kent", Gang = "Justice League", DateOfBirth = new DateTime(1981, 2, 2) },
                new Hero() { HeroName = "Hulk", FirstName = "Bruce", LastName = "Banner", Gang = "Avengers", DateOfBirth = new DateTime(1982, 3, 3) },
                new Hero() { HeroName = "Iron Man", FirstName = "Tony", LastName = "Stark", Gang = "Avengers", DateOfBirth = new DateTime(1983, 4, 4) },
                new Hero() { HeroName = "Black Widow", FirstName = "Natasha", LastName = "Romanoff", Gang = "Avengers", DateOfBirth = new DateTime(1984, 5, 5) },
                new Hero() { HeroName = "Captain Marvel", FirstName = "Carol", LastName = "Danvers", Gang = "Avengers", DateOfBirth = new DateTime(1985, 6, 6) },
                new Hero() { HeroName = "Wonder Woman", FirstName = "Diana", LastName = "Prince", Gang = "Justice League", DateOfBirth = new DateTime(1986, 7, 7) },
                new Hero() { HeroName = "Captain America", FirstName = "Steve", LastName = "Rogers", Gang = "Avengers", DateOfBirth = new DateTime(1987, 8, 8) },
                new Hero() { HeroName = "Wolverine", FirstName = "James", LastName = "Howlett", Gang = "X-Men", DateOfBirth = new DateTime(1988, 9, 9) },
                new Hero() { HeroName = "Magneto", FirstName = "Max", LastName = "Eisenhardt", Gang = "X-Men", DateOfBirth = new DateTime(1989, 10, 10) }
            };
        }
    }
}