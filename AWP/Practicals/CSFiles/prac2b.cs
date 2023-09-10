using System;

public class vehicle
{
    internal string brand;
    internal string model;
    internal int manu_year; 
     public vehicle(string b, string m, int manu_year) //the constructors are by default private
    {
        this.model = m;
        this.brand = b;
        this.manu_year=manu_year;
        
    }

protected internal void startVehicle(){
    Console.WriteLine("Starting the vehicle......");
}

//overridden method
public virtual void displayDetails(){
    Console.WriteLine("Brand:{0}\nModel:{1}\nYear made:{3}",brand,model,manu_year);
}

}

public class car:vehicle,Rent,AnotherInterface{ //the class implementing the interface should be public
    protected bool is_convertible;
    protected bool rented;
    private string  fuel_type;
    
    //attribute
    public string FuelType{
        get{ return fuel_type; }
        set{ fuel_type = value;}
    }

    public car(string b, string m, int manu_year,bool conv, string f_type,bool rented):base(b, m,manu_year){ //this is how the base classes constructor is called with the required parameters
        this.is_convertible=conv;
        this.FuelType=f_type;
        this.rented=rented;
        
    }
     
     protected internal void accelerate(){
        base.startVehicle();// to call the base class' method
        Console.WriteLine("Accerelating..........");
     }

     protected internal void accelerate(int speed){
        base.startVehicle(); // to call the base class' method
        Console.WriteLine("Accelerating upto: {0} mph",speed);
     }

//the definition for the interface method
public void onRented(){
    Console.WriteLine("Rent status:{0}",rented);
}

//the defintion for AnotherInterface method 
public void anotherFunc(){
    Console.WriteLine("Implemented from AnotherInterface");
}
    public override void displayDetails()
    {
        Console.WriteLine("For Car:\nBrand:{0}\nModel:{1}\nFuelType:{2}\nIs convertible:{3}",brand,model,FuelType,is_convertible);
        //the base class variables are accessed directly ,eg:brand, model
        //the attribute can also be accessed directly eg:FuelType

        //call to the interface method
        onRented();
        //base.displayDetails();
    }
}


public class bike:vehicle{
private int engine_size;
public int EngineSize{ //this is an attribute
    get{
        return engine_size;
    }
    set{
        engine_size=value;
    }
}

 protected bool has_side_car; //protected

public bike(string b, string m, int manu_year,bool sidecar, int e_size):base(b,m,manu_year){
this.EngineSize=e_size;
this.has_side_car=sidecar;
}

protected void wheelie(){
    Console.WriteLine("Performing Wheelie.....");
}

    public override void displayDetails()
    {
        Console.WriteLine("For Bike:\nBrand:{0}\nModel:{1}\nEngine Size:{2} cc\nHas side car:{3}",brand,model,EngineSize,has_side_car);
        
    }

}

public class racecar:car{

protected string race_class;
protected float top_speed;
 public racecar(string b, string m, int manu_year,bool conv, string f_type,bool rented,string rc):base(b,m, manu_year,conv,f_type,rented){
    this.race_class=rc;
 }

 public racecar(string b, string m, int manu_year,bool conv, string f_type,bool rented,string rc, float ts):base(b,m, manu_year,conv,f_type,rented){
    this.race_class=rc;
    this.top_speed=ts;
 }

 protected internal void prepareForRace(){
    Console.WriteLine("Preparing for race...\n Checking electronics and sensors...\n Checking Tyres pressures and fuel levels\n All good\n I am speed!!!");
 }

 public override void displayDetails(){
    Console.WriteLine("\nFor RACE CAR:\nBrand:{0}\nModel:{1}\nModel Year:{2}\nFuelType:{3}\nIs convertible:{4}\nRace Class:{5}\nTop Speed:{6} mph",brand,model,manu_year,FuelType,is_convertible,race_class,top_speed);
 }

}

public interface Rent
{
    //bool on_rent; //Interface cant contains fiels but can contain properties which are declared again in the class in which the interface is implemented
    void onRented(); // has to be public
}

public interface AnotherInterface{
    void anotherFunc();

}
public class prac2b
{
    public static void Main(string[] args)
    {
        //multilevel 
        racecar fxxk = new racecar("Ferrari","FXXK Evo",2018,false,"petrol",false,"none",221.3F);
        fxxk.displayDetails(); //overridden method
        fxxk.prepareForRace();
        fxxk.startVehicle();
        fxxk.accelerate(); //method overloading
        fxxk.accelerate(100); //method overloading
        Console.WriteLine("The vehicle was manufactured in year :{0}", fxxk.manu_year);

        //constructor overloading

        racecar zonda_r =new racecar("Pagani","Zonda R",2014,false,"race fuel",false,"none",220);
        racecar gr_yaris=new racecar("Toyota","GR Yaris Rally",2020,false,"petrol",false,"WRC");

        zonda_r.displayDetails();
        gr_yaris.displayDetails();
        
        //heirarchical and single inheritance

        car alto= new car("Suzuki","Alto",2021,false,"CNG",false);
        bike pulsar =new bike("Bajaj","Pulsar NS 200",2019,false,200);
        pulsar.displayDetails();
        //Console.WriteLine("PULSAR: has side car:{0}",pulsar.has_side_car);

        Console.Write("\nALTO:");alto.startVehicle(); //startvehicle is method of parent class
        Console.Write("\nPULSAR:");pulsar.startVehicle();//startvehicle is method of parent class


        //multiple inheritance

        car creta= new car("Hyundai","Creta",2022,false,"diesel",false);
        creta.onRented();
        creta.anotherFunc();

        //hybrid inheritance

    
    }
}

/*

For RACE CAR:
Brand:Ferrari
Model:FXXK Evo
Model Year:2018
FuelType:petrol
Is convertible:False
Race Class:none
Top Speed:221.3 mph
Preparing for race...
 Checking electronics and sensors...
 Checking Tyres pressures and fuel levels
 All good
 I am speed!!!
Starting the vehicle......
Starting the vehicle......
Accerelating..........
Starting the vehicle......
Accelerating upto: 100 kmph
The vehicle was manufactured in year :2018

For RACE CAR:
Brand:Pagani
Model:Zonda R
Model Year:2014
FuelType:race fuel
Is convertible:False
Race Class:none
Top Speed:220 mph

For RACE CAR:
Brand:Toyota
Model:GR Yaris Rally
Model Year:2020
FuelType:petrol
Is convertible:False
Race Class:WRC
Top Speed:0 mph
For Bike:
Brand:Bajaj
Model:Pulsar NS 200
Engine Size:200 cc
Has side car:False

ALTO:Starting the vehicle......

PULSAR:Starting the vehicle......
Rent status:False
Implemented from AnotherInterface

*/