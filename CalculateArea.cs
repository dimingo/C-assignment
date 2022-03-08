// #program to calculate the area of a right angled triangle
// #variables base, height
// method Area = 0.5*base*height

using System;

class RightAngledTriangle
{
 private double basel; 
  private double height;
  private double area;

 
 public void input(){
	 Console.Write("\nEnter The base of the Triangle:>");
	 basel = Convert.ToDouble(Console.ReadLine());
	 Console.Write("\nEnter The height of the Triangle:>");
	 height = Convert.ToDouble(Console.ReadLine());

 }
//  compute area
public void computeArea()
{
	area = 0.5*basel*height;
	// Console.WriteLine("/ area of the triangle is:" + area);



	}
public void output(){
	
Console.WriteLine("The area of the triangle is:" + area);

}

}




class CalculateArea
{

static void Main(string[] args)
{

RightAngledTriangle Tri1 = new RightAngledTriangle();
 
Tri1.input();
Tri1.computeArea();
Tri1.output();
}
}


