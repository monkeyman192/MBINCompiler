using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcScanData : NMSTemplate
    {
        public int ScanType;
        public string[] ScanTypeValues()
        {
            return new[] { "Tool", "Beacon", "RadioTower", "Observatory", "DistressSignal", "Waypoint", "Ship", "DebugPlanet", "DebugSpace" };
        }

        public float PulseRange;
        public float PulseTime;
        public bool PlayAudioMarkers;
        public float ChargeTime;
    }
}
