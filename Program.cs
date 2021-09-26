using System;

namespace UT1_12
{
    /* Class: Program
     * Author: Jonathan Karcher
     * Purpose: Manage employee information
     */
    class Program
    {
        /* Method: Main
         * Purpose: Initialize data and to test if the user will receve a raise
         * Restrictions: None
         */
        static void Main(string[] args)
        {
            // create a string to store the users name
            string sName;
            // initialize the starting salary
            double dSalary = 30000;
            // propmt the user for their name
            Console.WriteLine("What is your name?");
            // assign the input to the users name
            sName = Console.ReadLine();
            // check if the user enterd a specific name
            if(GiveRaise(sName,ref dSalary))
            {
                Console.WriteLine("Congrtulations you have recieved a raise.");
            }
            // display the current status of the user
            Console.WriteLine("Your salary is {0}.", dSalary);
        }
        /* Method: GiveRaise
         * Purpose: Check if the users name is the same as my name, give a raise accordingly
         * Restrictions: None
         */
        static bool GiveRaise(string name, ref double salary)
        {
            // check if the name entered is my name
            if(name == "Jonathan Karcher")
            {
                // give a raise
                salary = 19999.99;
                return true;
            }    
            return false;
        }
    }
}