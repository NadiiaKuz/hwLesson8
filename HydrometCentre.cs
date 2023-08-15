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

        private int GetIndex(DateTime date)
        {
            for (int i = 0; i < temperatures.Length; i++)
            {
                if (temperatures[i].Date.Date == date.Date)
                {
                    return i;
                }
            }

            return -1;
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
            int startPos = GetIndex(start);

            if (startPos == -1)
                return Array.Empty<Temperature>();

            int endPos = GetIndex(end);

            if (endPos == -1)
                return Array.Empty<Temperature>();

            Temperature[] temp = new Temperature[endPos - startPos + 1];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = temperatures[startPos + i];
            }

            return temp;
        }
    }
}
