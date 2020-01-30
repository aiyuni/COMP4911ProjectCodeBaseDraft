﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911DesignDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP4911DesignDemo.Repository
{
    public class EmployeeRepository : IDataRepository<Employee>
    {
        private readonly ApplicationDbContext _employeeContext;

        public EmployeeRepository(ApplicationDbContext context)
        {
            this._employeeContext = context;
        }

        public void Add(Employee entity)
        {
            if (_employeeContext.Employees.Any(p => p.EmployeeId == entity.EmployeeId) == false)
            {
                System.Diagnostics.Debug.WriteLine("record doesnt exist, adding...");
                _employeeContext.Employees.Add(entity);
            }
            else
            {
                System.Diagnostics.Debug.Write("record already exists, updating...");
                Employee existingEmployee = _employeeContext.Employees.FirstOrDefault(p => p.EmployeeId == entity.EmployeeId);
                this.Update(existingEmployee, entity);
            }

            _employeeContext.SaveChanges();
            _employeeContext.Entry(entity).State = EntityState.Detached;
        }

        public void Delete(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Employee Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employeeContext.Employees.ToList();
        }

        public void Update(Employee dbEntity, Employee entity)
        {
            _employeeContext.Entry(dbEntity).CurrentValues.SetValues(entity);
            System.Diagnostics.Debug.Write("Updated...");
        }
    }
}
