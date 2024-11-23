namespace _01.GuineaPig
{
    class Program
    {
        static void Main(string[] args)

        {
            double foodInKG = double.Parse(Console.ReadLine()) * 1000;
            double hayInKG = double.Parse(Console.ReadLine()) * 1000;
            double coverInKG = double.Parse(Console.ReadLine()) * 1000;
            double petWeightInKG = double.Parse(Console.ReadLine()) * 1000;
            const int daysInMonth = 30;
            for (int days = 1; days <= daysInMonth; days++)
            {
                const double gramsOfFood = 300;
                foodInKG -= gramsOfFood;

                if (days % 2 == 0)
                {
                    hayInKG -= foodInKG - (foodInKG * 0.95);
                }
                if (days % 3 == 0)
                {
                    coverInKG -= petWeightInKG / 3;
                }
                if (foodInKG <= 0 ||
                    hayInKG <= 0 ||
                    coverInKG <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }

            }
            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodInKG / 1000:F2}, Hay: {hayInKG / 1000:F2}, Cover: {coverInKG / 1000:F2}.");
        }
    }
}





