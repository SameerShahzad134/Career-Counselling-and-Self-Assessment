﻿using Microsoft.EntityFrameworkCore;
using System;

namespace CCASA.Models
{
    public abstract class AuditableEntity
    {
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
