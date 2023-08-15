namespace hwLesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperature[] array = new[]
            {
                new Temperature(new DateTime(2023,3,12), 10),
                new Temperature(new DateTime(2023,3,13), 15),
                new Temperature(new DateTime(2023,3,14), 22.3F),
                new Temperature(new DateTime(2023,3,15), 25),
                new Temperature(new DateTime(2023,3,16), 30)
            };

            HydrometCentre hydrometCentre = new HydrometCentre(array);

            DateTime date = new DateTime(2023, 3, 14, 22, 10, 58);
            Console.WriteLine(hydrometCentre[date].GetInformation());

            Console.WriteLine(new string('-', 20));

            DateTime startDate = new DateTime(2023, 3, 13);
            DateTime endDate = new DateTime(2023, 3, 15, 12, 4, 33);

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