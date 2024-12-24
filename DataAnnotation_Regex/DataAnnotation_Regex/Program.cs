// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.ComponentModel.DataAnnotations;
namespace DataAnnotation_Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Console.WriteLine("-----Data Annotations------");
            //            Console.WriteLine("Enter Details: ");
            //            Console.WriteLine("Enter Name: ");
            //            string name = Console.ReadLine();
            //            Console.WriteLine("Enter Age: ");
            //            string age = (Console.ReadLine());
            //            Console.WriteLine("Enter Email: ");
            //            string email = Console.ReadLine();

            //            var user = new UserDetails
            //            {
            //                Name = name,
            //                Age = age,
            //                Email = email
            //            };

            //            var context = new ValidationContext(user);
            //            var results = new List<ValidationResult>();//Error will be stored here
            //            bool isvalid = Validator.TryValidateObject(user, context, results, true);

            //            if (isvalid)
            //            {
            //                Console.WriteLine("User data is valid");
            //                Console.WriteLine($"Name: {user.Name}, Age: {user.Age}, Email: {user.Email}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Validate errors");
            //                foreach(var error in results)
            //                {
            //                    Console.WriteLine($"{error.ErrorMessage}");
            //                }

            //            }

            //========================================================================================


            Console.WriteLine("-----Data Annotations------");
            Console.WriteLine("Enter Details: ");
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Date");
            DateTime date = DateTime.Now;
            Console.WriteLine($"{name} {date}");
            Console.WriteLine("Enter Age: ");
            string age = (Console.ReadLine());
            Console.WriteLine("Enter Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            Console.WriteLine("Password Confirmation");
            string confirmpassword = Console.ReadLine();

            var student = new Student
            {
                Name = name,
                EntryDate = date,
                Age = age,
                Email = email,
                Password = password,
                PasswordConfirmation = confirmpassword
            };

            var context = new ValidationContext(student);
            var results = new List<ValidationResult>();//Error will be stored here
            bool isvalid = Validator.TryValidateObject(student, context, results, true);

            if (isvalid)
            {
                Console.WriteLine("Student data is valid");
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, EntryDate = {student.EntryDate}, Email: {student.Email}, Password: {password}, ConfirmPassword: {confirmpassword}");
            }
            else
            {
                Console.WriteLine("Validate errors");
                foreach (var error in results)
                {
                    Console.WriteLine($"{error.ErrorMessage}");
                }
            }
        }
    }
}
    


