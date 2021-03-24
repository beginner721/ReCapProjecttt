using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<CarProps, RcpContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RcpContext context = new RcpContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id

                             join co in context.Colours
                             on c.ColourId equals co.Id

                             select new CarDetailDto { CarId = c.Id, BrandId=b.Id, ColourId=co.Id, BrandName=b.Name, ColourName=co.Name, DailyPrice=c.DailyPrice };
                return result.ToList();
            }
        }
    }
}
