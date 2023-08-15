namespace hwLesson8
{
    struct Temperature
    {
        public DateTime Date { get; }
        public double Celsius { get; }
        public double Fahrenheit { get; }
        public double Kelvin { get; }

        public Temperature(DateTime date, double celsius)
        {
            Date = date;
            Celsius = celsius;
            Fahrenheit = (celsius * 1.8) + 32;
            Kelvin = celsius + 273.15;
        }

        public string GetInformation() =>
            $"{Date:d} temperature was {Celsius} C, {Fahrenheit} F, {Kelvin} K";
    }
}
