namespace hwLesson8
{
    struct Temperature
    {
        public DateTime Date { get; }
        public float Celsius { get; }
        public float Fahrenheit { get; }
        public float Kelvin { get; }

        public bool IsEmpty { get; } = true;

        public Temperature(DateTime date, float celsius)
        {
            Date = date;
            Celsius = celsius;
            Fahrenheit = (float)(celsius * 1.8) + 32;
            Kelvin = (float)celsius + 273.15F;
            IsEmpty = false;
        }

        public string GetInformation() =>
            $"{Date:d} temperature was {Celsius} C, {Fahrenheit} F, {Kelvin} K";
    }
}
