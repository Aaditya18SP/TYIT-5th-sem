using System;
using System.Collections; 
using System.Collections.Generic; 

class Student{
public string fullname,course;
public int id;
public DateTime dob;

public Student(int id,string fullname, string course,string dob){
this.id=id;
this.fullname=fullname;
this.course=course;
this.dob=DateTime.Parse(dob);

}

}

class prac1c{

public ArrayList students_arraylist =new ArrayList();

public void receiveInfo(){
int id;
string fn,c,dob;

Console.Write("\nNEW STUDENT\n");
Console.Write("Enter id:");
id=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter fullname:");
fn=Console.ReadLine();
Console.Write("Enter course:");
c=Console.ReadLine();
Console.Write("Enter DOB:");
dob=Console.ReadLine();

students_arraylist.Add(new Student(id,fn,c,dob));

}


public void displayInfo(){
int i=1;
foreach( Student student in students_arraylist){

Console.WriteLine("\nStudent {0}\n",i);
i++;

Console.WriteLine("ID:{0}" ,student.id);
Console.WriteLine("Fullname:{0}" ,student.fullname);
Console.WriteLine("Course:{0}" ,student.course);
Console.WriteLine("Date of birth:{0}" ,student.dob.ToString("d")); //d - stands for short date .eg:18-06-2023 is a short date

}
}


public static void Main(string[] args){

prac1c obj =new prac1c();
int total_students;
Console.Write("Enter total number of students whose data needs to be inserted:");
total_students=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nReading info\n");
for(int i=0;i<total_students;i++){
obj.receiveInfo();
}

Console.WriteLine("\nDisplaying info\n");

obj.displayInfo();

}
}

/*OUTPUT
Enter total number of students whose data needs to be inserted:2

Reading info


NEW STUDENT
Enter id:1001
Enter fullname:Aaditya
Enter course:BSCIT
Enter DOB:18/08/2003

NEW STUDENT
Enter id:1002
Enter fullname:Rushya
Enter course:BSCBT
Enter DOB:27/03/2003

Displaying info


Student 1

ID:1001
Fullname:Aaditya
Course:BSCIT
Date of birth:18-08-2003

Student 2

ID:1002
Fullname:Rushya
Course:BSCBT
Date of birth:27-03-2003



*/