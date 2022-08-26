using System;
using System.Collections.Generic;

namespace Qbotech.GymIsLife.Core.Domain.Entities
{
    public partial class UserAuthentications
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RolId { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string RefreshToken { get; set; } = null!;
        public DateTime RefreshTokenExpiration { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; } = null!;
        public sbyte IsActive { get; set; }
    }
}
