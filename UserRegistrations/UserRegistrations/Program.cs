﻿using System;

namespace UserRegistrations
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");

            Console.WriteLine("\n==============||===============\n");

            Registration reg = new Registration();
            //reg.Register();
            reg.EmailRegistration();
        }
    }
}
