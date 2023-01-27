using System;
using Practise.Models;
using Practise.Service;


public class mycontroller
{
    public static void Main()
    {
        Taazaa obj = new Taazaa();
        TaazaaDetails myobj = obj.Deatils();
        Console.WriteLine(myobj.emphno + " " + myobj.empname + " " + myobj.empemail);
    }
}