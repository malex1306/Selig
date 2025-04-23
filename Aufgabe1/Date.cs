namespace Aufgabe1;

    public class InvalidDateException : Exception
    {
        public InvalidDateException(string message) : base(message) { }
    }

    public class DateOutOfRangeException : Exception
    {
        public DateOutOfRangeException(string message) : base(message) { }
    }

    public class Date
    {
        private static readonly int[] monthLengths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly string[] weekdays = { "So", "Mo", "Di", "Mi", "Do", "Fr", "Sa" };

        private int day;
        private int month;
        private int year;

        public Date(int day, int month, int year)
        {
            if (year < 1800 || year > 2100)
                throw new DateOutOfRangeException("Year must be between 1800 and 2100.");

            if (!IsValidDate(day, month, year))
                throw new InvalidDateException("Invalid date combination.");

            this.day = day;
            this.month = month;
            this.year = year;
        }

        public Date(int dayOfYear, int year)
        {
            if (year < 1800 || year > 2100)
                throw new DateOutOfRangeException("Year must be between 1800 and 2100.");

            int maxDay = IsLeapYear(year) ? 366 : 365;
            if (dayOfYear < 1 || dayOfYear > maxDay)
                throw new InvalidDateException("Day of year is out of valid range.");

            this.year = year;
            int m = 1;
            while (dayOfYear > GetMonthLength(m, year))
            {
                dayOfYear -= GetMonthLength(m, year);
                m++;
            }

            this.month = m;
            this.day = dayOfYear;
        }

        public static int GetMonthLength(int month, int year)
        {
            if (month == 2 && IsLeapYear(year))
                return 29;
            return monthLengths[month - 1];
        }

        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        private static bool IsValidDate(int day, int month, int year)
        {
            if (month < 1 || month > 12) return false;
            return day >= 1 && day <= GetMonthLength(month, year);
        }

        public bool Equals(Date a)
        {
            return day == a.day && month == a.month && year == a.year;
        }

        public bool IsSameDay(Date a)
        {
            return day == a.day && month == a.month;
        }

        public override string ToString()
        {
            return $"{day:D2}.{month:D2}.{year}";
        }

        public Date Tomorrow()
        {
            int newDay = day + 1;
            int newMonth = month;
            int newYear = year;

            if (newDay > GetMonthLength(month, year))
            {
                newDay = 1;
                newMonth++;
                if (newMonth > 12)
                {
                    newMonth = 1;
                    newYear++;
                }
            }

            return new Date(newDay, newMonth, newYear);
        }

        public void Yesterday()
        {
            int newDay = day - 1;
            if (newDay < 1)
            {
                month--;
                if (month < 1)
                {
                    month = 12;
                    year--;
                }
                day = GetMonthLength(month, year);
            }
            else
            {
                day = newDay;
            }
        }

        public string GetWeekday()
        {
            int anchorDay = GetAnchorDay(year / 100);
            int doomsday = GetDoomsday(year);

            int[] monthDoomsday = IsLeapYear(year) ?
                new[] { 3, 29, 14, 4, 9, 6, 11, 8, 5, 10, 7, 12 } :
                new[] { 3, 28, 14, 4, 9, 6, 11, 8, 5, 10, 7, 12 };

            int diff = (day - monthDoomsday[month - 1]) % 7;
            int weekday = (doomsday + diff + 7) % 7;

            return weekdays[weekday];
        }

        private int GetDoomsday(int year)
        {
            int y = year % 100;
            int a = y / 12;
            int b = y % 12;
            int c = b / 4;
            int d = GetAnchorDay(year / 100);
            return (a + b + c + d) % 7;
        }

        private int GetAnchorDay(int century)
        {
            return (5 * (century % 4) + 2) % 7;
        }
    }

