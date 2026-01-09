using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyDataBaseFluent.EnumTypes
{
    public enum ConstraintType
    {
        PrimaryKey = 1,
        ForeignKey = 2,
        Unique = 3,
        Check = 4,
        NotNull = 5
    }
}
