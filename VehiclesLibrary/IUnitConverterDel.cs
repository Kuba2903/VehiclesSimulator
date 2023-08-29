using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLibrary
{
    public interface IUnitConverterDel
    {
        public delegate void UnitConverterEventHandler(object source, EventArgs e);
        public event UnitConverterEventHandler UnitConverter;
    }
}
