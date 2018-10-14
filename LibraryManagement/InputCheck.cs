using System;

namespace LibraryManagement
{
    class InputCheck
    {
        public static string checkRole(string option)
        {
            try
            {
                Console.Write(option);
                string role = Console.ReadLine().ToLower();
                if (role.Equals("u") || role.Equals("a"))
                {
                    return role;
                }
            }
            catch
            {
                Console.Write("Enter either u or a only. ");
            }
            return checkRole(option);
        }

        public static int CheckInteger(string option, int max)
        {
            try
            {
                Console.Write(option);
                string input = Console.ReadLine();
                int output = Convert.ToInt32(input);
                if (output >= 1 && output <= max)
                    return output;
                else
                    Console.WriteLine("Enter a valid input");
            }
            catch
            {
                Console.WriteLine("Enter a valid input");
            }
            return CheckInteger(option, max);
        }
    }
}
