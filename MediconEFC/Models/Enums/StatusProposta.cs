using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediconEFC.Models.Enums
{
    public enum StatusProposta : int
    {
        Canceled = 0,
        Active = 1,
        Finished = 2,
        Evaluation = 3,
        Suspended = 4
    }
}
