using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<CarProps> GetById(int id);
        List<CarProps> GetAll();
        void Add(CarProps carProps);
        void Update(CarProps carProps);
        void Delete(CarProps carProps);

    }
}
