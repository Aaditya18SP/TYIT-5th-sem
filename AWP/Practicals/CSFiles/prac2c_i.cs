using System;
public delegate void brakeEventDelegate();

namespace prac2c_nm{
    
public class car{
 public event brakeEventDelegate onBrake;
 
 public void displayTaillamps(){
    Console.WriteLine("Displaying Tail Lamps in Red");
 }

 public void decelerate(){
    Console.WriteLine("Reducing Speed...");
    onBrake();
 }
}

public class prac2c_exec{
    public void anotherFunction(){
Console.WriteLine("Just another function");

    }
    public static void Main(string[] args){

prac2c_exec obj=new prac2c_exec();
        //connect the event to the functions
car alto=new car();
alto.onBrake += alto.displayTaillamps;
//alto.onBrake += obj.anotherFunction(); //attaching and multicasting the delegates;

//calling the function to trigger the event
alto.decelerate();

    }

}


}

/*
OUTPUT:
Reducing Speed...
Displaying Tail Lamps in Red

*/