using System;
using System.Collections; 
using System.Collections.Generic; 

class cars{
public string c_name, c_brand,c_engine;
public float top_speed;

public cars(String name,String brand, String engine, float top_speed){
this.c_name=name;
this.c_brand=brand;
this.c_engine=engine;
this.top_speed = top_speed;
}

public String getCname(){
return this.c_name;
}

public String getCBrand(){
return this.c_brand;
}

public String getCEngine(){
return this.c_engine;
}

public float getCTopSpeed(){
return this.top_speed;
}

}


class mainProgram{
public static void Main(String[] Args){

ArrayList all_cars_array_list = new ArrayList();

cars ferrari_458 =new cars("458 italia", "Ferrari","NA V8",211);
cars huyara =new cars("Huyara R", "Pagani","NA V12",205);
cars gt3rs=new cars("911 992 GT3RS", "Porsche","Boxster Flat Six",186);

cars laferrari =new cars("Laferrari", "Ferrari","NA V12",211);

all_cars_array_list.Add(ferrari_458);
all_cars_array_list.Add(huyara);
all_cars_array_list.Add(gt3rs);
all_cars_array_list.Add(laferrari);



//Console.WriteLine("Default program");


foreach( cars obj in all_cars_array_list){
cars retreivedCar= (cars) obj;
Console.WriteLine("The car is: " + retreivedCar.getCname());
}


//Console.WriteLine("Object added is: " + (cars)all_cars_array_list[0].c_brand);

}

}

/*
OUTPUT
The car is: 458 italia
The car is: Huyara R
The car is: 911 992 GT3RS
The car is: Laferrari

*/