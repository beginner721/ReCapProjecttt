using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRuleService<T>
    {
        void CarName(T entity);
        void CarPrice(T entity);
    }
}
