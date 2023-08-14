using System;
using System.Collections; 
using System.Collections.Generic; 

class cars{
public String c_name, c_brand,c_engine;
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


cars ferrari_458 =new cars("458 italia", "Ferrari","NA V8",211);
ArrayList all_cars_array_list = new ArrayList();
all_cars_array_list.Add(ferrari_458);

Console.WriteLine("Default program");

Console.WriteLine("Object added is: " +  all_cars_array_list[0].c_name);

Console.WriteLine("Object added is: " + all_cars_array_list.Count);

}

}