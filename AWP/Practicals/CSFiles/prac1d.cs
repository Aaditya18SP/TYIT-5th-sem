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


//Reverse Number
public void reverseNumber(int number){
int r , reverse_num=0,entered_num;
entered_num=number;

while(number!=0){
r = entered_number%10;
reverse_num = reverse_num +(r*10)
entered_num = entered_num//10;
}


}


}

class prac1d{

public static void Main(string[] args){
int input_from_user;

while(true){
Console.Write("Choose a number:\n 0. Exit\n 1. Fibonacci \n 2. Prime number \n 3. Vowels \n 4. For each with arrays \n 5. Reverse number \n 6. Find the sum of digits\n");
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
break;

case 5:
//
break;

default:
break;
}

}

}

}