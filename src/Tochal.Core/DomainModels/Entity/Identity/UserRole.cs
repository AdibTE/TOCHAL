﻿using Tochal.Core.DomainModels.Entity.AuditableEntity;
using Microsoft.AspNetCore.Identity;

namespace Tochal.Core.DomainModels.Entity.Identity
{
    
    public class UserRole : IdentityUserRole<int>, IAuditableEntity
    {
        public virtual User User { get; set; }

        public virtual Role Role { get; set; }
    }
}