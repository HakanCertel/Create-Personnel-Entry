using PersonelApp.Model.Abctract.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.Model.Concrete.Base
{
    public class BaseEntity:IBaseEntity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
    }
}
