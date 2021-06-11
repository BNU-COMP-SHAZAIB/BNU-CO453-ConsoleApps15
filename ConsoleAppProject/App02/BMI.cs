
using System;
using System.Text;
using System.Collections.Generic;
using ConsoleAppProject.Helpers;


namespace ConsoleAppProject.App02

{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMICalculator
    { 
        string unitChoice;

        double Metres;
        double Kilos;
        double Pounds;
        double Inches;

        double metricBmiResult;
        double imperialBmiResult;
        public const String QUIT = "quit";

        //Show App Title and The Author
        public void DisplayHeading()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("    Body Mass Index Calculator");
            Console.WriteLine("         by Shazaib Choudhry");
            Console.WriteLine("-----------------------------------\n");
        }

        //User Selects Between Metric or Imperial Unit
        public void SelectUnits()
        {
            Console.WriteLine("Please select between the following units:");
            Console.WriteLine("Metric || Imperial");
            unitChoice = Console.ReadLine();
        }

        //BAME(Black, Asian and other minority ethnic groups) Extra Alert
        public void BameWarningHeading()
        {
            Console.WriteLine("\nIf you are Black, Asian or other minority ethnic groups, you have a higher risk:\n");
            Console.WriteLine("Adults 23.0 or more are at increased risk!");
            Console.WriteLine("Adults 27.5 or more are at high risk!\n");
        }

        //Allows The User To Input Metric Values
        public void InputMetricValues()
        {
            Console.WriteLine("\nEnter your height in metres and you weight in kilos:\n");
            Console.WriteLine("Enter your height in metres:");
            Metres = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your weight in kilos:");
            Kilos = Convert.ToDouble(Console.ReadLine());
        }

        //Allows The User To Input Imperial Values
        public void InputImperialValues()
        {
            Console.WriteLine("\nEnter your height in inches and your weight stones:");
            Console.WriteLine("Enter your height in inches:");
            Inches = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your weight in pounds:");
            Pounds = Convert.ToDouble(Console.ReadLine());
        }

        //Calculate the BMI with Metric Values (Metres and Kilos)
        public void CalculateMetricBmi()
        {
            metricBmiResult = Kilos / (Metres * Metres);
        }

        //Calculate the BMI with Imperial Values (Pounds and Feet)
        public void CalculateImperialBmi()
        {
            imperialBmiResult = (Pounds * 703) / (Inches * Inches);
        }

        //Metric BMI Results (Category Selection)
        public void MetricBmiResults()
        {
            if (metricBmiResult < 18.50)
            {
                Console.WriteLine("Your BMI is {0}. You are Underweight!", metricBmiResult);
            }
            else if (metricBmiResult > 18.5 && metricBmiResult < 24.9)
            {
                Console.WriteLine("Your BMI is {0}. You are Normal!", metricBmiResult);
            }
            else if (metricBmiResult > 25.0 && metricBmiResult < 29.9)
            {
                Console.WriteLine("Your BMI is {0}. You are Overweight!", metricBmiResult);
            }
            else if (metricBmiResult > 30.0 && metricBmiResult < 34.9)
            {
                Console.WriteLine("Your BMI is {0}. You are Obese Class I", metricBmiResult);
            }
            else if (metricBmiResult > 35.0 && metricBmiResult < 39.9)
            {
                Console.WriteLine("Your BMI is {0}. You are Obese Class II", metricBmiResult);
            }
            else if (metricBmiResult >= 40)
            {
                Console.WriteLine("Your BMI is {0}. You are Obese Class III", metricBmiResult);
            }
            else
            {
                Console.WriteLine("Error: Invalid Data");
            }
            BameWarningHeading();
        }

        //Imperial BMI Results (Category Selection)
        public void ImperialBmiResults()
        {
            if (imperialBmiResult < 18.50)
            {
                Console.WriteLine("Your BMI is {0}. You are Underweight!", imperialBmiResult);
            }
            else if (imperialBmiResult > 18.5 && imperialBmiResult < 24.9)
            {
                Console.WriteLine("Your BMI is {0}. You are Normal!", imperialBmiResult);
            }
            else if (imperialBmiResult > 25.0 && imperialBmiResult < 29.9)
            {
                Console.WriteLine("Your BMI is {0}. You are Overweight!", imperialBmiResult);
            }
            else if (imperialBmiResult > 30.0 && imperialBmiResult < 34.9)
            {
                Console.WriteLine("Your BMI is {0}. You are Obese Class I", imperialBmiResult);
            }
            else if (imperialBmiResult > 35.0 && imperialBmiResult < 39.9)
            {
                Console.WriteLine("Your BMI is {0}. You are Obese Class II", imperialBmiResult);
            }
            else if (imperialBmiResult >= 40)
            {
                Console.WriteLine("Your BMI is {0}. You are Obese Class III", imperialBmiResult);
            }
            else
            {
                Console.WriteLine("Error: Invalid Data");
            }
            BameWarningHeading();
        }

        //Main Method
        public void BmiCalculation()
        {
            DisplayHeading();
            SelectUnits();

            if (unitChoice == "metric")
            {
                InputMetricValues();
                CalculateMetricBmi();
                MetricBmiResults();
            }
            else if (unitChoice == "imperial")
            {
                InputImperialValues();
                CalculateImperialBmi();
                ImperialBmiResults();
            }
            else
            {
                Console.WriteLine("\nError: Invalid Unit Choice\n");
            }
        }
    }
}

