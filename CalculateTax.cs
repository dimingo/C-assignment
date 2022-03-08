using System;

class Tax {
    private string gender;
    private double salary,tax;

    public void input()
    {
        Console.WriteLine("\nEnter the Gender");
        gender= Console.ReadLine();
         Console.WriteLine("\nEnter the Salary");
        salary= Convert.ToDouble(Console.ReadLine());
    }


    public void taxCalc(){
        if ( gender == "female"){
            if(salary >= 15000){
                tax = 0.14*salary;
            }
            else {
                tax = 0.12 * salary;
            }
        }else if( gender == "male"){
            if(salary >= 14000){
                tax = 0.15*salary;
            }
            else {
                tax = 0.13 * salary;
        }

       
    }
     Console.WriteLine("Your Tax is ksh: {0}", tax);
    }
}

class CalculateTax {
    

    static void Main(string[] args){

        Tax employee1 = new Tax();

        employee1.input();
        employee1.taxCalc();

    }
}