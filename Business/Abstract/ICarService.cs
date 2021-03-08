using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<CarProps> GetAll();
        List<CarProps> GetById(int id);
        void Add(CarProps carProps);
        void Delete(CarProps carProps);
        void Update(CarProps carProps);
    }
}
