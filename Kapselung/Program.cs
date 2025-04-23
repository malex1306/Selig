namespace Kapselung;

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.SetFirstname("Marcel");
        p1.SetLastname("Alexandre");

        Console.WriteLine("Vorname: " + p1.GetFirstname());
        Console.WriteLine("Nachname: " + p1.GetLastname());
        Console.WriteLine("Vollständiger Name: " + p1.Fullname);
    }

    public class Person
    {
        // private Felder (Kapselung)
        private string? Firstname;
        private string? Lastname;

        // Property für Fullname (nur lesbar)
        public string? Fullname
        {
            get { return Firstname + " " + Lastname; }
        }

        // Getter & Setter für Firstname
        public string? GetFirstname()
        {
            return Firstname;
        }

        public void SetFirstname(string? firstname)
        {
            Firstname = firstname;
        }

        // Getter & Setter für Lastname
        public string? GetLastname()
        {
            return Lastname;
        }

        public void SetLastname(string? lastname)
        {
            Lastname = lastname;
        }
    }
}