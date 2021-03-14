using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(CarProps entity)
        {
            using (RcpContext context = new RcpContext())

            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(CarProps entity)
        {
            using (RcpContext context = new RcpContext())

            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public CarProps Get(Expression<Func<CarProps, bool>> filter)
        {
            using (RcpContext context=new RcpContext())
            {
                return context.Set<CarProps>().SingleOrDefault(filter);
            }
        }

        public List<CarProps> GetAll(Expression<Func<CarProps, bool>> filter = null)
        {
            using (RcpContext context= new RcpContext())
            {
                return filter == null
                    ? context.Set<CarProps>().ToList()
                    : context.Set<CarProps>().Where(filter).ToList();
            }
        }

        public void Update(CarProps entity)
        {
            using (RcpContext context = new RcpContext())

            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
