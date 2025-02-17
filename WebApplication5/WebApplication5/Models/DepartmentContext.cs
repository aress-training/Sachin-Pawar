﻿using System.Data.Entity;

namespace WebApplication5.Models
{
    #region "DepartmentContext Class"
    /// <summary>
    /// DepartmentContext class established connection with department table using entity framework
    /// </summary>
    public class DepartmentContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }

        public System.Data.Entity.DbSet<WebApplication5.Models.Employee> Employees { get; set; }
    }
    #endregion
}