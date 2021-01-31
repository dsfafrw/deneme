using System;

namespace demo3
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car("audi", 1000);
            Car car1 = new Car();
            car1.SetName("mercedes");
            car1.SetPrice(2000);
            Car car2 = new Car("bmw", 500);
            Car car3 = new Car("mustang", 1200);
            Car[] cars = new Car[4];
            cars[0] = car;
            cars[1] = car1;
            cars[2] = car2;
            //cars[3] = car3;
            Console.WriteLine("Before Sort :");
            foreach (Car my_car in cars)
            {
                Console.WriteLine(my_car.GetName() + "  " + my_car.GetPrice());
            }
            sortByPrice(cars);
            Console.WriteLine();
            Console.WriteLine("After Sort by name :");

            foreach (Car my_car in cars)
            {
                try
                {
                    Console.WriteLine(my_car.GetName() + "  " + my_car.GetPrice());
                }catch(NullReferenceException exception)
                {
                    Console.WriteLine("Error: "+exception.Message + " Error code: "+exception.Data);
                }
                
            }
            Console.WriteLine("After Sort by name :");
            Console.WriteLine();
            sortByName(cars);
            foreach (Car my_car in cars)
            {
                Console.WriteLine(my_car.GetName() + " " + my_car.GetPrice());
            }
        }
        static Car[] sortByPrice(Car[] cars)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                for (int j = 0; j < cars.Length; j++)
                {
                    if (cars[j].GetPrice() > cars[i].GetPrice())
                    {
                        Car temp = cars[i];
                        cars[i] = cars[j];
                        cars[j] = temp;
                    }
                }
            }
            return cars;
        }
        static Car[] sortByName(Car[] cars)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                for (int j = 0; j < cars.Length; j++)
                {
                    if (cars[j].GetName().CompareTo(cars[i].GetName()) >= 0)
                    {
                        Car temp = cars[i];
                        cars[i] = cars[j];
                        cars[j] = temp;
                    }
                }
            }
            return cars;
        }
    }
    class Car
    {
        String name;
        int price;
        public Car(String name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public Car()
        {

        }
        public String GetName()
        {
            return this.name;
        }
        public int GetPrice()
        {
            return this.price;
        }
        public void SetName(String name)
        {
            this.name = name;
        }
        public void SetPrice(int price)
        {
            this.price = price;
        }

    }
}
