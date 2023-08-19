using System;
using System.Collections;
using System.Collections.Generic;


class example {
  
    // Driver code
    public static void Main()
    {

ArrayList arlist = new ArrayList(); 
//var arlist = new ArrayList(); 
var arlist1 = new ArrayList();
arlist1.Add(1);
arlist1.Add("Bill");
arlist1.Add(" ");
arlist1.Add(true);
arlist1.Add(4.5);
arlist1.Add(null);
/*  
var arlist2 = new ArrayList()
                {
                    2, "Steve", " ", true, 4.5, null
                };
*/

Console.Write( "\n\nn\n\nCapacity  : " + arlist1.Capacity ); 
foreach (var item in arlist1)
    Console.Write( "\n  " +item + ", "); 
}

}