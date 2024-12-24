// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Text.RegularExpressions;
namespace DataAnnotation_Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("---Regex Practise----");
            //    Console.WriteLine("Enter name");
            //    string name = (Console.ReadLine());
            //    Console.WriteLine("Enter Age");
            //    string age = (Console.ReadLine());
            //    Console.WriteLine("Enter Phone");
            //    string phone = (Console.ReadLine());
            //    Console.WriteLine("Enter Zipcode");
            //    string zipcode = (Console.ReadLine());

            //    bool IsNameValid = ValidateName(name);
            //    bool IsAgeValid = ValidateAge(age);
            //    bool IsPhoneValid = ValidatePhone(phone);
            //    bool IsZipcodeValid = ValidateZipCodes(zipcode);
            //    if (IsNameValid && IsAgeValid && IsPhoneValid && IsZipcodeValid)
            //    {
            //        Console.WriteLine("User Data is Valid");
            //    }
            //    else
            //    {
            //        if (!IsNameValid)
            //        {
            //            Console.WriteLine("Name should start with caps and minimum 3 letters");
            //        }
            //        if (!IsAgeValid)
            //        {
            //            Console.WriteLine("Age should be between 18 and 65 ");
            //        }
            //        if (!IsPhoneValid)
            //        {
            //            Console.WriteLine("Phone number should be of 10 digits");
            //        }
            //        if (!IsZipcodeValid)
            //        {
            //            Console.WriteLine("Zipcode should be of 5 to 6 digits");
            //        }
            //    }

            Console.WriteLine("Enter name");
            string name = (Console.ReadLine());
            Console.WriteLine("Enter Email");
            string email = (Console.ReadLine());
            Console.WriteLine("Enter Phone");
            string phone = (Console.ReadLine());
            Console.WriteLine("Enter Date");
            string date = (Console.ReadLine());
            
            Console.WriteLine("Enter string");
            string valibetween = (Console.ReadLine());

            Console.WriteLine("Enter string");
            string  validateonrormaore = (Console.ReadLine());

            bool IsNameValid = ValidateNames(name);
            bool IsEmailValid = ValidateEmail(email);
            bool IsPhoneValid = ValidatePhone(phone);
            bool IsDateValid = ValidateDate(date);
           
            bool IsValidateBetween = ValidateOneOrMore(validateonrormaore);
            bool IsValidateOneOrMore = ValidateOneOrMore(validateonrormaore);
            if (IsNameValid && IsEmailValid && IsPhoneValid && IsDateValid  && IsValidateBetween && IsValidateOneOrMore)
            {
                Console.WriteLine("User Data is Valid");
            }
            else
            {
                if (!IsNameValid)
                {
                    Console.WriteLine("Name should start with caps and minimum 3 letters");
                }
                if (!IsEmailValid)
                {
                    Console.WriteLine("Email should be right");
                }
                if (!IsPhoneValid)
                {
                    Console.WriteLine("Phone number should be of 10 digits");
                }
                if (!IsDateValid)
                {
                    Console.WriteLine("Date should be in yyyy-mm-dd format digits");
                }
                if (IsValidateBetween)
                {
                    Console.WriteLine("String should start with's' and end with 't' ");
                }
                if (IsValidateOneOrMore)
                {
                    Console.WriteLine("string should be in given format");
                }
            }

        }


        public static bool ValidateNames(string name)
        {
            string pattern = @"^[a-z]{3,}";
            return Regex.IsMatch(pattern, name);
        }

        public static bool ValidateEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(pattern, email);
        }
        public static bool ValidatePhone(string phone)
        {
            string pattern = @"^\+ [0 - 9]{ 2}\s + [0 - 9]{ 2}\s + [0 - 9]{ 8}$";//+xx xx xxxxxxxx
            return Regex.IsMatch(pattern, phone);
        }
        public static bool ValidateDate(string date)
        {
            string pattern = @"^\d{4}-\d{2}-\d{2}$";
            return Regex.IsMatch(pattern, date);
        }
       
        public static bool ValidateBetween(string start, string end)
        {
            string pattern = @"s..t";
            return Regex.IsMatch (pattern, start);
        }
       public static bool ValidateOneOrMore(string name)
       { 
            string pattern = @"r*u";// use to match the preceding characteer zero or more times
            return Regex.IsMatch(pattern, name);
       }
        //public static bool ValidateName(string name)
        //{
        //    string pattern = @"^[A-Z][a-z]{2,50}";
        //    return Regex.IsMatch(pattern, name);
        //}

        //public static bool ValidateAge(string age)
        //{ //[0-9]{50}
        //    string pattern = @"^\d+$";
        //    if (Regex.IsMatch(pattern, age))
        //    {
        //        int ageV = int.Parse(age);
        //        return ageV >= 18 && ageV <= 65;
        //    }
        //    return false;
        //}

        //public static bool ValidatePhone(string phone)
        //{
        //    string pattern = @"^\d{10}$";
        //    return Regex.IsMatch(pattern, phone);
        //}

        //public static bool ValidateZipCodes(string zipcode)
        //{
        //    string pattern = @"^\d{5,6}$";
        //    return Regex.IsMatch(pattern, zipcode);
        //}
    }
}
