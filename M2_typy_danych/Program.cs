namespace SzkolaDotneta;

class Program
{
    static void Main(string[] args)
    {
        // zad 1
        string imie = "Bartosz";
        string nazwisko = "Lemiech";
        int wiek = 30;
        char plec = 'm';
        string PESEL = "90010133333";
        string ID = "123456789";

        // zad 2
        char a = 'a';
        char b = 'b';
        char c = 'c';
        Console.WriteLine($"{a}{b}{c}");
        Console.WriteLine($"{c}{b}{a}");

        //zad 3
        double Przekatna(double a, double b)
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }

        Console.WriteLine("Podaj dlugosc prostokata: ");
        double bokA = Double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj szerokosc prostokata: ");
        double bokB = Double.Parse(Console.ReadLine());

        double diagonal = Przekatna(bokA, bokB);
        Console.WriteLine($"Przekatna to: {diagonal}");

        //zad 4
        int v1;
        string v2;
        double v3;

        v1 = 10;
        v2 = "Szkoła Dotneta";
        v3 = 12.5;
        
        // zad 5
        Console.WriteLine("Podaj imie: ");
        string firstName = Console.ReadLine();
        
        Console.WriteLine("Podaj naziwsko: ");
        string lastName = Console.ReadLine();
        
        Console.WriteLine("Podaj numer telefonu: ");
        string phoneNumber = Console.ReadLine();
        Int32.Parse(phoneNumber);
        
        Console.WriteLine("Podaj adres mail: ");
        string mail = Console.ReadLine();

        Console.WriteLine("Podaj wzrost w cm: ");
        string height = Console.ReadLine();
        Int32.Parse(height);
        
        Console.WriteLine("Podaj dokladna wage w kg: ");
        string weight = Console.ReadLine();
        Double.Parse(weight);
        
        Console.WriteLine($"Nazywasz sie: {firstName} {lastName}");
        Console.WriteLine($"Twoje waga: {weight} kg, wzrost: {height} cm");
        Console.WriteLine($"Adres mail: {mail}, numer telefonu: {phoneNumber}");
    }
}