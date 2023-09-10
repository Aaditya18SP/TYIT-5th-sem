using System;

class operations{

public void Fibonacci(int no_of_elements){
int i=0,j=1,sum1,total_ele=0;

while(total_ele < no_of_elements){

Console.Write(" " + i);
sum1=i+j;
i=j;
j=sum1;

total_ele++;
}

}


//Prime Number

public void chkPrimeNumber(int number){

int f=0; 

for(int i=2;i<number;i++){
 if(number %i ==0){
f=1;
break;
}
}

if(f==1){
Console.WriteLine("{0}  is a composite number",number);
}
else{
Console.WriteLine("{0} is a prime number",number);
}

}

//Vowels

public void chkVowel(string sentence){
int vowels=0;

string entered_sentence= sentence.ToLower().Trim();
//Console.WriteLine(entered_sentence);

for (int i=0; i < entered_sentence.Length ; i++){
char current_char=entered_sentence[i];

if(current_char == 'a' || current_char == 'e' || current_char == 'i' || current_char == 'o' || current_char == 'u'){
vowels++;
}


}

Console.WriteLine("The number of vowels in the sentence are: {0}" ,vowels);
}


//Foreach with arrays

public void foreachWithArray(string [] arr){

foreach(string str in arr){
    Console.WriteLine("The element is: {0} ",str);
}
}
//Reverse Number
public void reverseAndSumOfNumber(int number){
int r , reverse_num=0,entered_num,sum1=0;
entered_num=number;

while(entered_num!=0){
r = entered_num%10;
sum1+=r;
reverse_num = (reverse_num*10) +r ;
entered_num = entered_num /10; //automatic floor division
}

Console.WriteLine("The reversed number is : {0}", reverse_num);
Console.WriteLine("The sum of digits is : {0}", sum1);

}


}

class prac1d{

public static void Main(string[] args){
int input_from_user;

while(true){
Console.Write("Choose a number:\n 0. Exit\n 1. Fibonacci \n 2. Prime number \n 3. Vowels \n 4. For each with arrays \n 5. Reverse number and find the sum of digits\n");
input_from_user=Convert.ToInt32(Console.ReadLine());

if(input_from_user==0){
break;
}
operations obj=new operations();

switch(input_from_user){
case 0:
break;

case 1:
int no_of_elements;
Console.Write("Enter required elements in the Fibonacci series:");
no_of_elements= Convert.ToInt32(Console.ReadLine());
obj.Fibonacci(no_of_elements);
Console.WriteLine();
break;

case 2:
int entered_number;
Console.Write("Enter a number to determine whether it is prime or composite:");
entered_number = Convert.ToInt32(Console.ReadLine());
obj.chkPrimeNumber(entered_number);
Console.WriteLine();
break;

case 3:
string sentence;
Console.Write("Enter a string:");
sentence = Console.ReadLine();
obj.chkVowel(sentence);
break;

case 4:
Console.WriteLine("Enter strings:");
string curr_str;
string[] str_arr=new string[4]; //array needs to be initialised
for(int i=0;i< 4;i++){
    //considering that there are 4 elements in the array
    Console.Write("Enter string:");
    curr_str=Console.ReadLine();
    str_arr[i]=curr_str;
}

obj.foreachWithArray(str_arr);
break;

case 5:
Console.Write("Enter a number:");
int num1=Convert.ToInt32(Console.ReadLine());
obj.reverseAndSumOfNumber(num1);
break;

default:
break;
}

}

}

}

/*
Choose a number:
 0. Exit
 1. Fibonacci
 2. Prime number
 3. Vowels
 4. For each with arrays
 5. Reverse number
 6. Find the sum of digits
1
Enter required elements in the Fibonacci series:5
 0 1 1 2 3
Choose a number:
 0. Exit
 1. Fibonacci
 2. Prime number
 3. Vowels
 4. For each with arrays
 5. Reverse number
 6. Find the sum of digits
2
Enter a number to determine whether it is prime or composite:123
123  is a composite number

Choose a number:
 0. Exit
 1. Fibonacci
 2. Prime number
 3. Vowels
 4. For each with arrays
 5. Reverse number
 6. Find the sum of digits
3
Enter a string:Hello
The number of vowels in the sentence are: 2

Choose a number:
 0. Exit
 1. Fibonacci
 2. Prime number
 3. Vowels
 4. For each with arrays
 5. Reverse number
 6. Find the sum of digits
4
Enter strings:
Enter string:ferrari
Enter string:mercedes
Enter string:pagani
Enter string:bmw
The element is: ferrari
The element is: mercedes
The element is: pagani
The element is: bmw

Choose a number:
 0. Exit
 1. Fibonacci
 2. Prime number
 3. Vowels
 4. For each with arrays
 5. Reverse number
 6. Find the sum of digits
5
Enter a number:123
The reversed number is : 321
The sum of digits is : 6


*/
