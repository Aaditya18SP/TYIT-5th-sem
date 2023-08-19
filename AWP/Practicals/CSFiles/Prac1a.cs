using System;

 class prac1a{
public int multiply(int a, int b, int c, int d){
int prod =a*b*c*d;
return prod;
}

public static void Main(string [] args){

int a,b,c,d;
Console.WriteLine("Enter num1:");
a= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter num2:");
b=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter num3:");
c=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter num4:");
d=Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(" {0} , {1}, {2}, {3}", a,b,c,d);
//Console.WriteLine(''The product is : {0}" , multiply(a,b,c,d));

prac1a obj = new prac1a();
Console.WriteLine("The product is : {0} ", obj.multiply(a,b,c,d) );

}


}