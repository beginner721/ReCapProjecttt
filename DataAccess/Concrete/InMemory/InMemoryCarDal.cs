using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<CarProps> _carProps;

        public InMemoryCarDal()
        {
            _carProps = new List<CarProps>
            {
                new CarProps{Id=1,ColourId=1,BrandId=4,ModelYear=2019,DailyPrice=235000,Description="Hatasız boyasız kazasız temiz araç" },
                new CarProps{Id=2,ColourId=1,BrandId=3,ModelYear=2021,DailyPrice=259000,Description="Sıfır km araç" },
                new CarProps{Id=3,ColourId=2,BrandId=5,ModelYear=2015,DailyPrice=176000,Description="İki parça değişen, lokal boyalı araç" },
                new CarProps{Id=4,ColourId=2,BrandId=7,ModelYear=2009,DailyPrice=76000,Description="200bin km'de bakımlı temiz araç" }
            };
        }

        public void Add(CarProps carProps)
        {
            _carProps.Add(carProps);
        }

        public void Delete(CarProps carProps)
        {
            CarProps carToDelete = _carProps.SingleOrDefault(c => c.Id == carProps.Id);
            _carProps.Remove(carToDelete);
        }

        public CarProps Get()
        {
            throw new NotImplementedException();
        }

        public CarProps Get(Expression<Func<CarProps, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarProps> GetAll()
        {
            return _carProps;
        }

        public List<CarProps> GetAll(Expression<Func<CarProps, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarProps> GetById(int id)
        {
            return _carProps.Where(c => c.Id == id).ToList();
        }

        public List<CarProps> GetById()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(CarProps carProps)
        {
            CarProps carToUpdate = _carProps.SingleOrDefault(c => c.Id == carProps.Id);
            carToUpdate.ColourId = carProps.ColourId;
            carToUpdate.BrandId = carProps.BrandId;
            carToUpdate.ModelYear = carProps.ModelYear;
            carToUpdate.DailyPrice = carProps.DailyPrice;
            carToUpdate.Description = carProps.Description;
        }
    }
}
