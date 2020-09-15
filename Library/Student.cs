using System;
using System.IO;
using static System.Console;
namespace Library.Shared
{
    public class Student : Person
    {
        public float DiemToan { get; set; }
        public float DiemVan { get; set; }
        public override void WriteInforToConsole()
        {
            base.WriteInforToConsole();
            Write($"Diem Toan: {this.DiemToan} Diem Van: {this.DiemVan} ");
        }
        public override  void WriteInforToFile(string path =@"C:\Users\Admin\Desktop\19521542_Pham_Duc_Hoang\Meterial\SV.txt")
        {
            File.AppendAllText(path, this.GetInfo() + Environment.NewLine);
        }
        public  override  string GetInfo()
        {
            string infor = default(string);
            infor = $"ID: {this.ID} Name: {this.Name} DiemToan: {this.DiemToan} DiemVan: {this.DiemVan} ";
            return infor;
        }
        public Student(string id , string name , float diemtoan , float diemvan)
        {
            this.ID = id;
            this.Name = name;
            this.DiemToan = diemtoan;
            this.DiemVan = diemvan;
        }




    }
}