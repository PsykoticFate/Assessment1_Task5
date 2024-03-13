using System;

namespace Assement1
{

    class Task5
    {


        public static int CalcAverage(int totalGrade)
        {

          int average = (totalGrade / 4);
            return average;

        }
        
        public static int CalcGrade(int gradeAverage)
        {
          
            
            if (gradeAverage < 50) 
            {
                return 1;
            }
            if (gradeAverage >= 50 && gradeAverage < 60)
            {
                return 2;
            }
            if (gradeAverage >= 60 && gradeAverage < 70) 
            {
                return 3;
            }
            if (gradeAverage >= 70 && gradeAverage < 80)
            {
                return 4;
            }
            if (gradeAverage >= 80)
            {
                return 5;
            }
        }



        static void Main()
        {

            int mathGrade;
            int physGrade;
            int chemGrade;
            int compGrade;

            Console.WriteLine("Please enter the students results per subject out of 100");
            Console.WriteLine("Maths:");
            mathGrade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Physics:");
            physGrade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Chemistry:");
            chemGrade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Computer:");
            compGrade = Convert.ToInt32(Console.ReadLine());


            int totalGrade = (mathGrade + physGrade + compGrade + chemGrade) / 4;


            Task5 runOps = new Task5();

            int gradeAverage = CalcAverage(totalGrade);

            int grade = CalcGrade(gradeAverage);

            switch (grade)
            {
                case 0:
                    if (grade == 1)
                    {
                        Console.Write("Fail.  Your grade is F.");
                    }
                    break;
                case 1:
                    if (gradeA == 2)
                    {
                        Console.WriteLine("Pass.  Your grade is D.");
                    }
                    break;
                case 2:
                    if (grade == 3)
                    {
                        Console.WriteLine("Satisfactory.  Your grade is C.");
                    }
                    break;
                case 3:
                    if (grade == 4)
                    {
                        Console.WriteLine(" Good! Your grade is B.");
                    }
                    break;
                case 4:
                    if (grade == 5)
                    {
                        Console.WriteLine("Excellent! Your grade is A.");
                    }
                    break;

                    default: Console.WriteLine("error");
                    break;





            } 
          
        }
        
    }
}