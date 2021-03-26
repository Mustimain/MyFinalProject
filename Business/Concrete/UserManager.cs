using Business.Abstract;
using Core.Entities.Conrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);

            return new SuccessResult();
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);

            return new SuccessResult();
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);

            return  new SuccessResult();
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }
    }
}
