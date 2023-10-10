using System;

class prac1a{


public static void Main(string[] args){
 int a, b,c,d;

Console.Write("Enter 1st integer number:");
a= Convert.ToInt32(Console.ReadLine());

Console.Write("Enter an integer number:");
b= Convert.ToInt32(Console.ReadLine());

Console.Write("Enter an integer number:");
c= Convert.ToInt32(Console.ReadLine());

Console.Write("Enter an integer number:");
d= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Their Product is:{0}",a*b*c*d );

Console.WriteLine("Their sum is:{0}",a+b+c+d);
Console.WriteLine(" (a+b) -(c+d) is:{0}",(a+b)-(c+d));
}



}