using System;
using System.Collections.Generic;
namespace WebAPI_APP1.Models
{
    public class Fortius_Emp_List
    {
        List<Fortius_Employee> fortius_Employees= new List<Fortius_Employee>();
        public  List<Fortius_Employee> addFortiusEmployee()
        {
            Fortius_Employee data1=new Fortius_Employee();
            data1.emp_Id=1576803117;
            data1.emp_Name="GurpretSingh";
            data1.emp_Gender='M';
            data1.emp_Address="New Delhi";
            data1.emp_blood_group="B+";
            data1.emp_PhNo=7827777777;
            data1.emp_Salary=10000000.00;

            Fortius_Employee data2=new Fortius_Employee();
            data2.emp_Id=1676803117;
            data2.emp_Name="Max Ten";
            data2.emp_Gender='M';
            data2.emp_Address="Noida";
            data2.emp_blood_group="A+";
            data2.emp_PhNo=8827777777;
            data2.emp_Salary=10000000.00;

            Fortius_Employee data3=new Fortius_Employee();
            data3.emp_Id=1876803117;
            data3.emp_Name="Ben Ten";
            data3.emp_Gender='M';
            data3.emp_Address="Greater Noida";
            data3.emp_blood_group="AB+";
            data3.emp_PhNo=9927777777;
            data3.emp_Salary=10000000.00;
            
            Fortius_Employee data4=new Fortius_Employee();
            data4.emp_Id=1976803117;
            data4.emp_Name="Harry";
            data4.emp_Gender='M';
            data4.emp_Address="Noida";
            data4.emp_blood_group="o+";
            data4.emp_PhNo=9827777777;
            data4.emp_Salary=10000000.00;
            
            Fortius_Employee data5=new Fortius_Employee();
            data5.emp_Id=2076803117;
            data5.emp_Name="Rohit";
            data5.emp_Gender='M';
            data5.emp_Address="Delhi";
            data5.emp_blood_group="AB+";
            data5.emp_PhNo=7827777777;
            data5.emp_Salary=10000000.00;
            
            
            
            Fortius_Employee[] listarr={data1,data2,data3,data4,data5};

            foreach(Fortius_Employee i in listarr)
            {
                fortius_Employees.Add(i);
            }
            return fortius_Employees;
        }
        
    }
}