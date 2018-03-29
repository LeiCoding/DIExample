using System;
using System.Collections.Generic;
using System.Text;

namespace DIExample
{
    //Inheritance example
    public class Car
    {
        public int chair = 4;
        public virtual void Move(){ }
        public void Stop()
        {
            Console.WriteLine("Stop");
        }
    }

    public class Audi : Car
    {
        public int tyre = 4;
        public override void Move()
        { Console.WriteLine("1K/H"); }
        public void Gettyres()
        {
            Console.WriteLine(tyre);
        }
        public void Getchair()
        {
            Console.WriteLine(chair);
        }
    }
    //end the example

    public interface IDataAccess
    {
        void Add();
    }

    //constructor injection
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

        public Order(IDataAccess ida)//constructor
        {
            _ida = ida;
        }

        public void Add()
        {
            _ida.Add();
        }
    }

    //property depedency
    public class AnotherOrder
    {
        private IDataAccess _ida;
                
        public IDataAccess Ida//property
        {
            set { _ida = value; }
            get { return _ida; }
        }

        public void Add()
        {
            _ida.Add();
        }
    }

    //interface injection
    public interface IDependent
    {
        void SetDependence(IDataAccess ida);
    }

    public class ThirdOrder:IDependent
    {
        private IDataAccess _ida;
        
        public void SetDependence(IDataAccess ida)
        {
            _ida = ida;
        }

        public void Add()
        {
            _ida.Add();
        }
    }
}
