using System;

namespace Lab8
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our C# class!");
            //Here are the arrays set for the code
            string[] students = { "Ragib", "Jerald", "Anamul", "Dannyelle", "Noelle", "Keith", "Justin", "Mohammed", "Nadim", "Shaun", "Mubin", "Calleen", "Jaide", "Adam", "Maggie", "Peter", "Jacob", "Kamisha", "Charlene", "Cana" };
            string[] hometown = { "Detroit", "Jupiter", "Atlanta", "Dearborn", "New York", "Kansas City", "Jacksonville", "Montreal", "Norway", "Seattle", "Montgomery", "Canton", "Jordan", "Ann Arbor", "Madison Heights", "Portland", "Jerusalem", "Kingstown", "Charlotte", "Cleveland" };
            string[] favoriteFood = { "Candy", "Jam", "Apples", "Donuts", "Nectarine", "Kumquat", "Jello", "Mayo", "Nyquil", "Strawberries", "Mustard", "Cucumbers", "Jackfruit", "Avocados", "Maple Syrup", "Pickles", "Jelly", "Kale", "Chips", "Celery" };

            bool success = true;
            //I set the while loop to true so i can loop back around
            while (success)
            {
                Console.Write("Which student would you like to learn more about? (enter a number 1-20): ");
                string input = Console.ReadLine();
                int num;
                int.TryParse(input, out num);
                //Added this to allow me to have the numbers start from 1-20 in my input and output.
                num--;

                if (num >= 0 && num < students.Length)
                {
                    //Allows the user to input what data they want
                    Console.Write($"Student {num + 1} is {students[num]}. What would you like to know about {students[num]}? (enter \"hometown\" or \"favorite food\"):  ");
                    string answer = Console.ReadLine().ToLower();
                    //Based on the input i allowed a few methods of validation to either start over or exit/
                    if (answer == "hometown")
                    {
                        Console.WriteLine($"{students[num]} is from {hometown[num]}. Would you like to know more? (enter \"yes\" or \"no\"): ");
                        string answertwo = Console.ReadLine().ToLower();

                        if (answertwo == "yes")
                        {
                            success=true;
                        }
                        else
                        {
                           success=false;
                        }
                    }
                    else if(answer =="favorite food")
                    {
                        Console.Write($"{students[num]} favorite food is {favoriteFood[num]}. Would you like to know more? (enter \"yes\" or \"no\"): ");
                        string answertwo = Console.ReadLine().ToLower();

                        if (answertwo=="yes")
                        {
                            success = true;
                        }
                        else
                        {
                           success=false;
                        }

                    }
                    else
                    {
                        //Here for validation
                        Console.WriteLine("That data does not exist. Please try again.");
                        break;
                    }
                    //success = false;
                }
                else
                {
                    //Here for validation
                    Console.WriteLine("That student does not exist.");
                    success = true;
                }
            }  
        }   
    }
}






