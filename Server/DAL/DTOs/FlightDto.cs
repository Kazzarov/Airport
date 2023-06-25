using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTOs
{
	public class FlightDto
	{	
		public int Id { get; set; }
	
		public int FlightNumber { get; set; }

		public string? PlaneName { get;  set; }
		public string? FlightType { get; set; }

		public DateTime EnterTime { get; set; }

		public DateTime ExitTime { get; set; }

	}
}
