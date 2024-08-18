using PersonelApp.Model.Concrete.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.Model.Concrete.Entities
{
    public class Materials:BaseEntity
    {
        public string Name { get; set; }
        public string Unit { get; set; } 
    }
}
