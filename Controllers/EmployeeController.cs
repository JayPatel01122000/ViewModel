using System.Web.Mvc;
using ViewModelExample.Models;
using ViewModelExample.ViewModels;

namespace FirstMVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public ViewResult Details()
        {
            //Employee Basic Details
            Employee employee = new Employee()
            {
                EmployeeId = 101,
                Name = "Jay",
                Gender = "Male",
                Department = "IT",
                Salary = 80000,
                AddressId = 1001
            };

            //Employee Address
            Address address = new Address()
            {
                AddressId = 1001,
                City = "Barrie",
                State = "Ontario",
                Country = "Canada",
                Pin = "L4N3R7"
            };

            //Creating the View model
            EmployeeDetailsViewModel employeeDetailsViewModel = new EmployeeDetailsViewModel()
            {
                Employee = employee,
                Address = address,
                PageTitle = "Employee Details Page",
                PageHeader = "Employee Details",
            };

            //Pass the employeeDetailsViewModel to the view
            return View(employeeDetailsViewModel);
        }
    }
}