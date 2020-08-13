using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Employee_Details.Models;

namespace Employee_Details.Service
{
  
        public interface employeeDetailsService
        {          
           List<mst_EmpDetails> GetEmployeeDetails(); 

           List<mst_EmpDetails> addEmployeeDetails(mst_EmpDetails objmst_EmpDetails);  

            List<mst_EmpDetails> updateEmployeeDetails(mst_EmpDetails objmst_EmpDetails);  
            List<mst_EmpDetails> deleteEmployeeDetails(int empId);           

        }       
   
}