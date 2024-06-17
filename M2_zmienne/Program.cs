namespace M2_zmienne;

class Program
{
    static void Main(string[] args)
    {
        // do kazdego zadania powinno sie dodac parsowanie czy dane od uzytkownika spelniaja wymagania
        // dla przykladu dodano parsowanie w pierwszych cwiczeniach
        
        
    
    /// zad 1
        Console.WriteLine("Sprawdzenie rownosci dwoch liczb");
        Console.WriteLine("Podaj pierwsza liczbe: ");
        string a = Console.ReadLine();
        Console.WriteLine("Podaj druga liczbe: ");
        string b = Console.ReadLine();

        bool isNumber1 = Int32.TryParse(a, out int number1);
        bool isNumber2 = Int32.TryParse(b, out int number2);

        if (isNumber1 && isNumber2)
        {
            if (number1 == number2)
            {
                Console.WriteLine("Podane liczby sa rowne!");
            }
            else
            {
                Console.WriteLine("Liczby nie sa rowne!");
            }
        }
        else
        {
            Console.WriteLine("Podano niepoprawne dane!");
        }
        
        // zad 2
        Console.WriteLine("Sprawdzenie parzystosci liczby");
        Console.WriteLine("Podaj liczbe calkowita do sprawdzenia: ");
        string even = Console.ReadLine();
        bool isNumber = Int32.TryParse(even, out int n);

        if (isNumber1)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("Liczba jest parzysta");
            }
            else
            {
                Console.WriteLine("Liczba jest nieprarzysta");
            }
        }
        else
        {
            Console.WriteLine("Podano niepoprawne dane!");
        }
        
        //zad 3
        Console.WriteLine("Sprawdzenie czy liczba jest dodatnia");
        Console.WriteLine("Podaj liczbe calkowita do sprawdzenia: ");
        string positive = Console.ReadLine();
        int positiveNumber = Int32.Parse(positive);
        
        if (positiveNumber > 0)
        {
            Console.WriteLine("Liczba jest dodatnia"); 
        }
        else if (positiveNumber == 0)
        {
            Console.WriteLine("Liczba jest zerem");
        }
        else
        {
            Console.WriteLine("Liczba jest ujemna");
        }
        
        //zad 4
        Console.WriteLine("Sprawdzenie czy podany rok jest przystepny");
        Console.WriteLine("Podaj rok do sprawdzenia: ");
        string year = Console.ReadLine();
        int isLeapYear = Int32.Parse(year);
        
        if (isLeapYear % 400 == 0)
        {
            Console.WriteLine("Rok jest przystepny"); 
        }
        else if (isLeapYear % 4 == 0 && isLeapYear % 100 != 0)
        {
           Console.WriteLine("Rok jest przystepny");
        }
        else
        {
            Console.WriteLine("Rok nie jest przystepny");
        }
        
        //zad 5
        Console.WriteLine("Sprawdzenie czy mozesz zostac poslem, senatorem lub prezydentem");
        Console.WriteLine("Podaj swoj wiek: ");
        string age = Console.ReadLine();
        int  userAge = Int32.Parse(age);
        int agePosel = 21;
        int ageSenator = 30;
        int agePrezydent = 35;


        if (userAge >= agePosel)
        {
            Console.WriteLine("Mozesz zostac poslem.");
        }
        else
        {
            Console.WriteLine("Jestes za mlody na posla");
        }

        if (userAge >= ageSenator)
        {
            Console.WriteLine("Mozesz zostac senatorem.");
        }
        else
        {
            Console.WriteLine("Jestes za mlody na senatora");
        }

        if (userAge >= agePrezydent)
        {
            Console.WriteLine("Mozesz zostac prezydentem.");
        }
        else
        {
            Console.WriteLine("Jestes za mlody na prezydenta");
        }

    }
}