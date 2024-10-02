using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App_v0._1.Classes
{
    public static class MaintenanceMode
    {
        private static bool _enabled = false;

        public static event EventHandler<bool> EnabledChanged;

        public static bool Enabled
        {
            get { return _enabled; }
            private set
            {
                _enabled = value;
                EnabledChanged?.Invoke(null, _enabled);
            }
        }

        public static void EnterMaintenance(bool enabled)
        {
            if (enabled == true)
            {
                _enabled = enabled;
            }
        }
    }
}
