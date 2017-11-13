using DDDSample.SharedKernel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSample.SharedKernel.BaseClasses
{
    public abstract class Entity<T>
    {
        public T Id { get; set; }
        public Status Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedUser { get; set; }
        public string ModifiedUser { get; set; }
    }
}
