using System;
namespace StudentSampleAPI.Helpers
{
    public static class DateTimeOffSet
    {
        public static int GetCurrentAge(DateTimeOffset dateTimeOffset)
        {
            var currentDate = DateTime.UtcNow;
            int age = currentDate.Year - dateTimeOffset.Year;
            // Go back to the year in which the person was born in case of a leap year
            if (currentDate < dateTimeOffset.AddYears(age))
            {
                age--; 
            }

            return age;
        }
    }
}
