using System;
using System.IO;
using System.Threading;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[15];
            string[] manufacturers = { "audi", "chevrolet", "dodge", "ford", "honda", "hyundai" };
            string[] models = { "a4", "malibu", "civic", "4wd", "gti", "awd" };
            string s = String.Format("{0,-15} {1,6} {2,15} {3,20} {4,14}", "Производитель", "Модель", "Объем двигателя", "Количество цилиндров", "Расход топлива");
            Console.WriteLine(s);

            for (int i = 0; i < cars.Length; i++)
            {
                Thread.Sleep(i + 10);
                cars[i] = new Car();
                cars[i].FillFields(manufacturers, models);
                Console.WriteLine(cars[i].Info());
            }

            Console.WriteLine("\n------Сортировка по производителю-----\n");
            Console.WriteLine(s);
            Car.SortString(cars, "manufacturer");
            for (int i = 0; i < cars.Length; i++)
                Console.WriteLine(cars[i].Info());

            Console.WriteLine("\n------Сортировка по модели-----\n");
            Console.WriteLine(s);
            Car.SortString(cars, "model");
            for (int i = 0; i < cars.Length; i++)
                Console.WriteLine(cars[i].Info());

            Console.WriteLine("\n------Сортировка по объему двигателя-----\n");
            Console.WriteLine(s);
            Car.SortDouble(cars, "displacement");
            for (int i = 0; i < cars.Length; i++)
                Console.WriteLine(cars[i].Info());

            Console.WriteLine("\n------Сортировка по количеству цилиндров-----\n");
            Console.WriteLine(s);
            Car.SortInt(cars, "cylinders");
            for (int i = 0; i < cars.Length; i++)
                Console.WriteLine(cars[i].Info());

            Console.WriteLine("\n------Сортировка по расходу топлива-----\n");
            Console.WriteLine(s);
            Car.SortInt(cars, "mpg");
            for (int i = 0; i < cars.Length; i++)
                Console.WriteLine(cars[i].Info());

            try
            {
                string path = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, "Cars.txt")))
                {
                    foreach (Car car in cars)
                        car.WriteToFile(outputFile);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Не удалось выполнить операцию: {0}", e.ToString());
            }
        }
    };

    class Car
    {
        public string manufacturer;
        public string model;
        public double displacement;
        public int cylinders;
        public int mpg;

        public string Info()
        {
            return String.Format("{0,-15} {1,6} {2,15} {3,20} {4,14}", manufacturer, model, displacement, cylinders, mpg);
        }

        public void FillFields(string[] manufacturers, string[] models)
        {
            Random rnd = new Random();
            manufacturer = manufacturers[rnd.Next(manufacturers.Length)];
            model = models[rnd.Next(models.Length)];
            displacement = Math.Round(rnd.NextDouble() + rnd.Next(1, 10), 1);
            cylinders = rnd.Next(4, 8);
            mpg = rnd.Next(1, 50);
        }
        public void WriteToFile(StreamWriter outputFile)
        {
            outputFile.WriteLine("{0} {1} {2} {3} {4}", manufacturer, model, displacement, cylinders, mpg);
        }
        public T GetAttribute<T>(string _name)
        {
            return (T)typeof(Car).GetField(_name).GetValue(this);
        }
        public static void SortInt(Car[] cars, string attr)
        {
            for (var i = 1; i < cars.Length; i++)
            {
                var key = cars[i];
                var j = i;
                while (j > 0 && cars[j - 1].GetAttribute<int>(attr) > key.GetAttribute<int>(attr))
                {
                    Swap(cars, j - 1, j);
                    j--;
                }
                cars[j] = key;
            }
        }

        public static void SortDouble(Car[] cars, string attr)
        {
            for (var i = 1; i < cars.Length; i++)
            {
                var key = cars[i];
                var j = i;
                while (j > 0 && cars[j - 1].GetAttribute<double>(attr) > key.GetAttribute<double>(attr))
                {
                    Swap(cars, j - 1, j);
                    j--;
                }
                cars[j] = key;
            }
        }

        public static void SortString(Car[] cars, string attr)
        {
            for (var i = 1; i < cars.Length; i++)
            {
                var key = cars[i];
                var j = i;
                while (j > 0 && cars[j - 1].GetAttribute<string>(attr).CompareTo(key.GetAttribute<string>(attr)) > 0)
                {
                    Swap(cars, j - 1, j);
                    j--;
                }
                cars[j] = key;
            }
        }

        static void Swap(Car[] array, int i, int j)
        {
            Car temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
