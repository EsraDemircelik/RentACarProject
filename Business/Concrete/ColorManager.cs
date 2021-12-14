using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new Result(true, "Renk Eklendi");
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new Result(true, "Renk silindi");
        }

        public IDataResult<List<Color>> GetAll()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<Color>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), Messages.Success);
        }

        public IDataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(r => r.ColorId == id));
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new Result(true, "Renk güncellendi");
        }
    }
}
