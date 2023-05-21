using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    abstract class Computer
    {
        private List<Development> _developments = new List<Development>();

        // Constructor calls abstract Factory method
        public Computer()
        {
            this.SetupDevelopments();
        }
        public List<Development> Developments
        {
            get { return _developments; }
        }

        // Factory Method
        public abstract void SetupDevelopments();
    }
}
