using System;

class Rectangle{
    private double sideLength;
    private double sideWidth;
    private double area, perimeter;


    public void input(){
        Console.Write("\nenter the Length of the triangle: ");
        sideLength = Convert.ToDouble(Console.ReadLine());
            
            
        Console.Write("\nenter the Length of the triangle: ");
        sideWidth = Convert.ToDouble(Console.ReadLine());

    }

    public void calculate(){
        area = sideLength*sideWidth;
        perimeter = 2*(sideLength+sideWidth);
    }
    
    public void output(){
        Console.WriteLine("\nThe Perimeter is: {0}", perimeter);
        Console.WriteLine("\nThe Area is: {0}", area);
    }
}

class Circle {
    private double radius;
    private double area, perimeter;
    private const double pie = Math.PI;

    public void input(){
        Console.WriteLine("\nEnter the radius of the circle: ");
        radius = Convert.ToDouble(Console.ReadLine());
    }

    public void calculate(){
        area = pie*radius*radius;
        perimeter = pie*2*(radius);
    }

    public void output(){
        Console.WriteLine("\nThe area of the circle is {0}", area);
        Console.WriteLine("\nThe Perimeter of the circle is {0}", perimeter);
    }
}

class AreaCalculator
{
   
    static void Main(string[] args)
    {
   
        
    Console.Write("\n\t\t******* Perimeter and Area Calculator *****");
    Console.Write("\n");
    Console.Write("\n\t\t     => Choose 1 for Rectangle");
    Console.Write("\n\t\t     => Choose 2 for Circle");
    Console.Write("\n");

    Console.Write("\n\t\t***** Please Enter Your Choice *****\n");
     int choice = Convert.ToInt32(Console.ReadLine());


         switch(choice)
         {
            case 1:
                Rectangle rec1 = new Rectangle();
                rec1.input();
                rec1.calculate();
                rec1.output();
            break;

            case 2:
            
                Circle cir1 = new Circle();
                cir1.input();
                cir1.calculate();
                cir1.output();
            break;
            default:
                 Console.WriteLine("\nYour value din't match the given choices:");
            break;

         }


         


        
    }
   
}