using System;
using System.Collections.Generic;
using WebAPI_APP1.Models;
using Microsoft.AspNetCore.Mvc;
namespace WebAPI_APP1.Controllers
{
    [Route("[controller]")]
    public class URLsController:ControllerBase
    {
        [HttpGet]                                   //default url
        public string welcomeMessage()
        {
            string n="Welcome to the Fortius";
            return n;
        }
        [HttpGet("EmployeeData")]                  //employee data url
        public  List<Fortius_Employee> employeeData()
        {
            Fortius_Emp_List fortius_Emp_List=new Fortius_Emp_List();
            return fortius_Emp_List.addFortiusEmployee();
        }

         [HttpGet("EmployeeDataUserFriendly")]                  //employee data in user friendy way url
        public  string employeeData1()
        {
            string data="";
            Fortius_Emp_List fortius_Emp_List=new Fortius_Emp_List();
            var b=fortius_Emp_List.addFortiusEmployee();
            foreach(var i in b)
            {
                data+=Convert.ToString(i.emp_Id)+"  | "+(i.emp_Name)+sp.total_Count(i.emp_Name,15)+" | "+i.emp_Gender+" | "+i.emp_Address+sp.total_Count(i.emp_Address,15)+" | "+i.emp_blood_group+sp.total_Count(i.emp_blood_group,4)+" | "+Convert.ToString(i.emp_PhNo)+" | "+Convert.ToString(i.emp_Salary)+"\n";
            }
            return data;
        }


    }
}