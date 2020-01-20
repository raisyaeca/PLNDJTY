using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace LoginNavigation
{
    public abstract class EmployeesRepository
    {
        readonly ObservableCollection<Employee> employees;

        public EmployeesRepository()
        {
            this.employees = new ObservableCollection<Employee>();
        }

        public ObservableCollection<Employee> Employees
        {
            get { return employees; }
        }
    }

    public class TestEmployeesRepository : EmployeesRepository
    {
        public TestEmployeesRepository() : base()
        {
            GenerateCustomers();
        }

        void GenerateCustomers()
        {
            Employees.Add(
                new Employee("Budi")
                {
                    KodeUnit = 11,
                    NoAgenda = 131,
                    Address = "Tembalang, Semarang",
                    JP = "PB",

                    BirthDate = new DateTime(1978, 12, 8),
                    HireDate = new DateTime(2005, 5, 1),
                    Position = "Sales Representative",                    
                    Phone = "(206) 555-9857",
                    Access = AccessLevel.User,
                    OnVacation = false
                }
            );
            Employees.Add(
                new Employee("Setyo Novanto")
                {                
                    KodeUnit = 12,
                    NoAgenda = 132,
                    Address = "Banyumanik, Semarang",
                    JP = "PB",

                    BirthDate = new DateTime(1965, 2, 19),
                    HireDate = new DateTime(1992, 8, 14),
                    Position = "Vice President, Sales",                  
                    Phone = "(206) 555-9482",
                    Access = AccessLevel.Admin,
                    OnVacation = false
                }
            );
            Employees.Add(
                new Employee("Harris Asrofi")
                {
                    KodeUnit = 13,
                    NoAgenda = 133,
                    Address = "Gajahmungkur, Semarang",
                    JP = "PB",

                    BirthDate = new DateTime(1985, 8, 30),
                    HireDate = new DateTime(2002, 4, 1),
                    Position = "Sales Representative",                    
                    Phone = "(206) 555-3412",
                    Access = AccessLevel.User,
                    OnVacation = false
                }
            );
            Employees.Add(
                new Employee("Sutedja")
                {
                    KodeUnit = 12,
                    NoAgenda = 134,
                    Address = "Candisari, Semarang",
                    JP = "PB",

                    BirthDate = new DateTime(1973, 9, 19),
                    HireDate = new DateTime(1993, 5, 3),
                    Position = "Sales Representative",                 
                    Phone = "(206) 555-8122",
                    Access = AccessLevel.User,
                    OnVacation = false
                }
            );
            Employees.Add(
                new Employee("Joko Anwar")
                {
                    KodeUnit = 11,
                    NoAgenda = 135,
                    Address = "Ngaliyan, Semarang",
                    JP = "PB",

                    BirthDate = new DateTime(1955, 3, 4),
                    HireDate = new DateTime(1993, 10, 17),
                    Position = "Sales Manager",                  
                    Phone = "(71) 555-4848",
                    Access = AccessLevel.User,
                    OnVacation = true
                }
            );
            Employees.Add(
                new Employee("Bambang")
                {
                    KodeUnit = 12,
                    NoAgenda = 136,
                    Address = "Genuk, Semarang",
                    JP = "PB",

                    BirthDate = new DateTime(1981, 7, 2),
                    HireDate = new DateTime(1999, 10, 17),
                    Position = "Sales Representative",                    
                    Phone = "(71) 555-7773",
                    Access = AccessLevel.User,
                    OnVacation = false
                }
            );
            Employees.Add(
                new Employee("Robert King")
                {
                    KodeUnit = 13,
                    NoAgenda = 137,
                    Address = "Sampangan, Semarang",
                    JP = "PB",

                    BirthDate = new DateTime(1960, 5, 29),
                    HireDate = new DateTime(1994, 1, 2),
                    Position = "Sales Representative",                   
                    Phone = "(71) 555-5598",
                    Access = AccessLevel.User,
                    OnVacation = false
                }
            );
            Employees.Add(
                new Employee("Laura Callahan")
                {
                    KodeUnit = 12,
                    NoAgenda = 138,
                    Address = "Sampangan, Semarang",
                    JP = "PB",

                    BirthDate = new DateTime(1985, 1, 9),
                    HireDate = new DateTime(2004, 3, 5),
                    Position = "Inside Sales Coordinator",                   
                    Phone = "(206) 555-1189",
                    Access = AccessLevel.User,
                    OnVacation = true
                }
            );
            Employees.Add(
                new Employee("Anne Dodsworth")
                {
                    KodeUnit = 13,
                    NoAgenda = 139,
                    Address = "Jatingaleh, Semarang",
                    JP = "PB",

                    BirthDate = new DateTime(1980, 1, 27),
                    HireDate = new DateTime(2004, 11, 15),
                    Position = "Sales Representative",                    
                    Phone = "(71) 555-4444",
                    Access = AccessLevel.User,
                    OnVacation = false
                }
            );
        }
    }
}
