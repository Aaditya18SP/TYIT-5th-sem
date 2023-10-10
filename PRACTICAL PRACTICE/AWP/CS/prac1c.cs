using System;
using System.Collections.Generic;
using System.Collections;

class Student
{
public string name;
public string rollno;
public int age;
}

class prac1c{

public ArrayList all_students=new ArrayList();

public static void Main(string[] args){

prac1c obj=new prac1c();
Console.Write("Enter number of students:");
int no_of_students= Convert.ToInt32(Console.ReadLine());

for (int i=0; i< no_of_students;i++){

Student s1=new Student();
Console.WriteLine("\nEnter details for student {0}",i+1);

Console.Write("Enter name:");
s1.name= Console.ReadLine();

Console.Write("Enter roll no:");
s1.rollno= Console.ReadLine();

Console.Write("Enter age:");
s1.age= Convert.ToInt32(Console.ReadLine());
obj.all_students.Add(s1);

}

Console.WriteLine("Displaying all students data\n");

foreach(Student stu in obj.all_students){
Console.WriteLine("Student {0}", obj.all_students.IndexOf(stu)+1);
Console.WriteLine("Name {0}", stu.name);
Console.WriteLine("Rollno {0}", stu.rollno);
Console.WriteLine("Age {0}", stu.age);
}


}

}