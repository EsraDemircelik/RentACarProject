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
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new Result(true, "Kullanıcı Eklendi");
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new Result(true, "Kullanıcı silindi");
        }

        public IDataResult<List<User>> GetAll()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<User>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.Success);
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.UserId == id));
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new Result(true, "User güncellendi");
        }

    }
}
