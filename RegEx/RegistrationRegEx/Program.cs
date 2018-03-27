using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegistrationRegEx
{
    class Customer
    {
        private string login;
        public string Login { get { return login; } set { login = value; } }

        private string password;
        public string Password { get { return password; } set { password = value; } }

        public override string ToString()
        {
            return $"Customer:\nLogin: {login}\nPassword: {password}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Registration\n" + new string('-', 50) + "\nEneter your login:\n(it must be a string consists of latin letters)");

            const string loginPattern = @"^[A-Za-z]+$";
            const string passwordPattern = @"^[0-9]+$";

            var loginMatcher = new Regex(loginPattern);
            var passwordMatcher = new Regex(passwordPattern);

            bool loginSuccess = false;
            bool passwordSuccess = false;
            bool result;

            Customer customer = new Customer();

            while (!loginSuccess)
            {
                string login = Console.ReadLine();

                result = loginMatcher.IsMatch(login);

                if (!result)
                {
                    Console.WriteLine("Wrong format of an email:\nEnter login again:");
                    continue;
                }

                customer.Login = login;
                loginSuccess = true;
            }

            Console.WriteLine(new string('-', 50) + "\nEneter your password:\n(it must be only numbers and symbols)");

            while (!passwordSuccess)
            {
                string password = Console.ReadLine();

                result = passwordMatcher.IsMatch(password);

                if (!result)
                {
                    Console.WriteLine("Wrong format of an password:\nEnter login again:");
                    continue;
                }

                customer.Password = password;
                passwordSuccess = true;
            }

            Console.WriteLine($"\n{customer}");

            Console.ReadKey();
        }
    }
}
