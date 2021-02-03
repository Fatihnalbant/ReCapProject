using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    internal interface ICarDal
    {
        List<Car> GetAll();
    }
}