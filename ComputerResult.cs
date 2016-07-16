using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WindowsFormsApplication1
{
    public abstract class ComputerResult
    {
        public virtual DataTable GetResult(DataTable table, DataTable resultTable,decimal range)
        {
            return null;
        }
    }
}
