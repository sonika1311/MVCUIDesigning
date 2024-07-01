using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCUIDesigning.Models;

namespace MVCUIDesigning.Controllers
{
    public class CustomerController : Controller
    {
        public ViewResult DisplayCustomers()
        {
            Customer c1 = new Customer
            { 
                CustId=1001,Name="Sonika",
                Account="Current",
                Balance=1234567,
                City="Mumbai",
                Status=true,
                Photo="/Images/person1.jpg"
            };
            Customer c2 = new Customer
            {
                CustId = 1002,
                Name = "Kevin",
                Account = "Current",
                Balance = 50000.00,
                City = "Kolkata",
                Status = true,
                Photo = "/Images/person2.jpg"
            };
            Customer c3 = new Customer
            {
                CustId = 1003,
                Name = "Sandra",
                Account = "Demat",
                Balance = 50000.00,
                City = "Mumabi",
                Status = true,
                Photo = "/Images/person3.jpg"
            };
            Customer c4 = new Customer
            {
                CustId = 1004,
                Name = "Williams",
                Account = "Savings",
                Balance = 50000.00,
                City = "Chennai",
                Status = true,
                Photo = "/Images/person4.jpg"
            };
            Customer c5 = new Customer
            {
                CustId = 1005,
                Name = "John",
                Account = "Demat",
                Balance = 50000.00,
                City = "Bengaluru",
                Status = true,
                Photo = "/Images/person5.jpg"
            };
            Customer c6 = new Customer
            {
                CustId = 1006,
                Name = "Bill",
                Account = "Current",
                Balance = 50000.00,
                City = "Hyderabad",
                Status = true,
                Photo = "/Images/person6.jpg"
            };
            List<Customer> custList = new List<Customer> { c1, c2, c3, c4, c5, c6 };
            return View(custList);
        }    
    }
}