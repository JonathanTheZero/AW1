using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW1.Interfaces.Model
{
    public interface IFlagable
    {
        bool Flag { get; set; }
        void ClearFlag();
    }
}
