using System;
using System.ComponentModel.DataAnnotations;

namespace KimNhanShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public abstract DateTime? CreatedDate { get; set; }

        [MaxLength(256)]
        public abstract string CreatedBy { get; set; }

        public abstract DateTime? UpdatedDate { get; set; }

        [MaxLength(256)]
        public abstract string UpdatedBy { get; set; }
    }
}