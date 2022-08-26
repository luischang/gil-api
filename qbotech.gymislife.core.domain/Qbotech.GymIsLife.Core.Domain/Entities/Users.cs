using System;
using System.Collections.Generic;

namespace Qbotech.GymIsLife.Core.Domain.Entities
{
    public partial class Users
    {
        public string FirstName { get; set; } = null!;
        public string MiddleName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; } = null!;
        public string Country { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public string Status { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public int Id { get; set; }
    }
}
