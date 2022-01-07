using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labokvkin_Lab_13
{
    internal class Program /*internal для class по умолчанию */
    {
        public static void Main(string[] args)
        {
            //создадим список
            List<Building> buildings = new List<Building>();
            //добавление экземпляра класса в список
            Building building = new Building(70, 140, 40, "Broadway avenue");
            buildings.Add(building);
            //добавление экземпляра класса в список
            Building multiBuilding = new MultiBuilding(50, 100, 30, "Benning road", 10);
            buildings.Add(multiBuilding);
            //перебор элементов списка
            foreach (var build in buildings)
            {
                //вывод элементов списка
                build.Print();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
    //пишем родительский класс
    public class Building
    {
        //поля с автосвойствами
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public string Address { get; set; }
        public Building(double height, double width, double length, string address)
        {
            Height = height;
            Width = width;
            Length = length;
            Address = address;
        }
        public virtual void Print() /*virtual указывает,что метод может быть переопределен в производных классах*/
        {
            Console.WriteLine($"Тип здания:{GetType().Name}");
            Console.WriteLine($"Высота здания: {Height}");
            Console.WriteLine($"Ширина здания: {Width}");
            Console.WriteLine($"Длина здания: {Length}");
            Console.WriteLine($"Адрес здания: {Address}");
        }
    }
    //пишем наследуемый класс
    public sealed class MultiBuilding : Building /*от класса MultiBuilding нельзя наследоваться  */
    {
        public int Floors { get; set; }
        public MultiBuilding(double height, double width, double length, string address, int floors)
            : base(height, width, length, address)
        {
            Floors = floors;
        }
        public override void Print() /*переопределенный метод*/
        {
            base.Print();
            Console.WriteLine($"Количество этажей: {Floors}");
        }
    }

}
