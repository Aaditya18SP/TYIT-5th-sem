using System;
using System.Collections; 
using System.Collections.Generic; 

class Student{
public string rollno, firstname,lastname;
public int age;

public Student(string fn, string ln, string rn, int age){
this.rollno=rn;
this.firstname=fn;
this.lastname=ln;
this.age=age;

}

public void setRollno(string rollno){
this.rollno=rollno;
}

public void setFullname(string fn){
this.firstname=fn;
}

public void setLastname(string ln){
this.lastname=ln;
}

public void setAge(int age){
this.age=age;
}




}

class prac1c{

public ArrayList students_arraylist =new ArrayList();

public void receiveInfo(){
int age;
String fn,ln,rn;

Console.Write("\nNEW STUDENT\n");
Console.Write("Enter firstname:");
fn=Console.ReadLine();
Console.Write("Enter lastname:");
ln=Console.ReadLine();
Console.Write("Enter roll no:");
rn=Console.ReadLine();
Console.Write("Enter age:");
age=Convert.ToInt32(Console.ReadLine());

students_arraylist.Add(new Student(fn,ln,rn,age));

}


public void displayInfo(){
int i=1;
foreach( Student student in students_arraylist){

Console.WriteLine("\nStudent {0}\n",i);
i++;

Console.WriteLine("Firstname:{0}" ,student.firstname);
Console.WriteLine("Lastname:{0}" ,student.lastname);
Console.WriteLine("Age:{0}" ,student.age);
Console.WriteLine("Roll no:{0}" ,student.rollno);

}
}


public static void Main(string[] args){

prac1c obj =new prac1c();
int total_students;
Console.Write("Enter total number of students:");
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
Enter total number of students:2

Reading info


NEW STUDENT
Enter firstname:aaditya
Enter lastname:pal
Enter roll no:a029
Enter age:20

NEW STUDENT
Enter firstname:rushya
Enter lastname:shinde
Enter roll no:a047
Enter age:21

Displaying info


Student 1

Firstname:aaditya
Lastname:pal
Age:20
Roll no:a029

Student 2

Firstname:rushya
Lastname:shinde
Age:21
Roll no:a047



*/