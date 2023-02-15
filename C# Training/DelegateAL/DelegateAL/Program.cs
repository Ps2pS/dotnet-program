using System;
delegate void mydelegate(string i);

class mycarrier
{
    public string music()
    {
        return "no time....sorry";
    }
}

class candidate
{
    public static void Main()
    {
        mycarrier pragya = new mycarrier();
        mydelegate mylife = (string i) =>
        {
            string mess = i;
            Console.WriteLine(mess);
        };
        mylife.Invoke("I am Pragya.....");
    }
}