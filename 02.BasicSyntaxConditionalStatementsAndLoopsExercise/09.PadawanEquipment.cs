double budget = double.Parse(Console.ReadLine());
int countOfStudents = int.Parse(Console.ReadLine());
double priceSabers = double.Parse(Console.ReadLine());
double priceRobes = double.Parse(Console.ReadLine());
double priceBelts = double.Parse(Console.ReadLine());
int freeBelts = 0;
for (int i = 1; i <= countOfStudents; i++)
{
	if (i % 6 == 0)
	{
		freeBelts++;
	}
}
double neededEquipment = priceSabers * (Math.Ceiling(countOfStudents * 1.1)) + priceRobes * (countOfStudents) + priceBelts * (countOfStudents - freeBelts);

if (budget >= neededEquipment)
{
    Console.WriteLine($"The money is enough - it would cost {neededEquipment:F2}lv.");
}
else
{
    Console.WriteLine($"John will need {neededEquipment - budget:F2}lv more."
);
}