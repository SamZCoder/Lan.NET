using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Lan.NET.Domain
{
    public class IPScanResult
    {
        public IPAddress Address { get; set; }
        public Boolean IsOnline { get; set; }
        public IPStatus Status { get; set; }
    }
}
