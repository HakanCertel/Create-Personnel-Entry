using PersonelApp.Model.Concrete.Base;
using System.Collections.Generic;

namespace PersonnelApp.WebUI.Models
{
    public class PersonnelModel:BaseEntity
    {
        public int? DebitId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public string Graduation { get; set; }
        public string Gender { get; set; }
    }
}
