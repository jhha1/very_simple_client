using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    [Serializable]
    public class LogInRequest
    {
        public int PID = 0;
        public int PlatformType = -1;
        public string UserId = string.Empty;
        public string DeviceId = string.Empty;

        public enum PLATFORM_TYPE
        {
            [NonSerialized]
            GUEST, GOOGLE, FACEBOOK
        }
    }
}
