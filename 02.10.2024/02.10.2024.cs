using System;
public class program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("zadanie 1");


        Console.WriteLine("Podaj liczbe x!");
        int x =
            Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj liczbe y!");
        int y =
            Convert.ToInt32(Console.ReadLine());
        if (x > 0 && y > 0)
        {
            Console.WriteLine("Jest to cwiartka 1");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Jest to cwiartka 2");
                }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Jest to cwiartka 3");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Jest to cwiartka 4");
        }
        else if (x == 0 && y == 0)
        {
            Console.WriteLine("nie ma ");
        }


        Console.WriteLine("zadanie 2");
        Console.WriteLine("Podaj pierwszy bok");
        int a =
            Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj drugi bok");
        int b =
            Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj podstawe");
        int c =
            Convert.ToInt32(Console.ReadLine());
        if ( a + b > c && a + c > b && b + c > a)
        {
            Console.WriteLine("Pole to ");
            Console.WriteLine(0.25 * (Math.Sqrt(4 * a * a * b * b - (a * a + b * b - c * c)* (a * a + b * b - c * c))));
        }
        else if (a + b < c)
        { 
            Console.WriteLine("nie ma takiego trojkota");
        }
        Console.WriteLine("Obwod to ");
        Console.WriteLine(a + b + c);


        Console.WriteLine("zadanie 4");
        Console.WriteLine("Podaj liczbe pierwsza!");
        int t =
            Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj liczbe druga!");
        int r =
            Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("wybierz operacje");
        Console.WriteLine("1-dodawanie");
        Console.WriteLine("2-odejmowanie");
        Console.WriteLine("3-mnozenie");
        Console.WriteLine("4-dzielenie");
        int o =
            Convert.ToInt32(Console.ReadLine());

        if (o == 1)
        {
            Console.WriteLine(t + r);
        }
        else if (o == 2)
        {
            Console.WriteLine(t - r);
        }
        else if (o == 3)
        {
            Console.WriteLine(t * r);
        }
        else if (o == 4)
        {
            Console.WriteLine(t / r);
        }
        else
        {
            Console.WriteLine("twoja liczba nie jest w zakresie ");
        }


        Console.WriteLine("Podaj liczbe pierwsza!");
        int u =
            Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj liczbe druga!");
        int i =
            Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("wybierz operacje");
        Console.WriteLine("1-dodawanie");
        Console.WriteLine("2-odejmowanie");
        Console.WriteLine("3-mnozenie");
        Console.WriteLine("4-dzielenie");
        int z =
            Convert.ToInt32(Console.ReadLine());
          switch(z)
        {
            case 1:
                Console.WriteLine(u + i);
                break;
            case 2:
                Console.WriteLine(u - i);
                break;
            case 3:
                Console.WriteLine(u * i);
                break;
            case 4:
                Console.WriteLine(u / i);
                break;
        }

    }
}


