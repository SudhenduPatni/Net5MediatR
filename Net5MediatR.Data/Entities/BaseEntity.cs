using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5MediatR.Data.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDatetime { get; set; }
        public DateTime ModifiedDatetime { get; set; }
    }
}
