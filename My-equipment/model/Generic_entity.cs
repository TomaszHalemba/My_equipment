using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_equipment.model
{
    public abstract class Generic_entity
    {
        public virtual string to_csv()
        {
            return "";
        }
    }
}
