using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using DataAccess;
using BusinessObject;

namespace BusinessLogic
{
    public class CoffeeBL
    {
        public ArrayList GetCoffeeList()
        {
            CoffeeDA coffeeda = new CoffeeDA();
            return coffeeda.GetAllCoffee();
        }

        public ArrayList GetCoffeeListByType(string type)
        {
            CoffeeDA coffeeda = new CoffeeDA();
            return coffeeda.GetCoffeeByType(type);
        }

        public ArrayList GetCoffeeTypes()
        {
            CoffeeDA coffeeda = new CoffeeDA();
            var temp = coffeeda.GetCoffeeTypes();
            temp.Insert(0, "ALL");

            return temp;
        }

        public void InsertCoffee(CoffeeBO coffee)
        {
            CoffeeDA coffeeda = new CoffeeDA();
            coffeeda.InsertCoffee(coffee);
        }

        public CoffeeBO GetCoffeeById(int id)
        {
            CoffeeDA da = new CoffeeDA();
            return da.GetCoffeeById(id);
        }

        public void UpdateCoffee(CoffeeBO coffee)
        {
            CoffeeDA da = new CoffeeDA();
            da.UpdateCoffee(coffee);
        }

        public void DeleteCoffee(int id)
        {
            CoffeeDA da = new CoffeeDA();
            da.DeleteCoffee(id);
        }
    }
}
