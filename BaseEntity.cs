﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPortalAPi
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string UniqueId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public long ModifiedBy { get; set; }
        public bool IsDeleted { get; set; } 
    }
}
