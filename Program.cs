using System;

namespace Nullable_Types__c_sharp
{      //it is used to allow null to value type variables
       //  Nullable<T> type allows assignment of null to value types.
       //? operator is a shorthand syntax for Nullable types.
       // HasValue property to check whether value is assigned to nullable type or not.

    class Demo
    {
        public Nullable<int> i;
    }

    class Program
    {
        static void Main()
        {
            //---------------------------------------------------------------

            Demo d = new Demo();
            if (d.i == null)
            {
                Console.WriteLine("null");
            }


            //---------------------------------------------------------------
            //HasValue
            //syntax = Nullable<int> i = null;

            Nullable<int> i = null;
            if (i.HasValue)      //The HasValue returns true if the object has been assigned a value;
                Console.WriteLine(i.Value);
            else
                Console.WriteLine("null");
            //---------------------------------------------------------------
            //using ?
            int? j = null;        //giving null value to variable
            int k = 10;

            if (j > k)
            {
                Console.WriteLine("one");
            }
            else if (j > 10)
            {
                Console.WriteLine("two");
            }
            else
            {
                Console.WriteLine("three");
            }

            //--------------------------------------------
            //Dynamic Type
            //A dynamic type escapes type checking at compile-time;x
            //instead, it resolves type at run time.
            dynamic dc = 1;
            Console.WriteLine(dc);          //1
            Console.WriteLine(dc.GetType());      //which type i.e. System.Int32
            //------------------------------------------------
            //dynamic type conversion
            dynamic d1 = 100;
            int l = d1; //is int type

            //convert it to string
            d1 = "roshi";
            string s = d1;
            Console.WriteLine(s);

            //-------------------------------------------------
            //dynamic methods and paramters
            //using class Employee
            dynamic ey = new Employee();
            ey.Dis(20);

            //----------------------------------------------------
            //var- anonymous data types
            //contain only read only properties
            var stu = new { name = "kisha", age = 20 };
            Console.WriteLine(stu.name);
            //applying var now the value cannot be changed

            //----------------------------------------------------
            //Enum
            //it is used to assign constant name to integer value
            //it is used to make value more readable

            //----------------------------------------------------
            //struct
            // is the value type data type that represents data structures. 

            //using class Femo
            Femo f = new Femo();
            Console.WriteLine(f.x);
            Console.WriteLine(f.y);

            //-------------------------------------------------------
            //using methods and properties in struct

            //using class gemo
            gemo g = new gemo();    //object instantiation
            g.meth();    //calling
            Console.WriteLine(g.x);     //printing
            Console.WriteLine(g.y);

            //--------------------------------------------------

            //datetime
            DateTime dt = new DateTime();

            //assign year month day
            DateTime dt2 = new DateTime(2020, 08, 21);
            Console.WriteLine(dt2);
            /*output = 21-08-2020 00:00:00*/
            //-------------------------------------------------
            //static fields in date time
            DateTime current_date = DateTime.Now;
            DateTime today_date = DateTime.Today;
            DateTime utc = DateTime.UtcNow;

            Console.WriteLine(current_date);
            Console.WriteLine(today_date);
            Console.WriteLine(utc);

            //-------------------------------------------------
            //time span
            //is used to represent time in days,hours,minutes
            DateTime dt4 = new DateTime();
            TimeSpan ts = new TimeSpan(30, 24, 60);
            Console.WriteLine(dt4);
            Console.WriteLine(ts);

            //-------------------------------------------------
            //convert datetime to string
            //ToString =convert date time value to string
            //ToShortDateString  = convert datetime to (M/d/yyyy) pattern
            //ToShortTimeString = convert datetime to (h:mm:ss) pattern
            //ToLongDateString= convert datetime to all datestring (dddd, MMMM d, yyyy pattern)
            //ToLongTimeString =Converts a DateTime value to a long time string (h:mm:ss tt pattern) 

            var dt5 = DateTime.Now;
            Console.WriteLine("date string"+ dt5.ToString("d"));
            Console.WriteLine("MM/dd/yyyy Format: " + dt5.ToString("MM/dd/yyyy"));
            Console.WriteLine(":" + dt.ToString("MM/dd/yyyy"));
            Console.WriteLine("short" + dt5.ToShortDateString()); //short14-06-2021
            Console.WriteLine("long" + dt5.ToLongDateString());  //long14 June 2021
            Console.WriteLine("long time string" + dt5.ToLongTimeString()); //long time string16:22:12


            //---------------------------------------------------------
            //convert string to datetime
            //using parse(), parseExact(),TryParse(),TryParseExact();
           


        }
    }
}

class Employee
{
    public void Dis(int age)          //1 method with paramater
    {
        Console.WriteLine("my age");
    }
}

//using struct
struct Femo
{
    public int x;
    public int y;

}

//using methods and properties in struct
struct gemo
{
    public int x { get; set; }
    public int y { get; set; }

    public void meth()
    {

        this.x = 10;
        this.y = 20;

    }
}


