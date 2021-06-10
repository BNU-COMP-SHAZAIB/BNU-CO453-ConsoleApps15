using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{

    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Shazaib Choudhry 14/12/2020
    /// </summary>
    public static class Program
    {


        public static void Main(string[] args)


        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine();
            Console.Beep();

            //ConsoleHelper.DisplayHeading();

            //Display Choices
            Console.WriteLine("Input the number of the app you wish to run, ex: 1");
            int choice = Convert.ToInt32(Console.ReadLine());

            App01.DistanceConverter converter = new App01.DistanceConverter();
            App02.BMICalculator calculator = new App02.BMICalculator();
            App03.StudentGrades marking = new App03.StudentGrades();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\n--------------App01 Convert Distances--------------");
                   converter.ConvertDistance();
                    break;
             
                case 2:
                    Console.WriteLine("\n----------------App02 BMI Calculator---------------\n");
                    calculator.BmiCalculation();
                    break;
                case 3:
                    Console.WriteLine("\n----------------App03 Student Marks----------------\n");
                    //marking.UserChoice();
                    break;
                case 4:
                    Console.WriteLine("\n----------------App04 Social Network---------------\n");
                    //app04
                    break;

                default:
                    Console.WriteLine("ERROR: Invalid Input");
                    break;
            }
        }


    }
}