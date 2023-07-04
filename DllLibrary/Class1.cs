using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DllLibrary
{
    public class Driver
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public List<Auto> autos = new List<Auto>();

        public Driver(string name, string class)
        {
            Name = name:
            Class = class;
    }

    public void ShowAll()
    {
        Console.WriteLine("Данные о водителе:\n +" +
            $"\tИмя: {Name}\n +" +
            $"\tКвалификация: {Class}\n\n" +
            "Список автомобилей:");

        autos.Sort();
        foreach (Auto auto in autos)
        {
            auto.Show();
        }
    }

    public class Auto
    {
    public string Title { get; set; }

    }

}
