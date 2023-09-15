using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module6
{
    internal class Utilities
    {
        public static void escapeCharacters()
        {
            string fName = "Smaran";
            string lName = "Srini";

            string displayName = $"Welcome!\n{fName}\t{lName}";
            Console.WriteLine(displayName);
            Console.ReadLine();
        }

    }
}
