using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcDemo.Domain
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long CreateUser_Id { get; set; }
        public long? UpdateUser_Id { get; set; }
        public bool IsDeleted { get; set; }

    }
}
