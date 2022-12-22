using System.Xml.Linq;

namespace Loginning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //reg
            
            
            z:
            Console.WriteLine("Insert Your Gender (Bu arada Kamran loxdu amma palit eleme)");
            string gender = Console.ReadLine();
            if (gender != "male" && gender != "female")
            {
                Console.WriteLine("Fuck off");
                goto z;
            }
            else
            {
                Console.WriteLine("New Username");
                string username1 = Console.ReadLine();
                k:
                Console.WriteLine("New Password (More than 6 characters)");
                string password1 = Console.ReadLine();
                if (password1.Length <= 5)
                {
                    Console.WriteLine("Adam kimi yaz");
                    goto k;
                }
                else
                {
                    Console.WriteLine("Now try to connect");
                    myname:
                    Console.WriteLine("Your login");
                    string username = Console.ReadLine();

                    if (username == username1)
                    {
                        mypassword:
                        Console.WriteLine("Your Password");
                        string password = Console.ReadLine();
                        if (password == password1)
                        {
                            Console.WriteLine("Xos geldin ayqqqqaaaaa");
                        }
                        else
                        {
                            Console.WriteLine("qeletivi ele duz yaz shifreni");
                            goto mypassword;

                        }
                    }
                    else
                    {
                        Console.WriteLine("Access denied");
                        goto myname;
                    }
                }

                    
                

            }
        }
    }
}