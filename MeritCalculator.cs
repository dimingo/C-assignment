/*student takes five units 
get the average and calculate the merit score
*/
using System;

class Student{
    private  double score= 0.0;
    private  int  units;
    string merit;
    double average;

        // Enter number of units your are taking and their score
    public double input(){
        Console.WriteLine("\n Enter the number of units you are taking");
        units = Convert.ToInt32(Console.ReadLine()) ;

        for(int i=1; i<=units; i++){
            
            Console.WriteLine("\nEnter the score of unit {0}", i);
            score += Convert.ToDouble(Console.ReadLine());
            

        }
        average = score/units;
       
        return  average;

    }

    public void calculateMerit(){
        if (average >= 75 && average <=100)
        merit = "Distinction";
        else if (average >=65 && average < 75)
        merit = "Credit";
        else if (average <= 50 && average < 65)
        merit = "Pass";
        else
        merit="Fail";


        Console.WriteLine("The Average Mark is: "+ average);
        Console.WriteLine("The Merit Obtained is: "+ merit);


    }


    class MeritCalculator{
        static void Main(string[] args){

            Student okoth = new Student();

            okoth.input();
            okoth.calculateMerit();

        }
    }





}