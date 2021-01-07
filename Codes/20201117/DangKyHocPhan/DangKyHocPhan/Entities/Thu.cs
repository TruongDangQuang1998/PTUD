using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKyHocPhan.Entities
{
    public class Thu
    {
        [Key]
        public int ThuId{get;set;}
        public string TenThu { get; set; }
    }
}
