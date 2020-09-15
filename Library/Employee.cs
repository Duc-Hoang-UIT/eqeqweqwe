using System;
using System.IO;
using static System.Console;
namespace Library.Shared
{
    public class Employee : Person,IComparable<Employee>
    {
        public string Specialist { get; set; }
        public override void WriteInforToConsole()
        {
            base.WriteInforToConsole();
            Write($"Specialist: {this.Specialist} ");
        }
        public override  string GetInfo()
        {
            string infor = default(string);
            infor = $"ID: {this.ID} Name: {this.Name} Specialist: {this.Specialist}";
            return infor;
        }
        public override  void WriteInforToFile(string path =@"C:\Users\Admin\Desktop\19521542_Pham_Duc_Hoang\Meterial\GV.txt" )
        {
            
            File.AppendAllText(path, this.GetInfo() + Environment.NewLine);
    
        }
        public Employee(string id , string name , string specialist)
        {
            this.ID = id;
            this.Name = name;
            this.Specialist = specialist;
        }
        public int CompareTo(Employee other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}