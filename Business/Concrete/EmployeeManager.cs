using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class EmployeeManager :IEmployeeService
    {
        private IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public IDataResult<List<Employee>> GetAll()
        {
            return new SuccessDataResult<List<Employee>>(_employeeDal.GetAll(),Messages.EmployeeListed);
        }

        public IDataResult<Employee> GetById(int Id)
        {
            return new SuccessDataResult<Employee>(_employeeDal.Get(e=> e.EmployeeId == Id),"Employee Getirildi");
        }

        public IResult Add(Employee employee)
        {
            _employeeDal.Add(employee);

            return new SuccessResult();

        }

        public IResult Update(Employee employee)
        {
            _employeeDal.Update(employee);

            return new SuccessResult();
        }

        public IResult Delete(Employee employee)
        {
            _employeeDal.Delete(employee);

            return new SuccessResult();
        }
    }
}
