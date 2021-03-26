using Core.Entities.Conrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        User GetByMail(string email);
    }
}
