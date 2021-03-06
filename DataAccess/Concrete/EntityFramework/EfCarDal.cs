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
    //ürüne ait operasyonlar
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result =from c in context.Cars
                            join b in context.Brands
                            on c.BrandId equals b.BrandId
                            join color in context.Colors
                            on c.ColorId equals color.ColorId
                    select new CarDetailDto
                             {
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 BrandName = b.BrandName,
                                 ColorName = color.ColorName
                             };
                return result.ToList();
            }
        }
    }
}
