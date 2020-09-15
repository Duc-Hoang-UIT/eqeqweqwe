using System;
using System.IO;
using static System.Console;

namespace Library.Shared
{
    public abstract class Person
    {
        public string ID { get; set; }
        public string Name { get; set; }

        public  virtual  void WriteInforToConsole()
        {
            Write("\n");
            System.Console.Write($"ID: {this.ID} Name: {this.Name} ");
        }
        public  abstract  void WriteInforToFile(string path);
        public  abstract string GetInfo();

    }

}
