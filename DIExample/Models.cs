﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DIExample
{
    class Models
    {

    }
    public interface IDataAccess
    {
        void Add();
    }

    public class SqlServerDal : IDataAccess
    {
        public void Add()
        {
            Console.WriteLine("Add a order in sqlserver!");
        }
    }

    public class AccessDal : IDataAccess
    {
        public void Add()
        {
            Console.WriteLine("Add a order in access！");
        }
    }

    public class Order
    {
        private IDataAccess _ida;
        public Order(IDataAccess ida)
        {
            _ida = ida;
        }

        public void Add()
        {
            _ida.Add();
        }
    }

}
