using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using App_Practice_1.MyLib;

namespace App2.Controllers
{
     [ApiController]
    [Route("[controller]")]
    public class OfficeController:ControllerBase
    {
    [HttpPost("Create")]
    public Employees data( Employees employees)
    {
        return employees;
    }
        
    }
}