using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// B 'ConcreteCreator' class
    /// </summary>

    class Hardware : Computer
    {
        // Factory Method implementation
        public override void SetupDevelopments()
        {
            Developments.Add(new CPUDevelopment());
            Developments.Add(new HardDriveDevelopment());
        }
    }
}
