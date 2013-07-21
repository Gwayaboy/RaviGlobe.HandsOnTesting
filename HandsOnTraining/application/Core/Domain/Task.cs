using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaviDataGlobe.HandsOnTraining.Core.Domain
{
    public class Task
    {
        public string Description { get; set; } 
        public DateTime Expires { get; set; } 
        public bool IsCompleted { get; set; }

        
    }
}
