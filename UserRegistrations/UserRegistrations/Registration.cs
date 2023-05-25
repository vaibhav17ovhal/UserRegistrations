﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrations
{
    public class Registration
    {
        public void Register()
        {
            string pattern_name = @"^[A-Z][a-z]{2,}$"; //Vaibhav
            string input_name = "";

            Regex obj = new Regex(pattern_name);

            while (true)
            {
                Console.Write("Please enter first name: ");
                input_name = Console.ReadLine();

                if (obj.IsMatch(input_name))
                {
                    Console.WriteLine($"'{input_name}' is a valid first Name.\n");
                    //break;
                }
                else
                {
                    Console.WriteLine("Invailid Input!! \nTry Again...\n");
                }

                Console.Write("Please enter last name: ");
                input_name = Console.ReadLine();

                if (obj.IsMatch(input_name))
                {
                    Console.WriteLine($"'{input_name}' is a valid last Name.\n");
                    //break;
                }
                else
                {
                    Console.WriteLine("Invailid Input!! \nTry Again...\n");
                }
            }
        }
        public void EmailRegistration()
        {
            string pattern_email = @"^[A-Za-z.-_]{3,}[@][A-Za-z]{2,}[.][A-Za-z]{2,3}[.]{0,1}[A-Za-z]{0,2}$"; //abc.xyz@bl.co.in
            string input_email = "";

            Regex obj = new Regex(pattern_email);

            while (true)
            {
                Console.Write("Enter your email: ");
                input_email = Console.ReadLine();

                if (obj.IsMatch(input_email))
                {
                    Console.WriteLine($"'{input_email}' is a valid Email.\n");
                }
                else
                {
                    Console.WriteLine("Invailid Input!! \nTry Again...\n");
                }
            }
        }
        public void MobileRegistration()
        {
            string pattern_mobile = @"^[9][1][ ][6-9][0-9]{9}$"; //91 9340596362
            string input_mobile = "";

            Regex obj = new Regex(pattern_mobile);

            while (true)
            {
                Console.Write("Enter your mobile number: ");
                input_mobile = Console.ReadLine();

                if (obj.IsMatch(input_mobile))
                {
                    Console.WriteLine($"'{input_mobile}' is a valid mobile number.\n");
                }
                else
                {
                    Console.WriteLine("Invailid Input!! \nTry Again...\n");
                }
            }
        }
        public void PasswordRegistration()
        {
            string pattern_password_rule1 = @"^[A-Z][0-9][A-Za-z0-9.-_]{5,}[@.-_]$";
            string input_password_rule1 = "";

            Regex obj = new Regex(pattern_password_rule1);

            while (true)
            {
                Console.Write("Enter the password: ");
                input_password_rule1 = Console.ReadLine();

                if (obj.IsMatch(input_password_rule1))
                {
                    Console.WriteLine($"'{input_password_rule1}' is a valid password.\n");
                }
                else
                {
                    Console.WriteLine("Invailid Input!! \nTry Again...\n");
                }
            }
        }
        public void CheckEmail(string input_mail)
        {
            string pattern_mail = @"[A-Za-z0-9._+-]{3}[@][A-Za-z0-9]{1,}[.][a-z]{3}[.]{0,1}[a-z]{0,}$";  
            
            Regex obj2 = new Regex(pattern_mail);

            while (true)
            {
                if (obj2.IsMatch(input_mail))
                {
                    Console.WriteLine($"'{input_mail}' is a valid Email.\n");
                    break;
                }
                else
                {
                    Console.WriteLine("Invailid Input!! \nTry Again...\n");
                    break;
                }
            }    
        }
    }
}
