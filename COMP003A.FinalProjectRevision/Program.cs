/*
 * Author: Jaime Garcia
 * Course: COMP003A
 * Purpose: Final Project - Dating App "Lovers or Friends"
 * Resources: COMP003A lecture and hw activities and http://www.stackoverflow.com
 * 
 */



using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace COMP003A.FinalProjectRevision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SectionSeparator("Lovers or Friends Profile Set-Up Page, Welcome!");

            //FIRSTNAME SECTION
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine(); //stores firstname input
            IsValidName(firstName);


            //LASTNAME SECTION
            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine(); //stores input
            IsValidName(lastName);


            //BIRTHYEAR SECTION
            Console.WriteLine("Please enter your birth year(yyyy): ");
            double birthYear = Convert.ToDouble(Console.ReadLine()); //stores input
            while (birthYear <= 1900 || birthYear >= 2023)
            {
                Console.WriteLine("Enter a year between 1901-2022");
                birthYear = Convert.ToDouble(Console.ReadLine());
            }






            //GENDER SECTION
            Console.WriteLine("Please enter your gender: (ex. M(Male), F(Female), or O(Other))");
            string gender = Console.ReadLine().ToLower();
            while (gender != "male" && gender != "m" && gender != "female" && gender != "f" && gender != "other" && gender != "o")
            {
                Console.WriteLine("Please only type ex. Male, Female, or Other");
                gender = Console.ReadLine().ToLower();
            }



            Console.WriteLine("\n");

            //DATING QUESTION SECTION
            var datingQuestions = new List<string>();
            var datingResponses = new List<string>();

            datingQuestions.Add("1. Describe your perfect first date:");
            datingQuestions.Add("2. What do you look for in a partner?");
            datingQuestions.Add("3. What does your typical day look like?");
            datingQuestions.Add("4. What are you current goals/aspirations?");
            datingQuestions.Add("5. Do you care about the religion of your partner?");
            datingQuestions.Add("6. Do you care about the political views of your partner?");
            datingQuestions.Add("7. What is your current occupation?");
            datingQuestions.Add("8. Do you like pets?");
            datingQuestions.Add("9. Why are you looking to date?");
            datingQuestions.Add("10. What inspires you the most?");


            // Reverse the output to show recent input first (starts at 10 and counts down)
            datingQuestions.Reverse();

            foreach (var question in datingQuestions)
            {
                Console.WriteLine(question);
                datingResponses.Add(Console.ReadLine());
            }




            Console.WriteLine("\n");

            ///// Profile return summary for user input 
            SectionSeparator("Lovers or Friends Profile Summary");

            Console.WriteLine($"Hello {lastName}, {firstName}! Welcome to Lovers or Friends, this is your dating profile summary:");
            Console.WriteLine("\n");
            AgeCalculator(birthYear);
            GenderDisplay(gender);


            Console.WriteLine("\n");

            //ListTransversal
            for (int i = 0; i < datingQuestions.Count; i++)
            {
                Console.WriteLine("Question " + datingQuestions[i]);
                Console.WriteLine(datingResponses[i]);
            }



        }

        ///<summary>
        ///Section separator method
        /// </summary>
        /// <param name="section">String input for section name</param>
        static void SectionSeparator(string section)
        {
            Console.WriteLine("".PadRight(80, '*') + $"\n\t\t{section} \n" + "".PadRight(80, '*'));
        }

        ///<summary>
        ///Array traversal
        /// </summary>
        ///<param name="item">string input</param>

        static void ListTransversal(List<string> quest)
        {
            //you can use a for-loop or other looping statements for array traversals
            /*foreach (string item in list)
            {
                Console.WriteLine(item);
            }*/
            for (var i = 0; i < quest.Count; i++)
            {
                Console.WriteLine(quest[i]);

            }

        }
        static void IsValidName(string inputName)
        {
            if (Regex.IsMatch(inputName, @"^[a-zA-Z]+$"))
            {

            }
            else
            {
                Console.WriteLine("Please enter a character from A-Z.");
                inputName = Convert.ToString(Console.ReadLine());
            }



        }
        /*if (Regex.IsMatch(name, @"^[a-zA-Z]+$"))
        {   

        }
        else
        {
            Console.WriteLine("Please enter a character from A-Z.");
            name = Convert.ToString(Console.ReadLine()); 
        }*/




        /// <summary>
        /// Method overloading with multiple parameters but no return value
        /// </summary>
        /// <param name="inputYear">Integer input</param>
        static void AgeCalculator(double inputYear)
        {
            Console.WriteLine($"You will be {DateTime.Now.Year - inputYear} years old this year, congrats! :)");
            //you can add more code here
        }
        /// <summary>
        /// Method overloading with multiple parameters but no return value
        /// </summary>
        /// <param name="inputGender">gender input</param>
        static void GenderDisplay(string inputGender)
        {
            Console.WriteLine($"You have stated that you identify as {inputGender}");
            //you can add more code here
        }




    }
}