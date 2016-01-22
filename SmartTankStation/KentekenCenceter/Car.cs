using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CarCenter
{
    public class Car
    {
        public string Licenseplate { get; private set; }
        public TypeOfFuel Fueltype { get; private set; }
        public Owner Owner { get; private set; }
        /// <summary>
        /// Create a car without a owner
        /// </summary>
        /// <param name="licenseplate"></param>
        /// <param name="fueltype"></param>
        /// <param name="owner"></param>
        public Car(string licenseplate, TypeOfFuel fueltype, Owner owner)
        {
            Licenseplate = licenseplate;
            Fueltype     = fueltype;
            Owner        = owner;
        }

        public override string ToString()
        {
            return Owner.Name + " - " + Licenseplate + " - " + Fueltype.ToString();
        }
    }
}
