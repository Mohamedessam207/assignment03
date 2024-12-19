using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region

            // 1- Write a program that takes a number from the user 
            // then prints "Yes" if that number can be divided by 3 and 4, 
            // otherwise print "No".
            // Example (1):
            // Input: 12
            // Output: Yes
            // Example (2):
            // Input: 9
            // Output: No
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 3 == 0 && number % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            #endregion


            #region
            // 1- Write a program that takes a number from the user 
            // then prints "Yes" if that number can be divided by 3 and 4, 
            // otherwise print "No".
            // Example (1):
            // Input: 12
            // Output: Yes
            // Example (2):
            // Input: 9
            // Output: No

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 3 == 0 && number % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }


            #endregion


            #region

            // 3- Write a program that takes 3 integers from the user 
            // then prints the max element and the min element.
            // Example (1):
            // Input: 7, 8, 5
            // Output:
            // max element = 8
            // min element = 5
            // Example (2):
            // Input: 3, 6, 9
            // Output:
            // max element = 9
            // min element = 3

            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int num3 = int.Parse(Console.ReadLine());

            int max = num1;
            int min = num1;

            // Determine the maximum value
            if (num2 > max)
            {
                max = num2;
            }
            if (num3 > max)
            {
                max = num3;
            }

            // Determine the minimum value
            if (num2 < min)
            {
                min = num2;
            }
            if (num3 < min)
            {
                min = num3;
            }

            Console.WriteLine($"Max element = {max}");
            Console.WriteLine($"Min element = {min}");


            #endregion


            #region

            // 4- Write a program that allows the user to insert an integer number 
            // then check if a number is even or odd.
            // Example:
            // Input: 4
            // Output: Even
            // Example:
            // Input: 7
            // Output: Odd

            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            #endregion


            #region

            // 5- Write a program that takes a character from the user then 
            // if it is a vowel chars (a, e, I, o, u) then print (vowel) 
            // otherwise print (consonant).
            // Example (1):
            // Input: O
            // Output: vowel
            // Example (2):
            // Input: b
            // Output: consonant

            Console.Write("Enter a character: ");
            char ch = char.Parse(Console.ReadLine().ToLower());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("consonant");
            }

            #endregion

            #region
            // 7- Write a program that allows the user to insert an integer 
            // then print a multiplication table up to 12.
            // Example:
            // Input: 5
            // Outputs: 5 10 15 20 25 30 35 40 45 50 55 60

            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.Write(number * i + " ");
            }

            #endregion

            #region
            // 9- Write a program that takes two integers then prints the power.
            // Example:
            // Input: 4 3
            // Output: 64
            // Hint: how to calculate 4^3 = 4 * 4 * 4 = 64
            Console.Write("Enter base number: ");
            int baseNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter exponent: ");
            int exponent = int.Parse(Console.ReadLine());

            int result = 1;

            if (exponent == 0)
            {
                result = 1;  
            else if (exponent == 1)
            {
                result = baseNumber;  
            else if (exponent == 2)
            {
                result = baseNumber * baseNumber;  
            else if (exponent == 3)
            {
                result = baseNumber * baseNumber * baseNumber;  
            }
            else if (exponent == 4)
            {
                result = baseNumber * baseNumber * baseNumber * baseNumber;  
            else if (exponent == 5)
            {
                result = baseNumber * baseNumber * baseNumber * baseNumber * baseNumber; 
            }

            Console.WriteLine($"Result: {result}");

                            #endregion

                            #region
                            // 10- Write a program to enter marks of five subjects and calculate total, average and percentage.
                            // Example:
                            // Input: 95 76 58 90 89
                            // Output: Total marks = 408
                            //         Average Marks = 81
                            //         Percentage = 81

                           
        
        
                Console.Write("Enter marks of five subjects: ");
                int mark1 = int.Parse(Console.ReadLine());
                int mark2 = int.Parse(Console.ReadLine());
                int mark3 = int.Parse(Console.ReadLine());
                int mark4 = int.Parse(Console.ReadLine());
                int mark5 = int.Parse(Console.ReadLine());

                int total = mark1 + mark2 + mark3 + mark4 + mark5;
                int average = total / 5;
                int percentage = (total * 100) / 500;

                Console.WriteLine($"Total marks = {total}");
                Console.WriteLine($"Average Marks = {average}");
                Console.WriteLine($"Percentage = {percentage}");

                            #region
                            // 11- Write a program to input the month number and print the number of days in that month.
                            // Example:
                            // Input: Month Number: 1
                            // Output: Days in Month: 31

           
          
                Console.Write("Enter Month Number: ");
                int month = int.Parse(Console.ReadLine());

                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                {
                    Console.WriteLine("Days in Month: 31");
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    Console.WriteLine("Days in Month: 30");
                }
                else if (month == 2)
                {
                    Console.WriteLine("Days in Month: 28/29 (Leap Year)");
                }
                else
                {
                    Console.WriteLine("Invalid month number.");
                }
                            #region
                            // 17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.


                            Console.Write("Enter x1, y1: ");
                int x1 = int.Parse(Console.ReadLine());
                int y1 = int.Parse(Console.ReadLine());

                Console.Write("Enter x2, y2: ");
                int x2 = int.Parse(Console.ReadLine());
                int y2 = int.Parse(Console.ReadLine());

                Console.Write("Enter x3, y3: ");
                int x3 = int.Parse(Console.ReadLine());
                int y3 = int.Parse(Console.ReadLine());

                if ((x2 - x1) * (y3 - y2) == (x3 - x2) * (y2 - y1))
                {
                    Console.WriteLine("The points lie on a single straight line.");
                }
                else
                {
                    Console.WriteLine("The points do not lie on a single straight line.");
                }



                            #endregion



                            #region

                            // 18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
                            // - If the worker completes the job within 2 to 3 hours, they are considered highly efficient. 
                            // - If the worker takes 3 to 4 hours, they are instructed to increase their speed. 
                            // - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed. 
                            // - If the worker takes more than 5 hours, they are required to leave the company. 
                            // To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.


            
                Console.Write("Enter time taken for task (in hours): ");
                double timeTaken = double.Parse(Console.ReadLine());

                if (timeTaken >= 2 && timeTaken <= 3)
                {
                    Console.WriteLine("Highly efficient");
                }
                else if (timeTaken > 3 && timeTaken <= 4)
                {
                    Console.WriteLine("Increase your speed");
                }
                else if (timeTaken > 4 && timeTaken <= 5)
                {
                    Console.WriteLine("Training required to enhance speed");
                }
                else if (timeTaken > 5)
                {
                    Console.WriteLine("Required to leave the company");
                }
                else
                {
                    Console.WriteLine("Invalid time.");
                }
                            #endregion

                            #region


                            // 21- Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen


                            int a = 10;
            int b = a; 

            a = 20;

            Console.WriteLine($"a = {a}, b = {b}");
                            // Output will be a = 20, b = 10 because b is a copy of the original value of a.

                            #endregion

                            #region
                            // 22- Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen


                            // Answer:
                            // A value 1 will be assigned to d

                            #endregion

                            #region
                            // Question 24: Which of the following is the correct output for the C# code given below?

                            // Answer: d) 6 1
                            #endregion


                            #region
                            // Question 25: What will be the output of the C# code given below?

                            // b) 6 5
                            #endregion







































        }
    }
}
