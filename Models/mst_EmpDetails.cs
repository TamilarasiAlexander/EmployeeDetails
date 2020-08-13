using System;
using System.ComponentModel.DataAnnotations;

namespace Employee_Details.Models
{
    public class mst_EmpDetails
    {
		[Key]
    public Int32 EmpId   {get;set;} 
	public string  EmpCode   {get;set;} 
	public string Name   {get;set;} 
	public string Email  {get;set;} 	
	public string PhoneNo   {get;set;} 
	public bool isActive {get;set;}
	
    }
}