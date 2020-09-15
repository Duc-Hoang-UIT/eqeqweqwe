using System;
using Library.Shared;
using static System.Console;
using System.IO;
using System.Collections.Generic;

namespace ConsoleOOP_02
{
    class Program
    {
        static bool check_valid(int type ,string value)
        {
            if(type == 1)
            {
                String[] spearator = { "ID: ", " Name: "," DiemToan: "," DiemVan: " }; 
                String[] strlist = value.Split(spearator, StringSplitOptions.RemoveEmptyEntries);
                if(strlist.Length==4) return true;
                return false;
            }
            if(type ==2)
            {
                String[] spearator = { "ID: ", " Name: "," Specialist: "}; 
                String[] strlist = value.Split(spearator, StringSplitOptions.RemoveEmptyEntries);
                if(strlist.Length==3) return true;
                return false;       
            }
            return false;
        }
        public static Student StringToStudent(string input)
        {
            String[] spearator = { "ID: ", " Name: "," DiemToan: "," DiemVan: " }; 
            String[] strlist = input.Split(spearator, StringSplitOptions.RemoveEmptyEntries);
            Student result = new Student(strlist[0],
            strlist[1],
            float.Parse(strlist[2]),
            float.Parse(strlist[3])
            );
            return result;
        }
        public static Employee StringToEmployee(string input)
        {
            String[] spearator = { "ID: ", " Name: "," Specialist: "}; 
            String[] strlist = input.Split(spearator, StringSplitOptions.RemoveEmptyEntries);
            Employee result = new Employee(strlist[0],
            strlist[1],
            strlist[2]
            );
            return result;
        }
        public static void find(string key)
        {
            try
            {
                // Open the text file using a stream reader.
                using (var sr = new StreamReader(@"C:\Users\Admin\Desktop\19521542_Pham_Duc_Hoang\Meterial\SV.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {

                        if(line.IndexOf(key)!=-1)
                        {
                            Student i = StringToStudent(line);
                            i.WriteInforToConsole();
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
                using (var sr = new StreamReader(@"C:\Users\Admin\Desktop\19521542_Pham_Duc_Hoang\Meterial\GV.txt"))
                {
                    string line1;
                    while ((line1 = sr.ReadLine()) != null)
                    {

                        if(line1.IndexOf(key)!=-1)
                        {
                        Employee i = StringToEmployee(line1);
                        i.WriteInforToConsole();
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
        public static void top (int number)
        {
            var sr = new StreamReader(@"C:\Users\Admin\Desktop\19521542_Pham_Duc_Hoang\Meterial\SV.txt");
            string line;
            List<Student> parts = new List<Student>();
            while ((line = sr.ReadLine()) != null)
            {
                Student i = StringToStudent(line);
                parts.Add(i);
            }
            parts.Sort( new NewStudentComparer());
            parts.Reverse();
            for (int i = 0 ; i < number ;i++)
            {
                parts[i].WriteInforToConsole();
            }
        }
        public static void add(int type , string value)
        {
            if (check_valid(type,value))
            {
                if(type == 1)
                {
                    Student st = StringToStudent(value);
                    st.WriteInforToFile();
                    return;
                }
                if(type==2)
                {
                    Employee ep = StringToEmployee(value);
                    ep.WriteInforToFile();
                    return;
                }
            }
            else
            {
                WriteLine("Input string is Invalid!.");
                return;
            }
        }
        public static void export(string path=@"E:")
        {

            string pathString = System.IO.Path.Combine(path,"result.txt");
            System.IO.File.Create(pathString);


            var sr = new StreamReader(@"C:\Users\Admin\Desktop\19521542_Pham_Duc_Hoang\Meterial\SV.txt");
            string line;
            List<Student> parts = new List<Student>();
            while ((line = sr.ReadLine()) != null)
            {
                Student i = StringToStudent(line);
                parts.Add(i);
            }
        
            foreach (Student item in parts)
            {
                item.WriteInforToFile(pathString);
            }

            // var sr1 = new StreamReader(@"C:\Users\Admin\Desktop\19521542_Pham_Duc_Hoang\Meterial\GV.txt");

            // List<Employee> parts1 = new List<Employee>();
            
            // while ((line = sr1.ReadLine()) != null)
            // {
            //     Employee i = StringToEmployee(line);
            //     parts1.Add(i);
            // }
            // foreach (Employee item in parts1)
            // {
            //     item.WriteInforToFile(pathString);
            // }
        }
          
        public static void Main(string[] args)
        {

            if(args.Length==2&&args[0]=="find")
            {
                find(args[1]);
            }
            if(args.Length ==2 &&args[0] =="top")
            {
                top(int.Parse(args[1]));
            }
            if(args.Length==3&&args[0]=="add")
            {
                add(int.Parse(args[1]),args[2]);
            }
            export();
        }
    
    
    }

}
