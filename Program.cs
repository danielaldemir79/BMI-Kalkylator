namespace BMI_Kalkylator
{
    internal class Program
    {
        static void Main(string[] args)
        {

       
        
        
        
        
        
        
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
