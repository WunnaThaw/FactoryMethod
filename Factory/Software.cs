using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>

    class Software : Computer
    {
        // Factory Method implementation
        public override void SetupDevelopments()
        {
            Developments.Add(new MobileDevelopment());
            Developments.Add(new WebDevelopment());
            Developments.Add(new DesktopDevelopment());
        }
    }
}
