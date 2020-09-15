using System;
using System.IO;
using static System.Console;


class Program
{
    public static void find(string key)
    {
        try
        {
            // Open the text file using a stream reader.
            using (var sr = new StreamReader(@"C:\Users\Admin\Desktop\19521542_Pham_Duc_Hoang\Meterial\GV.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {

                    if(line.IndexOf(key)!=-1)
                    {
                        WriteLine(line);
                    }
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }

        try
        {
            // Open the text file using a stream reader.
            using (var sr = new StreamReader(@"C:\Users\Admin\Desktop\19521542_Pham_Duc_Hoang\Meterial\SV.txt"))
            {
                string line1;
                while ((line1 = sr.ReadLine()) != null)
                {

                    if(line1.IndexOf(key)!=-1)
                    {
                        WriteLine(line1);
                    }
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }
   
    public static void add(string type , string infor)
    {
        if (type =="1")
        {
            File.AppendAllText(@"C:\Users\Admin\Desktop\19521542_Pham_Duc_Hoang\Meterial\GV.txt",  infor + Environment.NewLine);
        }
        if(type =="2")
        {
            File.AppendAllText(@"C:\Users\Admin\Desktop\19521542_Pham_Duc_Hoang\Meterial\SV.txt",  infor + Environment.NewLine);
        }
    }
    public static void top(string NumberString)
    {

        if (Int32.TryParse(NumberString, out int numValue))
        {
            // Console.WriteLine(NumberString);
        }
        else
        {
            Console.WriteLine($"Int32.TryParse could not parse '{NumberString}' to an int.");
            return;
        }
        while (numValue > 0)
        {
            using (var sr = new StreamReader(@"C:\Users\Admin\Desktop\19521542_Pham_Duc_Hoang\Meterial\SV.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    String[] spearator = { "_ID: ", " _Name: "," _DToan: "," _DVan: " }; 
                    String[] strlist = line.Split(spearator, StringSplitOptions.RemoveEmptyEntries);
                    foreach(var i in strlist)
                    {
                        WriteLine(i);
                    }
                }
            }
            numValue-=1;
        }
    }
   
    public static void Main(string[] args)

    {
    //    if(args.Length==2&&args[0]=="find")
    //    {
    //        find(args[1]);
    //    }
    //    if(args.Length ==3 &&args[0] =="add")
    //    {
    //        add(args[1],args[2]);
    //    }
        top("2");
    }
    
}