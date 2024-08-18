using PersonelApp.Model.Concrete.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.Model.Concrete.Entities
{
    public class Personnel:BaseEntity
    {
        public int? DebitId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public string Graduation { get; set; }
        public string Gender { get; set; }
    }
}
