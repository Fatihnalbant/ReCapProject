using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    internal class CarManager
    {
        private InMemoryCarDal ınMemoryCarDal;

        public CarManager(InMemoryCarDal ınMemoryCarDal)
        {
            this.ınMemoryCarDal = ınMemoryCarDal;
        }

        internal IEnumerable<object> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}