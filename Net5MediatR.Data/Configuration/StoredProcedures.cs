using Net5MediatR.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5MediatR.Data.Configuration
{
    public class StoredProcedures
    {
        public StoredProcedure GetAllClient { get; set; }
        public StoredProcedure GetClientById { get; set; }
        public StoredProcedure AddClient { get; set; }
        public StoredProcedure UpdateClient { get; set; }
        public StoredProcedure DeleteClient { get; set; }
    }
}
