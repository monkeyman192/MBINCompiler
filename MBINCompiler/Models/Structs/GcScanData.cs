namespace MBINCompiler.Models.Structs
{
    public class GcScanData : NMSTemplate 
    {
	  /* 0x000 */ public int ScanType;
	  public string[] ScanTypeValues()
        {
            return new[] { "Tool", "Beacon", "RadioTower", "Observatory", "DistressSignal", "Waypoint", "Ship", "DebugPlanet", "DebugSpace" };
        }
	  /* 0x004 */ public float PulseRange;
	  /* 0x008 */ public float PulseTime;
	  /* 0x00C */ public bool PlayAudioOnMarkers;
	  /* 0x010 */ public float ChargeTime;
    }
}
