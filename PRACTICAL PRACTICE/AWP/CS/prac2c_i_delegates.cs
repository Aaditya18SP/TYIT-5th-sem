using System;

public delegate int operation(int x,int y); 


class prac2c{


public int add(int x,int y){
return x+y;
}

public int subtract(int x,int y){
return x-y;

}

public static void Main(string[] args){



prac2c obj=new prac2c();

operation new_del = obj.add;
new_del+=obj.subtract;

Console.WriteLine("Ans is:{0}",new_del(12,13));
}
}