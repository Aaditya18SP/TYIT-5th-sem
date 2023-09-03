using System;
class prac2b{

public prac2b(string message){
    Console.WriteLine("The message from overloaded constructor is:{0}",message);
}

public prac2b(string message, DateTime dateTime){
    Console.WriteLine("The message is:{0}, The current date is:{1}",message,dateTime);
}

public void displayDate(){
Console.WriteLine("The current UTCdate is:{0}",DateTime.UtcNow);
}

public void displayDate(string strDate){
   DateTime dt = DateTime.Parse(strDate);
    Console.WriteLine("The entered date is:{0}",dt);
}

}

class car{
    

}
class engine:car{

}
class interior:engine{

}

interface onInheritanceCompleted{
     void onInherited();
}

class prac2b_execution{
    public static void Main(string[] args){
         int user_choice;


         Console.WriteLine("\niii.Overloading Constructors:-\n ");
        //prac2b obj=new prac2b();
         prac2b obj1=new prac2b("Hello this is a message");
          prac2b obj2=new prac2b("Message 2",DateTime.Now);
          
Console.WriteLine("\ni.Overloading Functions:-\n ");
          obj1.displayDate();
          //obj1.displayDate("Fri Aug 18, 2023"); //the date has to be correct
obj1.displayDate("18/08/2023");

Console.WriteLine("\nii.Inheritance(All types):-\n ");


Console.WriteLine("\niv.Interfaces:-\n ");
        /*
        while(true){
            Console.Write("1.Find Factorial \n 2.Convert Fahrenheit to Celsius \n 3.Convert Celsius to Fahrenheit \n 4.Convert Dollars to Rupees \n 5.Convert Rupees to Dollars \n 0.Exit \n Select your choice:");
            user_choice = Convert.ToInt32(Console.ReadLine());

            if(user_choice == 0){
                break;
            }
            switch(user_choice){
                case 0:
                break;
                default:
                break
            }
        }*/
    }
}