using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    [Serializable]
    public class LogOutRequest
    {
        public int PID = 0;
        public string UserId = string.Empty;
        public string DeviceId = string.Empty;
    }
}
