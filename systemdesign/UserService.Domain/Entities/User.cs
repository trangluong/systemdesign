using System;
using UserService.Domain.SeedWork;

namespace UserService.Domain.Entities
{
	public class User
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public Gender Gender { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Country { get; set; } 

	}
}

