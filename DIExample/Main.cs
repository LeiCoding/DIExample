using System;

namespace DIExample
{
        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance example:");
            //Inheritance example
            Car car = new Car();
            Audi audi = new Audi();
            car = audi;
            car.Move();//parent can get child property and motheds which inherit from itself
            car.Stop();
            audi.Gettyres();//parent can not use any child's own properties and motheds
            audi.Stop();//child has the mothed from its parent by hidden
            audi.Getchair();//child has the properties from its parent by hidden

            Console.WriteLine("\nDI example:");
            //constructor injection
            SqlServerDal dalsql = new SqlServerDal();
            Order ordersql = new Order(dalsql);
            ordersql.Add();

            AccessDal dalacc = new AccessDal();
            Order orderacc = new Order(dalacc);
            orderacc.Add();

            //property depedency
            SqlServerDal anotherdal = new SqlServerDal();
            AnotherOrder anotherorder = new AnotherOrder();
            anotherorder.Ida = anotherdal;
            anotherorder.Add();

            //interface injection
            AccessDal thirddal = new AccessDal();
            ThirdOrder thirdorder = new ThirdOrder();
            thirdorder.SetDependence(thirddal);
            thirdorder.Add();

            Console.Read();
        }
    }


}
