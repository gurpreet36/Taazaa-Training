using System.ComponentModel.DataAnnotations;
namespace App_Practice_1.MyLib
{
    public class Employees
    {
        public int empId{get;set;}
        public string empName{get;set;}
       
        [Range( 2, 4 )]  
        public int empAge{get; set;}

    }
}