using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        IDataResult<List<Employee>> GetAll();
        IDataResult<Employee> GetById(int Id);
        IResult Add(Employee employee);
        IResult Update(Employee employee);
        IResult Delete(Employee employee);
    }
}
