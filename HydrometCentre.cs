namespace hwLesson8
{
    class HydrometCentre
    {
        private Temperature[] temperatures;

        public HydrometCentre(params Temperature[] temperatures)
        {
            this.temperatures = temperatures;
        }

        public Temperature this[DateTime date]
        {
            get => GetTemperatureByDate(date);
        }

        public Temperature[] this[DateTime start, DateTime end]
        {
            get => GetTemperaturesByPeriod(start, end);
        }

        private Temperature GetTemperatureByDate(DateTime date)
        {
            for (int i = 0; i < temperatures.Length; i++)
            {
                if (temperatures[i].Date.Date == date.Date)
                {
                    return temperatures[i];
                }
            }

            return new Temperature();
        }

        private Temperature[] GetTemperaturesByPeriod(DateTime start, DateTime end)
        {
            if (end < start)
                return Array.Empty<Temperature>();

            int count = 0;

            for (int i = 0; i < temperatures.Length; i++)
            {
                if (temperatures[i].Date.Date >= start.Date && temperatures[i].Date.Date <= end.Date && !temperatures[i].IsEmpty)
                    count++;
            }

            if (count == 0)
                return Array.Empty<Temperature>();

            Temperature[] temp = new Temperature[count];
            for (int i = 0; i < temperatures.Length; i++)
            {
                if (temperatures[i].Date.Date >= start.Date && temperatures[i].Date.Date <= end.Date && !temperatures[i].IsEmpty)
                    temp[--count] = temperatures[i];
            }

            return temp.OrderBy(x => x.Date).ToArray();
        }
    }
}
