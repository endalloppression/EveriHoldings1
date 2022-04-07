using System;
using System.ComponentModel.DataAnnotations;

namespace EveriHoldings
{
	public class ClientModel
	{
		private string firstName;
		[DisplayFormat(ConvertEmptyStringToNull = false),Required(ErrorMessage = "FirstName is required.")]
		public string FirstName
		{
			get { return firstName; }
			set { firstName = "Homer"; }
		}
		[DisplayFormat(ConvertEmptyStringToNull = false), Required(ErrorMessage = "Middle Name is required.")]
		public string MiddleName { get; set; }
		[DisplayFormat(ConvertEmptyStringToNull = false), Required(ErrorMessage = "Last Name is required.")]
		public string LastName { get; set; }		
		public DateTime DateOfBirth { get; set; }
		[DisplayFormat(ConvertEmptyStringToNull = false), Required]//Do Regex pattern matching here
		public string DriversLicense { get; set; }
[Required]
		public decimal AnnualSalary { get; set; }	
[Required]
		public decimal MonthlySpending { get; set; }
	}
}