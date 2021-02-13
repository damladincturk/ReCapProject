using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BrandTest();

        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal()) ;
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandId);
            }
        }
        private static void UsersTest()
        {
            UsersManager usersManager = new UsersManager(new EfUsersDal());
            foreach (var user in usersManager.GetAll().Data)
            {
                Console.WriteLine(user.Id);
            }
        }
        private static void RentalsTest()
        {
            RentalsManager rentalsManager = new RentalsManager(new EfRentalsDal());
            foreach (var rental in rentalsManager.GetAll().Data)
            {
                Console.WriteLine(rental.Id);
            }
        }
        private static void CustomersTest()
        {
            CustomersManager customersManager = new CustomersManager(new EfCustomersDal());
            foreach (var customer in customersManager.GetAll().Data)
            {
                Console.WriteLine(customer.UserId);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorId);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.Write(car.Id + " " + car.CarName + " " + car.ColorName);

                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            

            
        }
    }
}
