using System;

namespace DIExample
{
        class Program
    {
        static void Main(string[] args)
        {
            SqlServerDal dalsql = new SqlServerDal();
            Order ordersql = new Order(dalsql);
            ordersql.Add();
            AccessDal dalacc = new AccessDal();
            Order orderacc = new Order(dalacc);
            orderacc.Add();

            Console.Read();
        }
    }


}
