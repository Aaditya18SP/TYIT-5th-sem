using System;

class operations{

public void fibonacci(int no_of_ele){
int i=0,j=1,k;
while(no_of_ele >0){
Console.Write(" {0}",i);
k=i+j;
i=j;
j=k;

no_of_ele--;
}
}

public int factorial(int x){
if(x==1){
return 1;
}

int result= x *factorial(x-1);
return result;

/*

int i =1;f=1;
while(i<=x){

f=f*i;
i++;

}

return f;

*/

}


public bool armstrong(int x){

int r,sum1=0,num=x,org=x;

while(num!=0){
r=num%10;
sum1=(sum1)+(r*r*r);
num=num/10;
}

if(sum1==org){
return true;
}
else{
return false;
}

}

public bool palindrome(int x){

int r,rev=0,num=x,org=x;

while(num!=0){
r=num%10;
rev=(rev*10)+r;
num=num/10;
}

if(rev==org){
return true;
}
else{
return false;
}

}

public bool prime_chk(int x){

int f=0;
for(int i=2; i<x;i++){
if(x%i==0){
f=1;
break;
}
}

if(f==1){
return false;
}
else{
return true;
}

}


public double rToD(double rupees){
double conv_rate=83.2D;

return rupees/conv_rate;
}

public double dToR(double dollar){
double conv_rate=83.2D;
return dollar*conv_rate;
}

public double celToFah(double cel){

double fah= (9.0/5.0 * cel) +32;
return fah;
}

public double fahToCel(double fah){
double cel = (fah-32) * (5.0/9.0);
return cel;

}


}

class prac1d{

public static void Main(string[] args){

operations obj =new operations();

//fibo
obj.fibonacci(10);

//fact
Console.WriteLine("\nFactorial:{0}", obj.factorial(5));

//prime
Console.WriteLine(" 23 - Number is prime?: {0}", obj.prime_chk(23));
Console.WriteLine(" 50 - Number is prime?: {0}", obj.prime_chk(50));


//palindrome
Console.WriteLine(" 121 - Number is palindrome?: {0}", obj.palindrome(121));
Console.WriteLine(" 123 - Number is palindrome?: {0}", obj.palindrome(123));


//armstrong
Console.WriteLine(" 151 - Number is armstrong?: {0}", obj.armstrong(151));
Console.WriteLine(" 153 - Number is armstrong?: {0}", obj.armstrong(153));


//Money conversion
Console.WriteLine("Rupees to Dollar:{0}", obj.rToD(1000));
Console.WriteLine("Dollars to Rupees:{0}", obj.dToR(23.4));

//Temp conversion
Console.WriteLine("Celsius to Fahrenheit:{0}", obj.celToFah(121));
Console.WriteLine("Fahrenheit to celsius:{0}",obj.fahToCel(121));


}
}