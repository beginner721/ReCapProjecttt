using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService,IRuleService<CarProps>
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }


        public void Add(CarProps carProps)
        {
            CarPrice(carProps);
            CarName(carProps);
            _carDal.Add(carProps);
        }

        public void Delete(CarProps carProps)
        {
            _carDal.Delete(carProps);
        }

        public List<CarProps> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarProps> GetById(int id)
        {
            return _carDal.GetAll(p => p.Id == id);
        }

        public List<CarProps> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<CarProps> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColourId == id);
        }

        public void Update(CarProps carProps)
        {
            _carDal.Update(carProps);
        }


        public void CarName(CarProps entity)
        {
            if (entity.Description.Length<=2)
            {
                throw new Exception("Açıklama çok kısa!");
            }
        }

        public void CarPrice(CarProps entity)
        {
            if (entity.DailyPrice<=0)
            {
                throw new Exception("Lütfen geçerli bir fiyat girin!");
            }
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
