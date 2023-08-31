using System;
 class prac1b{


public static void Main(string [] args){

string brand, car,fullname;

Console.Write("Enter the brand:");
brand=Console.ReadLine();

Console.Write(" Enter the model:");
car=Console.ReadLine();

//concatenate

fullname=String.Concat(brand," ",car);

Console.WriteLine("Your car : {0} ", fullname); 

//Uppercase
Console.WriteLine("In Upper Case : {0} ", fullname.ToUpper()); 

//Lowercase
Console.WriteLine("Lower Case : {0} ", fullname.ToLower()); 

//replace (toreplace,replacewith)
Console.WriteLine("Replaced String: {0}", fullname.Replace(" ","$"));


//find the index of letter 'e' 
Console.WriteLine("Index of letter e: {0} ", fullname.IndexOf("e"));  
int indexToRemove= fullname.IndexOf("e");

//remove only letter e 
//remove( startindex, length)

if(indexToRemove >-1){
Console.WriteLine("Removed the letter e: {0} ", fullname.Remove(indexToRemove,1));
}


//PADDING 
 //PadLeft(noOfCharactersRequiredInString, char)
Console.WriteLine("Padding from the left with _ : {0}", fullname.PadLeft(20 ,'_'));

Console.WriteLine("Padding from the right with _ : {0}",  fullname.PadRight(20 ,'_'));

Console.WriteLine("Padding from the right with _ : {0}", (fullname.PadLeft(20 ,'_')).PadRight(40 ,'_'));

string paddedString=(fullname.PadLeft(20 ,'_')).PadRight(40 ,'_');

//TRIM
char[] ch ={'_'};
Console.WriteLine("Trim the _ from start: {0} ", paddedString.TrimStart(ch)); 

Console.WriteLine("Trim the _ from end : {0} ", paddedString.TrimEnd(ch)); 

Console.WriteLine("Trim the _ from both ends: {0} ", (paddedString.TrimStart(ch)). TrimEnd(ch)); 


//SPLIT
//split the string when a particular character appears, and stores in the array.

string [] splittedString;
splittedString = fullname.Split(' ');
Console.WriteLine("Split at whitespace: {0} {1}", splittedString[0],splittedString[1] );



//SUBSTRING

//substring (startindex, endindex);
Console.WriteLine("A substring :{0} ", fullname.Substring(2,7));


//STARSWITH AND ENDSWITH
Console.WriteLine("does it start with p: {0}", fullname.StartsWith("p"));

Console.WriteLine("does it end with e: {0}", fullname.EndsWith("e"));

//INSERT
Console.WriteLine("Inserting a string at specified index: {0}", fullname.Insert(0,"991.2 !  "));

// CONTAINS
Console.WriteLine("Does it contain a specified string: {0}", fullname.Contains("car"));

//COMPARE
Console.WriteLine("Comparison result after comparing two strings: {0} " ,String.Compare("abcdeff",brand)); 

//if equal then 0, if s1>s2 then 1, if s1<s2 then -1

//EQUALS
Console.WriteLine("Is it equal to specified string :{0} ", fullname.Equals("car"));

//JOIN 
string[] array= {"these","are", "separate","words","to","be","joined"};
Console.WriteLine("joined string:{0}", String.Join("-",array));
}
}