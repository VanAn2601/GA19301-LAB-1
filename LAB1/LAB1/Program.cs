using System;

public static class UserData
{
    public static string ID;
    public static string UserName;
    public static string Gold;
    public static string Point;

    static UserData() 
    {
        ID = "10655";
        UserName = "Nhism";
        Gold = "0";
        Point = "0";
    }

    public static void ShowData()
    {
        Console.WriteLine("ID: " + ID);
        Console.WriteLine("UserName: "+ UserName);
    }
}
public class Program
{
    public static int Main(string[] args)
    {
        UserData.ShowData();
        return 0;
    }
}