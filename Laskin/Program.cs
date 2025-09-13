class Laskutoimitus
{
    public double Summa(double a, double b)
    {
        return a + b;
    }

    public double Erotus(double a, double b)
    {
        return a - b;
    }

    public double Jako(double a, double b)
    {
        return a / b;
    }

    public double Kerto(double a, double b)
    {
        return a * b;
    }
}

class Laskin
{
    static void Main(string[] args)
    {
        Laskutoimitus laskin = new Laskutoimitus();

        Console.WriteLine("Laskin");
        Console.WriteLine("--------------");

        Console.Write("Anna ensimmäinen luku: ");
        double luku1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Anna toinen luku: ");
        double luku2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Valitse laskutoimitus: +, -, /, *");
        string laskutoimitus = Console.ReadLine();

        double tulos = 0;

        switch (laskutoimitus)
        {
            case "+":
                tulos = laskin.Summa(luku1, luku2);
                break;
            case "-":
                tulos = laskin.Erotus(luku1, luku2);
                break;
            case "/":
                tulos = laskin.Jako(luku1, luku2);
                break;
            case "*":
                tulos = laskin.Kerto(luku1, luku2);
                break;
            default:
                Console.WriteLine("Virhe!");
                return;
        }

        Console.WriteLine($"Tulos: {luku1} {laskutoimitus} {luku2} = {tulos}");
    }
}