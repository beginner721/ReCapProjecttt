using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<CarProps> GetAll();
        List<CarProps> GetById(int id);
        List<CarProps> GetCarsByBrandId(int id);
        List<CarProps> GetCarsByColorId(int id);
        List<CarDetailDto> GetCarDetails();
        void Add(CarProps carProps);
        void Delete(CarProps carProps);
        void Update(CarProps carProps);
    }
}
