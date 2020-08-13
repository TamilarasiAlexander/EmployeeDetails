using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Employee_Details.Service;
using Employee_Details.Models;
namespace Employee_Details.Controllers
{
    [ApiController]
    // [Route("[controller]")]
    public class EmployeeDetailsController : Controller
    {
        private readonly employeeDetailsService service;      
        public EmployeeDetailsController(employeeDetailsService _service)
        {
            service = _service;            
        }
       
        [HttpGet]
        [Route("api/Test")]
        public string Test()
        {
            return "Test Success";
        }

        [HttpGet]
        [Route("api/GetEmployeeDetails")]
        public IActionResult GetEmployeeDetails()
        {
            List<mst_EmpDetails> objMst_EmpMst = new List<mst_EmpDetails>();           
            try
            {

                objMst_EmpMst = service.GetEmployeeDetails();
                if (objMst_EmpMst == null || objMst_EmpMst.Count == 0)
                {
                    return NotFound("Employee details not found");
                }
                else
                {
                   objMst_EmpMst = objMst_EmpMst.ToList();
                }
            }
            catch (Exception ex)
            {
                return NotFound(new { message = ex });
            }
            return Json(objMst_EmpMst);
        }

        [HttpPost]
        [Route("api/addEmployeeDetails")]
        public IActionResult addEmployeeDetails(mst_EmpDetails objmst_EmpDetails)
        {
            List<mst_EmpDetails> objMst_EmpMst = new List<mst_EmpDetails>();           
            try
            {

                objMst_EmpMst = service.addEmployeeDetails(objmst_EmpDetails);
                if (objMst_EmpMst == null || objMst_EmpMst.Count == 0)
                {
                    return NotFound("Employee details not found");
                }
                else
                {
                   objMst_EmpMst = objMst_EmpMst.ToList();
                }
            }
            catch (Exception ex)
            {
                return NotFound(new { message = ex });
            }
            return Json(objMst_EmpMst);
        }

          [HttpPost]
        [Route("api/updateEmployeeDetails")]
        public IActionResult updateEmployeeDetails(mst_EmpDetails objmst_EmpDetails)
        {
            List<mst_EmpDetails> objMst_EmpMst = new List<mst_EmpDetails>();           
            try
            {

                objMst_EmpMst = service.updateEmployeeDetails(objmst_EmpDetails);
                if (objMst_EmpMst == null || objMst_EmpMst.Count == 0)
                {
                    return NotFound("Employee details not found");
                }
                else
                {
                   objMst_EmpMst = objMst_EmpMst.ToList();
                }
            }
            catch (Exception ex)
            {
                return NotFound(new { message = ex });
            }
            return Json(objMst_EmpMst);
        }

           [HttpPost]
        [Route("api/deleteEmployeeDetails")]
        public IActionResult deleteEmployeeDetails(int empId)
        {
            List<mst_EmpDetails> objMst_EmpMst = new List<mst_EmpDetails>();           
            try
            {

                objMst_EmpMst = service.deleteEmployeeDetails(empId);
                if (objMst_EmpMst == null || objMst_EmpMst.Count == 0)
                {
                    return NotFound("Employee details not found");
                }
                else
                {
                   objMst_EmpMst = objMst_EmpMst.ToList();
                }
            }
            catch (Exception ex)
            {
                return NotFound(new { message = ex });
            }
            return Json(objMst_EmpMst);
        }
    }
}
