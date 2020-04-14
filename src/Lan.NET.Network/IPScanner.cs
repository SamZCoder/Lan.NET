using Lan.NET.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lan.NET.Network
{
    public class IPScanner
    {

        public delegate void ScanCompleteDelegate();

        public event ScanCompleteDelegate ScanCompleted;

        public delegate void IPScannedDelegate(IPScanResult result);

        public event IPScannedDelegate IPScanned;

        public Int32 DefaultTimeout { get; set; } = 500;

        public IPScanner()
        {

        }

        public void ScanRange(String StartAddr, String EndAddr)
        {
            ScanRange(IPAddress.Parse(StartAddr), IPAddress.Parse(EndAddr));
        }

        public void ScanRange(IPAddress StartAddr, IPAddress EndAddr)
        {
            Task.Run(() =>
            {
                Ping PingRequest = new Ping();
                PingReply PingResponse;
                IEnumerator<String> IPEnumrator = GetRangedIPs(StartAddr, EndAddr);
                while(IPEnumrator.MoveNext())
                {
                    PingResponse = PingRequest.Send(IPEnumrator.Current, DefaultTimeout);
                    IPScanned?.Invoke(new IPScanResult()
                    {
                        Address = IPAddress.Parse(IPEnumrator.Current),
                        IsOnline = PingResponse.Status == IPStatus.Success,
                        Status = PingResponse.Status
                    });
                }
            });
        }

        protected IEnumerator<String> GetRangedIPs(IPAddress Start, IPAddress End)
        {
            return GetRangedIPs(Start.ToString(), End.ToString());
        }

        public IEnumerator<String> GetRangedIPs(String Start, String End)
        {
            List<String> IPList = new List<String>();
            String[] StartSegments = Start.Split('.');
            String[] EndSegments = End.Split('.');
            for(int SegmentIndex = 0; SegmentIndex < 4; SegmentIndex++)
            {
                List<String> TempList = new List<String>();
                Int32 CurrentStartSegment = Convert.ToInt32(StartSegments[SegmentIndex]);
                Int32 CurrentEndSegment = Convert.ToInt32(EndSegments[SegmentIndex]);

                Int32[] SegmentRange = Enumerable.Range(CurrentStartSegment, CurrentEndSegment - CurrentStartSegment + 1).ToArray();
                String Seprator = SegmentIndex == 3 ? "" : ".";
                foreach (Int32 Iteration in SegmentRange)
                {
                    if(IPList.Count == 0) { TempList.Add(Iteration + "."); }
                    foreach(String RegisteredIP in IPList)
                    {
                        String CurrentIP = RegisteredIP + Iteration + Seprator;
                        TempList.Add(CurrentIP);
                        if(SegmentIndex == 3)
                        {
                            yield return CurrentIP;
                        }
                    }
                }
                IPList = TempList;
            }
        }
    }
}
