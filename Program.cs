namespace BMI_Kalkylator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int val = 0;

            while (val != 3)
            {
                VisaMeny();
                val = GetInt();

                if (val == 3)
                {
                    return;
                }
                else if (val != 1 && val != 2)
                {
                    Console.WriteLine("Du har angett felaktigt värde. Programmet avslutas.");
                    return;
                }

                switch (val)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Du har valt metriska enheter.");
                        Console.WriteLine();

                        Console.WriteLine("Hur lång är du? Svara i cm");
                        double heightMeter = GetDouble() / 100;

                        Console.WriteLine("Hur mycket väger du? Svara i kg");
                        double weightKg = GetDouble();

                        double bmiMetric = CalculateBMI(weightKg, heightMeter);
                        Console.WriteLine();
                        Console.WriteLine($"Ditt BMI (metriska enheter) är: {Math.Round(bmiMetric, 2)}");
                        break;

                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Du har valt imperiska enheter.");
                        Console.WriteLine();
                        
                        Console.WriteLine("Hur lång är du? Svara i inches");
                        double heightInches = GetDouble();
                        
                        Console.WriteLine("Hur mycket väger du? Svara i pounds");
                        double weightPounds = GetDouble();

                        double bmiImperial = CalculateBMI(weightPounds, heightInches, "imperial");
                        Console.WriteLine();
                        Console.WriteLine($"Ditt BMI (imperiska) är: {Math.Round(bmiImperial, 2)}");
                        break;
                        
                    default:
                        Console.WriteLine("Du har angett felaktigt värde. Programmet avslutas.");
                        break;
                }
                Console.WriteLine();

            }


           



        }

        
        static void VisaMeny()
        {
            Console.WriteLine("Välj enhetssystem:");
            Console.WriteLine("1. Metriska enheter (kg, m)");
            Console.WriteLine("2. Imperiska enheter (pounds, inches)");
            Console.WriteLine("3. Avsluta");
        }
        
        static double CalculateBMI(double weight, double height, string unit = "metric")
        {
            if (unit == "metric")
            {
                return weight / (height * height);
            }
            else if (unit == "imperial")
            {
                return 703 * (weight / (height * height));
            }
            else
            {
                Console.WriteLine("Okänd enhet, returnerar 0");
                return 0;
            }
        }

        static int GetInt()
        {
            int helTal;

            while (int.TryParse(Console.ReadLine(), out helTal) == false)
            {
                Console.WriteLine("Du har angett felaktigt värde. Försök igen.");
            }

            return helTal;

        }
        static double GetDouble()
        {
            double decimalTal;

            while (double.TryParse(Console.ReadLine(), out decimalTal) == false)
            {
                Console.WriteLine("Du har angett felaktigt värde. Försök igen.");
            }

            return decimalTal;

        }
    }
}
