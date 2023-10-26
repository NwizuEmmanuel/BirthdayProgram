namespace BirthdayProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ask user for year, month & day of birth
            Console.Write("Enter year of birth: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter month of birth (1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter day of birth: ");
            int day = Convert.ToInt32(Console.ReadLine());

            year = DateTime.Now.Year; // reassign user's year of birth to current year

            // create user's D.O.B.
            DateTime dateOfBirth = new DateTime(year, month, day);

            DateTime now = DateTime.Now.Date;
            TimeSpan difference = dateOfBirth - now;

            int remainingDays = difference.Days;

            if (dateOfBirth == now)
            {
                Console.WriteLine("Happy Birthday!");
            }else if (remainingDays > 0)
            {
                Console.WriteLine($"{remainingDays} days to your birthday.");
            }else
            {
                Console.WriteLine("Already celebrated birthday");
            }
        }
    }
}