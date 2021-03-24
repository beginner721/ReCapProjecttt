using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Linq;

namespace ConsoleUI
{
    class Program

    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EfCarDal());

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}

            CarManager carManager = new CarManager(new EfCarDal());

            //carManager.Add(new CarProps { Id = 6, BrandId = 2, ColourId = 3, ModelYear = 2019, DailyPrice = 166500, Description = "Acil satılıktır..." });
            //carManager.Update(new CarProps {Id=6,BrandId=1,ColourId=3,ModelYear=2021,DailyPrice=175500,Description="artık acil degil" } );
            //carManager.Delete(new CarProps { Id = 6 }); // delete için ID vermemiz yeterlidir, oradan bulacaktır...
            
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandName + car.ColourName+ " // " + car.DailyPrice+"TL");
            }







        }
    }
}
