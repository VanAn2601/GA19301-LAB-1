using System;
using System.Data;

public class Maps
{ 
    public string ID;
    public  string Name;
    public static string InGame = "Lien Minh Huyen Thoai";

    public Maps(string ID, string Name)
    {
        this .ID = ID;
        this .Name = Name;
    }

    public string ShowData()
    {
        return "ID: " + ID + "|Name: " + Name + "|InGame: " + InGame; 
    }  
}
public class Program
{
    public static int Main(string[] args)
    {
        Maps maps = new Maps("2024", "URF");
        Console.WriteLine(maps.ShowData);
        return 0;
    }
}