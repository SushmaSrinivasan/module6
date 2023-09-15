using System.Security.Cryptography.X509Certificates;

namespace module6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Sushma";
            string lastName = "Srinivasan";

            string fullName=firstName + " " + lastName; 

            string Name=firstName.ToLower()+" " + lastName.Trim().ToLower();

Console.WriteLine(fullName);
            Console.WriteLine(Name);

            int length=Name.Length;

            if(firstName.Contains("sush")||firstName.Contains("Sush"))
            {
                Console.WriteLine("It's Sushma");
            }
            string substring = fullName.Substring(2, 4);
            Console.WriteLine(substring);


            Utilities.escapeCharacters();

        }
    }
}