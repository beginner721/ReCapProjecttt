using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(CarProps carProps)
        {
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
            return _carDal.GetById(id);
        }

        public void Update(CarProps carProps)
        {
            _carDal.Update(carProps);
        }
    }
}
