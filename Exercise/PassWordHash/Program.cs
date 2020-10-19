using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;


namespace ex09_william
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static public Dictionary<string, string> database = new Dictionary<string, string>();
        static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {
            byte[] data = hashAlgorithm.ComputeHash(Encoding.ASCII.GetBytes(input));
            var sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        static bool VerifyHash(string input, string hash)
        {
            StringComparer comparer = StringComparer.Ordinal;
            return comparer.Compare(input, hash) == 0;
        }
        static void getNewUser()
        {
            Console.WriteLine("\n=====Creating a new account=====");
            Console.Write("Enter UserName: ");
            string userName = Console.ReadLine();

            Console.Write("Enter Password: ");
            string passWord = Console.ReadLine();

            string hash;
            using (MD5 MD5Hash = MD5.Create())
            {
                hash = GetHash(MD5Hash, passWord);
            }
                database.Add(userName, hash);
            Console.WriteLine();
        }
        static void authenticate(Dictionary<string, string> database)
        {
            Console.WriteLine("\n=====Authentication in process=====");
            Console.Write("Enter UserName: ");
            string userName = Console.ReadLine();
            Console.Write("Enter Password: ");
            string passWord = Console.ReadLine();
            foreach (KeyValuePair<string, string> element in database)
            {
                string key = element.Key;
                string value = element.Value;
                if(key == userName)
                {
                    string hash;
                    using (MD5 MD5Hash = MD5.Create())
                    {
                        hash = GetHash(MD5Hash, passWord);
                        if(VerifyHash(value, hash))
                            Console.WriteLine("\n==============================\nAuthentication Succeeded.\n==============================\n");
                        else
                            Console.WriteLine("\n==========================================\nAuthentication Failed. Password incorrect.\n==========================================\n");
                    }
                }
            }
            if (!database.ContainsKey(userName))
                Console.WriteLine("\n==============================\nUsername not found.\n==============================\n");
        }
        static void printTable(Dictionary<string, string> database)
        {
            Console.WriteLine("\n=====Printing usernames and passwords=====");
            foreach (KeyValuePair<string, string> item in database)
            {
                string userName = item.Key;
                string passWord = item.Value;
                Console.WriteLine($"UserName: {userName}, PassWord: {passWord}");
            }
            Console.WriteLine();
        }
        static void Menu()
        {
            int count = 0;
            do
            {
                try
                {
                    count = 0;
                    Console.WriteLine("Please select one option: \n");
                    Console.WriteLine("1. Establish an account");
                    Console.WriteLine("2. Authenticate a user");
                    Console.WriteLine("3. Show all users");
                    Console.WriteLine("0. Exit the system\n");
                    Console.Write("Enter selection: ");

                    string userInput = Console.ReadLine();

                    switch (int.Parse(userInput))
                    {
                        case 1:
                            getNewUser();
                            Menu();
                            break;
                        case 2:
                            if (database.Count == 0)
                                Console.WriteLine("\n=====there's no user in the current database=====\n");
                            else
                                authenticate(database);
                            Menu();
                            break;
                        case 3:
                            if(database.Count==0)
                                Console.WriteLine("\n=====there's no user in the current database=====\n");
                            else
                                printTable(database);
                            Menu();
                            break;
                        case 0:
                            Console.WriteLine("=====exiting the program=====");
                            Console.WriteLine();
                            break;
                        default:
                            throw new OperationCanceledException("\n=====That's an invalid number=====\n");
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("\n=====The user name has been taken=====\n");
                    count++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("\n=====That's an invalid entry=====\n");
                    count++;
                }
                catch (OperationCanceledException oCe)
                {
                    Console.WriteLine(oCe.Message);
                    count++;
                }
            } while (count != 0);
        }
    }
}
