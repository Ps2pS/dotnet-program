using System;
delegate void mydelegate();
//lambda ----- => 
//lambda is a short hand notation of anonymous method
//anonymous method means unnamed method --------delegate block
class mycarrier
{
    

    public string music()
    {
        return "no time...sorry";
    }
}

class candidate
{
    public static void Main(string[] args)
    {
        mycarrier pragya = new mycarrier();
        //delegate block------Anonymous method
 // mydelegate mylife = delegate ()

        //lambda operator demo
       mydelegate mylife = () =>{ 
            {string mess = "dedicate for training";Console.WriteLine(mess);} //thin operator
        };
        mylife.Invoke();

    }
}