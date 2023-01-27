using System;


public class Taazaa
{
    public string DetailsAddress()
    {
        return "noida sector63 Address";
    }

    public int DetailsPhone()
    {
        return 123456;
    }
    public static void Main()
    {
        Taazaa obj = new Taazaa();

        string add=obj.DetailsAddress();
        Console.WriteLine(add);

        int phone = obj.DetailsPhone();
        Console.WriteLine(phone);
    }
}