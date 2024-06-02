using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Code 
    {
        public int CallCount;
        public int LostCallCount;
        
        
        public double RatioLostCalls {
            get {
                return (double)LostCallCount/(double)CallCount;
            }
        }
    }
}