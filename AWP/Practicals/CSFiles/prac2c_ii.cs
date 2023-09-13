using System;
namespace prac2c_ii_nm {

public class customException:ApplicationException{

private int number;
public int Number_Attr{
    get{return number;}
    set{number=value;}
}
    public customException():base(){}
     public customException(string message):base(message){}
      public customException(string message,Exception inner):base(message,inner){}

}

class prac2c_exec_ii{
    int a,b,c;

    public int func1(){
        try{
        if(b==0){
            customException err= new customException();
            throw err;
        }
        else{
            return a/b;
        }
        }
        finally{
        Console.WriteLine("Thrown custom exception");
        }

    }


    public void func2(){
        try{
        if(b==0){
            DivideByZeroException err = new DivideByZeroException();
            throw err;
        }
        else{
            c= a/b;
        }
        }
catch( DivideByZeroException err){
 Console.WriteLine("Caught the zero division exception");
  Console.WriteLine("\nThe message is:{0}", err.Message);
            Console.WriteLine("\nThe stack trace is:{0}", err.StackTrace);
            Console.WriteLine("\nThe source is:{0}", err.Source);
}

    }
       public static void Main(string[] args){
        prac2c_exec_ii obj=new prac2c_exec_ii();

obj.a = 10;
obj.b=0;

try{
    obj.c=obj.a /obj.b;

}
catch(Exception e){
    Console.WriteLine("Cant divide by zero " + e.Message);
}

finally{
    try{
        obj.func1();
    }
    catch(customException err){
        Console.WriteLine("Caught the custom exception");
    }

    finally{
       
       obj.func2();
    }
    
}
        
    }
}


}

/*
Cant divide by zero Attempted to divide by zero.
Thrown custom exception
Caught the custom exception
Caught the zero division exception

The message is:Attempted to divide by zero.

The stack trace is:   at prac2c_ii_nm.prac2c_exec_ii.func2()

The source is:prac2c_ii


*/