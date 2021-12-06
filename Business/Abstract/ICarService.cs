using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        //tümünü listeler
        List<Car> GetAll();
        //ıd'ye göre car verir
        Car GetById(int carId);
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        void Add(Car car);
        List<CarDetailDto> GetCarDetails();
    }
}
