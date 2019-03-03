using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLibrary.Entity
{
   public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreteTime { get; set; }
        public DateTime ModifiedTime { get; set; }
    }
}
