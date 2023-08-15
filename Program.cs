namespace hwLesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperature[] array = new[]
            {
                new Temperature(new DateTime(2023,03,12), 10),
                new Temperature(new DateTime(2023,03,13), 15),
                new Temperature(new DateTime(2023,03,14), 22.3),
                new Temperature(new DateTime(2023,03,15), 25),
                new Temperature(new DateTime(2023,03,16), 30)
            };

            HydrometCentre hydrometCentre = new HydrometCentre(array);

            DateTime date = new DateTime(2023, 03, 14);
            Console.WriteLine(hydrometCentre[date].GetInformation());

            Console.WriteLine(new string('-', 20));

            DateTime startDate = new DateTime(2023, 03, 13);
            DateTime endDate = new DateTime(2023, 03, 15);

            var result = hydrometCentre[startDate, endDate];

            if (result.Length == 0)
            {
                Console.WriteLine("Dates not found");
            }
            else
            {
                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine(result[i].GetInformation());
                }
            }
        }
    }
}