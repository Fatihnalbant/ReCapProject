using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal : IColorDal
    {
        List<Color> _color;

        public InMemoryColorDal() 
        {
            _color = new List<Color>
            {
                new Color{ColorId = 111, ColorName = "Siyah"},
                new Color{ColorId = 222, ColorName = "Beyaz"},
                new Color{ColorId = 333, ColorName = "Kırmızı"},

            };
        }


        public void Add(Color color)
        {
            _color.Add(color);
        }

        public void Delete(Color color)
        {
            Color colorToDelete = _color.SingleOrDefault(c => color.ColorId == color.ColorId);
            _color.Remove(colorToDelete);

        }

        public List<Color> GetAll()
        {
            return _color;
        }

        public List<Color> GetById(int colorId)
        {
            return _color.Where(c => c.ColorId == colorId).ToList();
        }

        public void Update(Color color)
        {
            Color colorToUpdate = _color.SingleOrDefault(c => c.ColorId == color.ColorId);

            colorToUpdate.ColorId = color.ColorId;
            colorToUpdate.ColorName = color.ColorName;
        }
    }
}
