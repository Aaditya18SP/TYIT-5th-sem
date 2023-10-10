using System;

class person{
protected string name;
protected int age;


public person(string n, int a){
this.name=n;
this.age=a;
}

//overriding this methods
public virtual void displayDetails(){
Console.WriteLine("Name:{0}",this.name);
Console.WriteLine("Age:{0}",this.age);
}

}


class student:person{
protected int rollno;

public student(string n, int a, int r):base(n,a){
this.rollno=r;
}


public override void displayDetails(){
Console.WriteLine("Name:{0}",this.name);
Console.WriteLine("Age:{0}",this.age);
Console.WriteLine("Rollno:{0}",this.rollno);
}

}

class employee: person{
protected string post;

public employee(string n, int a, string post):base(n,a){
this.post=post;
}

public override void displayDetails(){
Console.WriteLine("Name:{0}",this.name);
Console.WriteLine("Age:{0}",this.age);
Console.WriteLine("Post:{0}",this.post);
}

}

class marks:student,sportsmarks{
protected double ngt_marks;
protected double awp_marks;

public marks(string n, int a, int r, double m):base(n,a,r){
this.ngt_marks= m;
this.awp_marks=0.0;
}

public marks(string n, int a, int r, double ngt,double awp):base(n,a,r){
this.ngt_marks= ngt;
this.awp_marks= awp;
}

public void displayMarks(bool total_yes){

if(total_yes){
Console.WriteLine("Marks in NGT:{0}",this.ngt_marks);
Console.WriteLine("Marks in AWP:{0}",this.awp_marks);
Console.WriteLine("Total marks:{0}", this.awp_marks+ this.ngt_marks);
}

}

public void displayMarks(){
Console.WriteLine("Marks in NGT:{0}",this.ngt_marks);
Console.WriteLine("Marks in AWP:{0}",this.awp_marks);

}


public override void displayDetails(){
Console.WriteLine("Name:{0}",this.name);
Console.WriteLine("Age:{0}",this.age);
Console.WriteLine("Roll no:{0}", this.rollno);
Console.WriteLine("Marks in NGT:{0}",this.ngt_marks);
Console.WriteLine("Marks in AWP:{0}",this.awp_marks);

}

//INTERFACE METHOD
public void addMarks(){
this.ngt_marks+=5;
displayMarks(true);
}


public static void Main(string[] args){
marks m1= new marks("Aaditya",20,29,50.5,55.5);
marks m2= new marks("Rushi",20,47,49.0,50.0);

employee e1= new employee("Anushka", 20,"SDE");

Console.WriteLine("\nMarks of m1");
m1.displayMarks();

Console.WriteLine("\nTotal Marks of m1");
m1.displayMarks(true);

Console.WriteLine("\nMarks of m1 after adding marks" );
m1.addMarks();

Console.WriteLine("\nDetails of m1");
m1.displayDetails();

Console.WriteLine("\nAccessing details of m2");
Console.WriteLine("Acessing name:{0}",m2.name);
Console.WriteLine("Accessing roll no:{0}",m2.rollno);

Console.WriteLine("\nEmployee details of e1");
e1.displayDetails();

}

}

public interface sportsmarks{

 void addMarks();

}
