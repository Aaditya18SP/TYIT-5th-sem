using System;

class prac2a{

    public int factorial(int x){
        int f=1;
        //recursive method
        if(x == 1){
            return 1;
        }

        int result = x * factorial(x-1);
        return result;

        //non-recursive method
        /*
        for(int i=1;i<=x;i++){
            f=f*i;
        }
        return f;
        */
    }

    public double dollarsToRupees(double dollars){
        double conv_rate=82.72F;

        return conv_rate*dollars;
    }

     public double rupeesToDollars(double rupees){
        double conv_rate=82.72F;

        return rupees/conv_rate;
    }

    public double fahrenheitToCelsius(double fah){
        return (fah-32) * (5/9);
    }

    public double celsiusToFahrenheit(double cel){
        return (cel* (9/5)) +32;
    }

}

class prac2a_execution{
    public static void Main(string[] args){
        int user_choice;
        prac2a obj=new prac2a();
        while(true){
            Console.Write("1.Find Factorial \n 2.Convert Fahrenheit to Celsius \n 3.Convert Celsius to Fahrenheit \n 4.Convert Dollars to Rupees \n 5.Convert Rupees to Dollars \n 0.Exit \n Select your choice:");
            user_choice = Convert.ToInt32(Console.ReadLine());

            if(user_choice == 0){
                break;
            }
            switch(user_choice){
                case 0:
                break;

                case 1:
                Console.Write("Enter the number you want factorial of:");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The factorial is:{0}",obj.factorial(num));
                break;

                case 2:
                Console.Write("Enter the temperature in Fahrenheit:");
                double fah = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The temperature in celsius is:{0}\u00B0C",obj.fahrenheitToCelsius(fah));
                break;

                case 3:
                Console.Write("Enter the temperature in Celsius:");
                double cel = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The temperature in Fahrenheit is:{0}\u00B0F",obj.celsiusToFahrenheit(cel));
                break;

                case 4:
                Console.Write("Enter the amount in dollars:");
                double dol = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The amount in Rupees is:INR {0}",obj.dollarsToRupees(dol));
                break;

                case 5:
                Console.Write("Enter the amount in Rupees:");
                double rup = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The amount in Dollars is:${0}",obj.rupeesToDollars(rup));
                break;
                default:
                break;
            }
        }
    }
}