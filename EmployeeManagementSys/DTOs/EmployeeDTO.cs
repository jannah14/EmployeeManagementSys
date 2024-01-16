﻿using EmployeeManagementSys.Models;

namespace EmployeeManagementSys.DTOs
{
    public class EmployeeDTO
    {
        internal string? Id { get; set; }
        public string Name { get; set; }
        public Position Position { get; set; }
        public double Salary { get; set; }
    }
}