using System;
class prac2b
{
    /*
        public prac2b(string message)
        {
            Console.WriteLine("The message from overloaded constructor is:{0}", message);
        }

        public prac2b(string message, DateTime dateTime)
        {
            Console.WriteLine("The message is:{0}, The current date is:{1}", message, dateTime);
        }

        public void displayDate()
        {
            Console.WriteLine("The current UTCdate is:{0}", DateTime.UtcNow);
        }

        public void displayDate(string strDate)
        {
            DateTime dt = DateTime.Parse(strDate);
            Console.WriteLine("The entered date is:{0}", dt);
        }
    */
}


class vehicle
{
    public string name;
    public string brand;
    public float price;
    public string type;
    public string model_date;

    public vehicle(string n, string b, float p, string t, string md)
    {
        this.name = n;
        this.brand = b;
        this.price = p;
        this.type = t;
        this.model_date = md;
    }


}
class engine : vehicle
{
    public int cyclinders;
    public string cyclinder_arrangement;
    public string valves_per_cyclinder;
    public double engine_capacity; //eg:2.5L

    public engine(string name, int cyc, string cyc_arr, string val_p_cyc, double capac)
    {
        this.name = name;
        this.cyclinders = cyc;
        this.cyclinder_arrangement = cyc_arr;
        this.valves_per_cyclinder = val_p_cyc;
        this.engine_capacity = engine_capacity;

    }



}
class interior : engine
{
    public string material;
    public bool android_auto;
    public bool apple_car_play;
    public bool sunroof;

    public interior(string name, int cyclinders, string cyc_arr, string mat, bool aa, bool acp, bool sf)
    {
        this.name = name;
        this.cyclinders = cyclinders;
        this.cyclinder_arrangement = cyc_arr;
        this.material = mat;
        this.android_auto = aa;
        this.apple_car_play = acp;
        this.sunroof = sf;
    }

}

class racecar : vehicle
{

    public int no_races_won;
    public bool homologated_for_road;
    public string race_class;

    public racecar(int nrw, bool hfr, string rc)
    {
        this.no_races_won = nrw;
        this.homologated_for_road = hfr;
        this.race_class = rc;

    }

    public racecar(string name, string brand, float price, string type, string model_date, int nrw, bool hfr, string rc)
    {
        this.name = name;
        this.brand = brand;
        this.price = price;
        this.type = type;
        this.model_date = model_date;
        this.racecar = rc;
        this.no_races_won = nrw;
    }

    public void getDetails()
    {
        Console.WriteLine("No of races won: {0} \n Race class:{1} \n Type:{2} \n Name:{4} \n Brand:{4}", this.no_races_won, this.race_class, this.type, this.name, this.brand);

    }

    public void getDetails(int f)
    {
        if (f == 1)
        {
            Console.WriteLine("No of races won: {0} ", this.no_races_won);

        }

    }

}

interface onInheritanceCompleted
{
    void onInherited();
}

class prac2b_execution
{
    public static void Main(string[] args)
    {
        int user_choice;

        racecar pagani_huyara = new racecar("Huyara R", "Pagani", 5000000, "car", "2022", 5, false, "None");
        racecar zonda_r = new racecar(5, false, "None"); //constructor overloading
        interior of_ferrari_fxxk = new interior("Ferrari FXXK", 12, "V", "carbon", false, false, false);

        pagani_huyara.getDetails();
        pagani_huyara.getDetails(1); //function overloading
        Console.WriteLine("The Car Name is :{0}", of_ferrari_fxxk.name); // multilevel inheritance
        Console.WriteLine("The Race Car Name is :{0}", pagani_huyara.name); //single/hybrid inheritance


        /*
                Console.WriteLine("\niii.Overloading Constructors:-\n ");
                //prac2b obj=new prac2b();
                prac2b obj1 = new prac2b("Hello this is a message");
                prac2b obj2 = new prac2b("Message 2", DateTime.Now);

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