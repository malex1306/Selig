namespace GenericRepository {
    internal class Program {
        static void Main(string[] args) {
            var repo = new InMemoryRepository<User>();

            var user1 = new User() {
                Name = "Hans",
                DateOfBirth = new DateOnly(1980, 10, 11),
                Id = Guid.NewGuid()
            };
            
            var user2 = new User() {
                Name = "Gitte",
                DateOfBirth = new DateOnly(1980, 11, 10),
                Id = Guid.NewGuid()
            };
            
            var user3 = new User() {
                Name = "Hans",
                DateOfBirth = new DateOnly(1990, 11, 10),
                Id = Guid.NewGuid()
            };
           

            repo.Add(user1);
            repo.Add(user2);
            repo.Add(user3);
            repo.Print();
            
            var allHans = repo.Search(value => value.Name.Contains('3'));
            foreach (var user in allHans) {
                Console.WriteLine(user);
            }
        }
    }
}