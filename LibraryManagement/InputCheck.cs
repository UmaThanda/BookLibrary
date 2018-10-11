using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class InputCheck
    {

        public static string checkRole(string option)
        {
            try
            {
                Console.WriteLine(option);
                string role = Console.ReadLine().ToLower();
                if (role.Equals("u") || role.Equals("a"))
                {
                    return role;
                }
            }
            catch
            {
                Console.WriteLine("Enter either u or a");
            }

            return checkRole(option);
        }


        public static int CheckInteger(string option, int max)
        {
           // int output = 0;
 
            try
            {
                Console.WriteLine(option);
                string input = Console.ReadLine();
                int output = Convert.ToInt32(input);
               // if (int.TryParse(input, out output))
               // {
                    if (output >= 1 && output <= max)
                        return output;
                    
               // }
            }
            catch
            {
                Console.WriteLine("Enter a valid input");
                
            }

            return CheckInteger(option, max);
        }
            
       



    }
}
