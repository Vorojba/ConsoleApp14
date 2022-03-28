using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Phone
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public Phone() { }
        public Phone(string name, string model)
        {
            Name = name;
            Model = model;
        }
        public virtual void Print() =>Console.WriteLine($"Phone: Name = {Name},Model = {Model}");
    }
    internal class Mobile : Phone
    {
        string Type, Date;
        public Mobile(string Name,string Model,string type, string date) : base(Name, Model)
        {
            Type = type;
            Date = date;
        }
        public override void Print() =>Console.WriteLine($"Мобильный телефон: Название - {Name}, Модель - {Model}, Тип - {Type}, Дата - {Date}");
    }
    internal class Landline : Phone
    {
        string Number;
        public Landline(string Name, string Model, string number) : base(Name, Model)
        {
            Number = number;
        }
        public override void Print() => Console.WriteLine($"Стационарный телефон: Название - {Name}, Модель - {Model}, Номер - {Number}");
    }

}
