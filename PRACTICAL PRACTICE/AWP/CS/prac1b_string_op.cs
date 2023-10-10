using System;

class prac1b{

public static void Main(string[] args){

string sample="The quick brown fox jumps over the lazy dog";

Console.WriteLine("The string is:{0}",sample);

Console.WriteLine("The String Operations are:\n Concat,ToUpper,ToLower,Replace,IndexOf,Remove,PadLeft,PadRight,Trim,TrimStart,TrimEnd,Split,Substring, StartsWith,EndsWith,Insert,Contains,Compare,Equals,Join");

Console.WriteLine("Concatenated String:{0}",string.Concat(sample," THIS IS CONCATENATED"));

Console.WriteLine("To upper case:{0}",sample.ToUpper());
Console.WriteLine("To lower case:{0}",sample.ToLower());

Console.WriteLine("Replacing alphabet 'e' with 'I':{0}", sample.Replace("fox","cat"));

Console.WriteLine("Replacing word 'fox' with 'cat':{0}", sample.Replace("fox","cat"));

Console.WriteLine("The index of letter e is:{0}", sample.IndexOf('e'));
Console.WriteLine("The index of word fox is:{0}", sample.IndexOf("fox"));

int index_of_e= sample.IndexOf('e');

//Remove(index,length)
Console.WriteLine("Removing the letter e from the string:{0}\n{1}", sample.Remove(index_of_e,5),sample);

//PadLeft(total_characters_that_should_be_in_string_after_padding, 'char')
Console.WriteLine("Pad left with $:{0}",sample.PadLeft(50,'$'));

//PadRight(total_characters_that_should_be_in_string_after_padding, 'char')
Console.WriteLine("Pad right:{0}",sample.PadRight(50,'&'));

//Pad from both sides
Console.WriteLine("Pad from both sides:{0}", (sample.PadLeft(50,'$')).PadRight(70,'&') );
string sample2=(sample.PadLeft(50,'$')).PadRight(70,'$');

//Trim
Console.WriteLine("Trimming $ :{0}", sample2.Trim('$'));

Console.WriteLine("Trimming $ from start:{0}",sample2.TrimStart('$'));

Console.WriteLine("Trimming $ from end:{0}",sample2.TrimEnd('$'));

// Split

string[] splitted_string;
Console.WriteLine("Splitting...........");
splitted_string=sample.Split(' ');
foreach(string sttr in splitted_string){
Console.WriteLine(sttr);
}

//Substring
Console.WriteLine("Substring is:{0}", sample.Substring(1,6));

//Contains
Console.WriteLine("Is Lion word there in string:{0}",sample.Contains("Lion"));

//StartsWith 
Console.WriteLine("Does the string start with Lion? :{0}",sample.StartsWith("Lion"));

//EndsWith
Console.WriteLine("Does the string end with Lion?:{0}", sample.EndsWith("Lion"));


//Insert
Console.WriteLine("Inserting cats word at the start:{0}", sample.Insert(0,"Lion"));

//Compare
Console.WriteLine("Comparing sample and sample2:{0}",string.Compare(sample,sample2));

//Join 
Console.WriteLine("Joining various strings in an array:{0}",string.Join("---", splitted_string));

//Equals
Console.WriteLine("Is sample and sample2 equal:{0}", sample.Equals(sample2));



}

}