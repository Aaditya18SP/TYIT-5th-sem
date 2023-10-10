using System;

class CustomException:ApplicationException{

public CustomException():base(){}
public CustomException(string message):base(message){}
public CustomException(string message, Exception e):base(message,e){}

}


class prac2c{


public static void Main(string[] args){

int a=10,b=0;

try{
int c=a/b;
}
catch(DivideByZeroException err){
Console.WriteLine("Zero Division error caught:{0}", err.Message);
Console.WriteLine("Stack Trace:{0}", err.StackTrace);
Console.WriteLine("Source:{0}", err.Source);
}

finally{


try{
//THROW A CUSTOM EXCEPTION
if(b==0){
DivideByZeroException derr=new DivideByZeroException();
CustomException err= new CustomException("messssaaaaaaaage", derr);
throw err;
}
else{
int c= a/b;
}

}catch(CustomException e){
Console.WriteLine("Caught the custom exception:{0}",e.Message);

}

}




}

}