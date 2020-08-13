using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Employee_Details;
using Employee_Details.Service;
using Employee_Details.Models;

namespace Employee_Details.Repository
{

    public class employeeDetailsRepository : employeeDetailsService
    {
        // private readonly IHostingEnvironment _hostingEnvironment; 
        private readonly IConfiguration config;
        private readonly EmployeeDbContext context;

        public employeeDetailsRepository(EmployeeDbContext _context, IConfiguration _config)
        {
            context = _context;
            config = _config;

        }
        public List<mst_EmpDetails> GetEmployeeDetails()
        {
            List<mst_EmpDetails> objCMst_EmpOff = new List<mst_EmpDetails>();
            objCMst_EmpOff = (from myRow in context.mst_EmpDetails
                              select myRow).ToList();
            return objCMst_EmpOff;
        }

        public List<mst_EmpDetails> addEmployeeDetails(mst_EmpDetails objmst_EmpDetails)
        {
            List<mst_EmpDetails> objCMst_EmpOff = new List<mst_EmpDetails>();
            if (objmst_EmpDetails != null)
            {
                context.mst_EmpDetails.Add(objmst_EmpDetails);
                context.SaveChanges();
            }
            objCMst_EmpOff = (from myRow in context.mst_EmpDetails
                              select myRow).ToList();
            return objCMst_EmpOff;
        }

        public List<mst_EmpDetails> updateEmployeeDetails(mst_EmpDetails objmst_EmpDetails)
        {
            List<mst_EmpDetails> objCMst_EmpOff = new List<mst_EmpDetails>();
            if (objmst_EmpDetails != null)
            {
               var rec =  context.mst_EmpDetails.FirstOrDefault(x=>x.EmpId == objmst_EmpDetails.EmpId); 
               if(rec != null)
               {
                   rec.EmpCode = objmst_EmpDetails.EmpCode;
                   rec.Name = objmst_EmpDetails.Name;
                   rec.Email = objmst_EmpDetails.Email;
                   rec.PhoneNo = objmst_EmpDetails.PhoneNo;
               }

                 context.mst_EmpDetails.Update(rec);
                 context.SaveChanges();
            }
            objCMst_EmpOff =  context.mst_EmpDetails.Where(x=>x.EmpId == objmst_EmpDetails.EmpId).ToList();
            return objCMst_EmpOff;
        }
        public List<mst_EmpDetails> deleteEmployeeDetails(int empId)
        {
            List<mst_EmpDetails> objCMst_EmpOff = new List<mst_EmpDetails>();
            if (empId != 0)
            {
                var rec = context.mst_EmpDetails.Where(r => r.EmpId == empId).FirstOrDefault();
                context.mst_EmpDetails.Remove(rec);
                context.SaveChanges();
            }
            objCMst_EmpOff = (from myRow in context.mst_EmpDetails
                              select myRow).ToList();
            return objCMst_EmpOff;
        }
    }
}