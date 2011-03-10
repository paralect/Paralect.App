using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paralect.App.Test
{
    public class Tracker
    {
        public List<Type> ModulesInStartOrder { get; set; }
        public List<Type> ModulesInEndOrder { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        public Tracker()
        {
            ModulesInStartOrder = new List<Type>();
            ModulesInEndOrder = new List<Type>();
        }
    }
}
