using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BaseModel
    {
        public BaseModel()
        {

        }
        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public override string ToString()
        {
            return string.Format("Created At: {0} \n Updated At: {1} \n {2}", CreatedAt, UpdatedAt, base.ToString());
        }
    }
}
