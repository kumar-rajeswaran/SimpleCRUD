﻿using SimpleCRUD.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCRUD.Services
{
    public interface IEmployeeService
    {
        Task<List<EmployeeDTO>> GetAllEmployees();
        Task<EmployeeDTO> GetEmployeeById(int userid);
        Task<bool> AddEmployee(EmployeeDTO dto);
        Task<bool> DeleteEmployee(int userid);
    }
}
