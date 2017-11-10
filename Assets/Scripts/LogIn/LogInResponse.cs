using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    [Serializable]
    public class LogInResponse
    {
        public int PID = 0;
        public string CODE = "";
        public string MSG = string.Empty;
        public string USERID = string.Empty;
    }
}
