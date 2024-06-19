
using System.Diagnostics;

namespace M2_zmienne;

class Program
{
    static void Main(string[] args)
    {
        // do kazdego zadania powinno sie dodac parsowanie czy dane od uzytkownika spelniaja wymagania
        // dla przykladu dodano parsowanie w pierwszych cwiczeniach



       //zad 1
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
        int positiveNumber = Int32.Parse(Console.ReadLine());

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
        int isLeapYear = Int32.Parse(Console.ReadLine());

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
        int  userAge = Int32.Parse(Console.ReadLine());
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

        //zad 6
        Console.WriteLine("Sprawdzenie kategorii twojego wzrostu!");
        Console.WriteLine("Podaj swoj wzrost: ");
        int heightNumber = Int32.Parse(Console.ReadLine());

        if (heightNumber <= 120)
        {
            Console.WriteLine("Jestes HOBBITEM!");
        }
        else if (heightNumber > 120 && heightNumber <= 150)
        {
            Console.WriteLine("Jestes KRASNOLUDEM!");
        }
        else if (heightNumber > 150 && heightNumber <= 190)
        {
            Console.WriteLine("Jestes CZLOWIEKIEM!");
        }
        else
        {
            Console.WriteLine("Jestes ELFEM!");
        }

        // zad 7
        Console.WriteLine("Sprawdzenie ktora liczba jest najwieksza");
        Console.WriteLine("Podaj 3 liczby calkowite");
        Console.WriteLine("Pierwsza liczba: ");
        int n1Max = int.Parse(Console.ReadLine());
        Console.WriteLine("Druga liczba: ");
        int n2Max = int.Parse(Console.ReadLine());
        Console.WriteLine("Trzecia liczba: ");
        int n3Max = int.Parse(Console.ReadLine());
        int max = n1Max;

        if (n2Max > n1Max || n3Max > n1Max)
        {
            max = n2Max;
            if (n3Max > n2Max)
            {
                max = n3Max;
                Console.WriteLine($"Najwieksza liczba to {n3Max}");
            }
            else
            {
                Console.WriteLine($"Najwieksza liczba to {n2Max}");
            }
        }
        else
        {
            Console.WriteLine($"Najwieksza liczba to {n1Max}");
        }
        
        // zad 8
        Console.WriteLine("Sprawdzenie wynikow kandydata na studia");
        Console.WriteLine("Podaj wynik z matematyki: ");
        int matScore = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Podaj wynik z fizyki: ");
        int fizScore = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Podaj wynik z chemii: ");
        int chemScore = Int32.Parse(Console.ReadLine());
        
        if ((matScore > 70 && fizScore > 55 && chemScore > 45)
            ||
            (matScore + fizScore > 150 || matScore + chemScore > 150))
        {
            Console.WriteLine("Kandydat dopuszczony do rekrutacji");
        }
        else
        {
            Console.WriteLine("Kandydatura odrzucona");
        }
        
        //zad 9
        Console.WriteLine("Sprawdzenie podanej temperatury wedlug kryteriow");
        Console.WriteLine("Podaj temperature: ");
        int tempNumber = Int32.Parse(Console.ReadLine());

        if (tempNumber < 0)
        {
            Console.WriteLine("Cholernie pizdzi!");
        }
        else if (tempNumber >= 0 && tempNumber < 10)
        {
            Console.WriteLine("Zimno!");
        }
        else if (tempNumber >= 10 && tempNumber < 20)
        {
            Console.WriteLine("Chlodno!");
        }
        else if (tempNumber >= 20 && tempNumber < 30)
        {
            Console.WriteLine("W sam raz!");
        }
        else if (tempNumber >= 30 && tempNumber < 40)
        {
            Console.WriteLine("Zaczyna byc slabo bo goraco");
        }
        else if (tempNumber >= 40)
        {
            Console.WriteLine("A wez wyprowadzam sie na Alaske!");
        }
        
        //zad 10
        Console.WriteLine("Sprawdzenie mozliwosci stworzenia trojkata");
        Console.WriteLine("Podaj 3 wartosci dlugosci bokow");
        int bokA = Int32.Parse(Console.ReadLine());
        int bokB = Int32.Parse(Console.ReadLine());
        int bokC = Int32.Parse(Console.ReadLine());

        if ((bokA + bokB > bokC) && (bokA + bokC > bokB) && (bokB + bokC > bokA))
        {
            Console.WriteLine("Mozna zbudowac trojkat");
        }
        else
        {
            Console.WriteLine("Nie mozna zbudowac trojkata");
        }
        
        //zad 11
        Console.WriteLine("Ocena ucznia wedlug skali");
        Console.WriteLine("Wprowadz ocene 1-6: ");
        string ocena = Console.ReadLine();
        
        switch (ocena)
        {
            case "1":
                Console.WriteLine("Niedostateczny");
                break;
            case "2":
                Console.WriteLine("Dopuszczajacy");
                break;
            case "3":
                Console.WriteLine("Dostateczny");
                break;
            case "4":
                Console.WriteLine("Dobry");
                break;
            case "5":
                Console.WriteLine("Bardzo dobry");
                break;
            case "6":
                Console.WriteLine("Celujacy");
                break;
            default:
                Console.WriteLine("Cos poszlo nie tak..");
                break;
        }
        
        //zad 12
        Console.WriteLine("Dni tygodnia wedlug klucza");
        Console.WriteLine("Wprowadz dzien tygodnia 1-7: ");
        string dzien = Console.ReadLine();
        
        switch (dzien)
        {
            case "1":
                Console.WriteLine("Poniedzialek");
                break;
            case "2":
                Console.WriteLine("Wtorek");
                break;
            case "3":
                Console.WriteLine("Sroda");
                break;
            case "4":
                Console.WriteLine("Czwartek");
                break;
            case "5":
                Console.WriteLine("Piatek");
                break;
            case "6":
                Console.WriteLine("Sobota");
                break;
            case "7":
                Console.WriteLine("Niedziela");
                break;
            default:
                Console.WriteLine("Cos poszlo nie tak..");
                break;
        }
        
        //zad 13
        Console.WriteLine("Prosty kalkulator");
        Console.WriteLine("Wprowadz pierwsza liczbe: ");
        double num1 = Double.Parse(Console.ReadLine());
        Console.WriteLine("Wprowadz druga liczbe: ");
        double num2 = Double.Parse(Console.ReadLine());
        double wynik = 0;
        Console.WriteLine("Podaj numer operacji do wykonywania ");
        Console.WriteLine("1 - Dodawaniae \n2 - Odejmowanie \n3 - Mnozenie \n4 - Dzielenie");
        string wybor = Console.ReadLine();
        
        switch (wybor)
        {
            case "1":
                wynik = num1 + num2;
                Console.WriteLine($"{num1} + {num2} = {wynik}");
                break;
            case "2":
                wynik = num1 - num2;
                Console.WriteLine($"{num1} - {num2} = {wynik}");
                break;
            case "3":
                wynik = num1 * num2;
                Console.WriteLine($"{num1} * {num2} = {wynik}");
                break;
            case "4":
                if (num2 == 0)
                {
                    Console.WriteLine("Nie mozna dzielic przez 0!");
                    break;
                }
                else
                {
                    wynik = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {wynik}");
                    break; 
                }
        }

    }

}
