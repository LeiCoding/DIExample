using System;

namespace DIExample
{
        class Program
    {
        static void Main(string[] args)
        {
            SqlServerDal dal = new SqlServerDal();
            Order order = new Order(dal);

            order.Add();

            Console.Read();
        }
    }


}
