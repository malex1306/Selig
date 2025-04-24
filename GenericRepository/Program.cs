using System;
using System.Numerics;

namespace GenericRepository;

class Program
{
    static void Main(string[] args)
    {
        InMemoryRepository<User> repo = new InMemoryRepository<User>();
        BigInteger max = BigInteger.Pow(2, 128); 
        int count = 0;

        try
        {
            for (BigInteger i = 0; i < max; i++)
            {
                User person = new User(){Name = "John" + i};
                repo.Add(person);
                count++;

                if (count % 100_000 == 0)
                {
                    Console.WriteLine($"Erstellt: {count}");
                }
            }
        }
        catch (OutOfMemoryException)
        {
            Console.WriteLine("Out of memory!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Anderer Fehler: {ex.Message}");
        }
        finally
        {
            Console.WriteLine($"Insgesamt erfolgreich erstellt: {count} Personen.");
        }
    }
}