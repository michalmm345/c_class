using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void choice()
        {
            int userChoice = 0;
            int userNum = 0;
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("\nChoose one of the following options:\n" +
                    "1- squared value\n" +
                    "2-line of stars\n" +
                    "0-exit ");
                userChoice = int.Parse(Console.ReadLine());

                if (userChoice == 1)
                {
                    Console.WriteLine("enter num: ");
                    userNum = int.Parse(Console.ReadLine());
                    Console.WriteLine(userNum + "^2 =" + Math.Pow(userNum, 2));
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("enter num: ");
                    userNum = int.Parse(Console.ReadLine());
                    for (int i = 0; i < userNum; i++)
                        Console.Write("*");
                }
                else if (userChoice == 0)
                    flag = false;
                else
                    Console.WriteLine("invalid value");
            }
        }
        static void withoutBreak()
        {
            int total = 0;
            int userNum = 0;
            char answer = ' ';
            bool flag = true;
            while (flag)
            {


                Console.WriteLine("please enter num: ");
                userNum = int.Parse(Console.ReadLine());
                total += userNum;
                Console.WriteLine("add another number?");
                answer = char.Parse(Console.ReadLine());
                if (answer == 'y')
                    flag = true;
                else if (answer == 'n')
                {
                    Console.WriteLine("the total is: " + total);
                    flag = false;
                }
                else
                    Console.WriteLine("invalid value");

            }
        }
        static void oopsiteNum()
        {
            int userNum = 0;
            int copyNum = 0;
            int oppNum = 0;

            Console.WriteLine("please enter num");
            userNum = int.Parse(Console.ReadLine());
            copyNum = userNum;

            while (copyNum > 0)
            {
                oppNum = userNum % 10;
                copyNum %= 10;
                oppNum *= 10;
            }
            Console.WriteLine("oppsite num is: " + oppNum);
        }
        static void newNum()
        {
            int digitCount = 0;
            int userNum = 0;
            int copyNum = 0;
            int newNum = 0;
            int digit = 0;

            Console.WriteLine("please enter num: ");
            userNum = int.Parse(Console.ReadLine());
            copyNum = userNum;
            while (copyNum > 0)
            {
                copyNum /= 10;
                digitCount++;
            }
            if (digit != -1)
            {
                Console.WriteLine("please enter digit");
                digit = int.Parse(Console.ReadLine());
                newNum = (int)(userNum + (digit * Math.Pow(10, digitCount)));
                Console.WriteLine("newNum is: " + newNum);
            }
            else
                Console.WriteLine("invalid value");
        }
        static void findDigit()
        {
            int userNum = 0;
            int digit = 0;
            int max = 0;

            Console.WriteLine("please enter num");
            userNum = int.Parse(Console.ReadLine());
            while (userNum > 0)
            {
                digit = userNum % 10;

                if (digit > max)
                    max = digit;

                userNum /= 10;
            }
            Console.WriteLine(max);
        }

        static void multiplyDigits()
        {
            int userNum = 0;
            int copyOfNum = 0;
            int result = 1;

            Console.WriteLine("please enter num");
            userNum = int.Parse(Console.ReadLine());
            copyOfNum = userNum;
            while (copyOfNum > 0)
            {
                result *= copyOfNum % 10;
                copyOfNum /= 10;
            }
            Console.WriteLine("the result is: " + result);
        }
        static void guessNum()
        {
            Random rnd = new Random();
            int randomNum = rnd.Next(1, 100);
            int secretNum = randomNum;
            int guess = 0;
            int guessCount = 0;

            while (guess != secretNum)
            {
                Console.WriteLine("Enter your guess:");
                guess = int.Parse(Console.ReadLine());
                guessCount++;
                if (guess > secretNum)
                    Console.WriteLine("secret num is smaller");
                else if (guess < secretNum)
                    Console.WriteLine("secret num is bigger");

            }
            Console.WriteLine("secret num was discovered after " + guessCount + " guesses");
        }
        static void longestStreak()
        {
            int userNum = 0;
            int copyOfNum = 0;
            int digit = 0;
            int maxCount = 0;
            int lastDigit = 0;
            int digitCount = 0;

            Console.WriteLine("please enter num: ");
            userNum = int.Parse(Console.ReadLine());
            copyOfNum = userNum;

            while (copyOfNum > 0)
            {
                digit = copyOfNum % 10;
                if (digit == lastDigit)
                {
                    digitCount++;
                    if (digitCount > maxCount)
                        maxCount = digitCount;
                }
                else
                    digitCount = 1;

                lastDigit = digit;
                copyOfNum /= 10;
            }
            Console.WriteLine("the longest streak is " + maxCount);
        }

        
        static void Player()
        {
            int players = 0;
            int maxThrows = 0;
            int bestPlayer = 0;
            int i = 0;
            int throws = 0;
            double sum = 0;
            double lastThrow = 0;
            double averageLength = 0;


            Console.WriteLine("How many players?");
            players = int.Parse(Console.ReadLine());

            
            for (i = 1; i <= players; i++)
            {

                Console.WriteLine($"Player number {i}");

                while (true)
                {
                    Console.WriteLine("Enter throw length (<= 0 or not longer ends turn):");
                    double length = double.Parse(Console.ReadLine());

                    if (length > 0 && length > lastThrow)
                    {
                        throws++;
                        sum += length;
                        lastThrow = length;
                    }
                    else
                    {
                        lastThrow = 0;
                        break;
                    }
                }

                if(throws > 0)
                    averageLength = sum / throws;

                Console.WriteLine($"Player {i} throws: {throws}, length average: {averageLength:F2}");

                if (throws > maxThrows)
                {
                    maxThrows = throws;
                    bestPlayer = i;
                }
            }

            Console.WriteLine($"Best player: {bestPlayer} with {maxThrows} throws");
        }
        static void calcDigits()
        {
            int userNum = 0;
            int copyOfNum = 0;
            int digit = 0;
            int sumOfEven = 0;
            int sumOfOdd = 0;
            int maxDigit = 0;

            Console.WriteLine("please enter number");
            userNum=int.Parse(Console.ReadLine());
            copyOfNum=userNum;
            
            while(copyOfNum>0)
            {
                digit = copyOfNum % 10;
                if (digit % 2 == 0)
                    sumOfEven += digit;
                else
                    sumOfOdd += digit;
                if (digit>maxDigit)
                    maxDigit = digit;
                copyOfNum /= 10;
            }
            Console.WriteLine("the sum of even digits is "+sumOfEven +" the sum of odd digits is "+sumOfOdd+ " the biggest digit is "+maxDigit);
        }
        
        static void digits()
        {
            int firstNum = 0;
            bool isEven=false;
            int i=0;
            int digit = 0;
            string[] input = Console.ReadLine().Split(' ');
            firstNum = int.Parse(input[0]);
            if (firstNum %2==0)
                isEven=true;
            for(i=0; i<input.Length; i++)
            {
                digit=int.Parse(input[i]);
                if (digit == 0)
                    break;
                if (isEven)
                {
                    Console.Write(digit + " ");
                    Console.Write(digit + " ");
                }
                else
                    Console.Write(digit + " ");
            }
        }
        static bool isPolindrome(int userNum)
        {
            int digit = 0;
            int newNum = 0;
            int copyOfNum=userNum;
            while (copyOfNum>0)
            {
                digit = copyOfNum % 10;
                newNum = newNum * 10 + digit;
                copyOfNum /= 10;

            }
            if (newNum == userNum)
                return true;
            else
                return false;
        }
        static string weatherConditions(double temp, bool isRainy)
        {
            string weather = " ";
            string message = " ";
            if (temp > 20 && temp < 30)
                weather = "warm";
            else if (temp > 30)
                weather = "hot";
            else
                weather = "cold";
            if (isRainy) 
                message="it's " + weather+ "and rainy";
            else
                message = "it's " + weather;
            return message;
             
        }
        static void task()
        {
            int i = 0;
            int[] numbers = new int[3];
            Console.WriteLine("enter " + numbers.Length + " numbers:");
            for(i=0;i<numbers.Length; i++)
                numbers[i] =int.Parse(Console.ReadLine());
            for (i=numbers.Length-1;i>=0;i--)
                Console.Write(numbers[i]+" ");
        }
        static void copyArray()
        {
            int i = 0;
            int[] arr2 = new int[3];
            int[] arr1 = { 4, 2, 6 };
            
            Console.Write("elements in arr 2: ");
            arr2=printArray(arr1);
            for(i=0;i<arr2.Length;i++)
                Console.Write(arr2[i]+" ");
            
        }
        static int[] printArray(int[] arr)
        {
            int[] arr2 = new int[3];
            int i = 0;
            for (i = 0; i < arr2.Length; i++)
                arr2[i] = arr[i];
            
            return arr;
        }
        static int calcAvg(int[] grades)
        {
            int i = 0;
            int sum = 0;
            int average = 0;
            for (i = 0; i < grades.Length; i++)
                sum += grades[i];
            average = sum / grades.Length;
            return average;
        }
        static void studentsGrades()
        {
            int i = 0;
            int average = 0;
            int aboveAvg = 0;
            int [] grades = new int[10];
            Console.WriteLine("please enter 10 grades");
            for (i = 0; i < grades.Length; i++)
                grades[i] = int.Parse(Console.ReadLine());
            average=calcAvg(grades);
            for (i = 0; i < grades.Length; i++)
            {
                if (grades[i] > average)
                    aboveAvg++;
            }
            Console.WriteLine("there are " + aboveAvg + " grades above the average");


        }

        static int[] moveArr(int[]arr, int offend)
        {
            int i = 0;
            int length=arr.Length;
            int[] copy = arr;
            for (i=0;i<length-1;i++)
            {
                if (copy[i] >= offend)
                    arr[i] = copy[i - 3];
                else
                    arr[i] = copy[offend + i];
            }
            return arr;
        }
        static void Main(string[] args)
        {
            // choice();
            //withoutBreak();
            //oopsiteNum();
            //newNum();
            //findDigit();
            //multiplyDigits();
            //guessNum();
            //longestStreak();
            //Player();
            //calcDigits();
            //digits();
            /*int userNum = 0;
            bool isNum = false;
            Console.WriteLine("please enter num");
            userNum=int.Parse(Console.ReadLine());
            isNum= isPolindrome(userNum);
            if (isNum)
                Console.WriteLine("the number is polindrome");
            else
                Console.WriteLine("not a polindrome");*/
            /*double temp = 0;
            bool isRaining=false;
            int userAnswer = 0;
            Console.WriteLine("please enter temp");
            temp=double.Parse(Console.ReadLine());
            Console.WriteLine("is it raining today?(0-no, other-yes)");
            userAnswer = int.Parse(Console.ReadLine());
            if(userAnswer!=0)
                isRaining = true;
            weatherConditions(temp, isRaining);*/
            //task();
            //copyArray();
            //studentsGrades();
            int i = 0;
            int[] arr = { 4, 3, 2, 6, 7 };
            int offend = 0;
            Console.WriteLine("please enter number to move: ");
            offend = int.Parse(Console.ReadLine());

            arr = moveArr(arr,offend);

            for (i = 0; i <= arr.Length-1; i++)
            {
                Console.Write(arr[i]);
            }
        }
    }
}
