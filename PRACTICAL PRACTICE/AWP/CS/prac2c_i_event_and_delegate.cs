using System;
public delegate void operationPerformedHandler();

class operation{

public event operationPerformedHandler operationEvent;

public int result;

public void add(int x, int y){
result=x+y;
operationEvent();
}

public void subtract(int x,int y){
result=x-y;
operationEvent();
}

public void displayOperationResult(){
Console.WriteLine("Result is:{0}",result);
}


}

class prac2c{
public static void Main(string[] args){

operation obj= new operation();

//Connect the event and the methods to be executed 
obj.operationEvent += obj.displayOperationResult;

//trigger the event
obj.add(10,20);
obj.subtract(20,10);



}


}

/*
OUTPUT
Result is:30
Result is:10


*/