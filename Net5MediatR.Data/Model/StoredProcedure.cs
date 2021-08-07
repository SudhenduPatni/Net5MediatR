using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5MediatR.Data.Model
{
    public class StoredProcedure
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public int? Timeout { get; set; }
        public string Database { get; set; }
    }

    public class StoredProceduresMetadata
    {
        public StoredProcedure[] StoredProcedures { get; set; }
    }
}
