using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcDemo.Application.Wrappers
{
    public class BaseResponse
    {
        public long Id { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
