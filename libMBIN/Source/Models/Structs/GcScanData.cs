namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x14)]
    public class GcScanData : NMSTemplate
    {
		public enum ScanTypeEnum { Tool, Beacon, RadioTower, Observatory, DistressSignal, Waypoint, Ship, DebugPlanet, DebugSpace, VisualOnly }
		public ScanTypeEnum ScanType;
	  /* 0x004 */ public float PulseRange;          // 41200000h
	  /* 0x008 */ public float PulseTime;           // 41200000h
	  /* 0x00C */ public bool PlayAudioOnMarkers;   // 1
	  /* 0x010 */ public float ChargeTime;          // 40800000h
    }
}
