using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLibrary
{
    public interface IUnitConverterDel
    {
        /// <summary>
        /// Method signature
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        public delegate void UnitConverterEventHandler(object source, EventArgs e);
        /// <summary>
        /// Event handler needs to have delegate method assigned
        /// </summary>
        public event UnitConverterEventHandler UnitConverter;
    }
}
