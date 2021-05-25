using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x14, GUID = 0x94DAC816194EB386, NameHash = 0x8531B20A02DD0931)]
    public class GcScanData : NMSTemplate
    {
        // size: 0xB
        public enum ScanTypeEnum { Tool, Beacon, RadioTower, Observatory, DistressSignal, Waypoint, Ship, DebugPlanet, DebugSpace, VisualOnly, VisualOnlyAerial }
		/* 0x00 */ public ScanTypeEnum ScanType;
	    /* 0x04 */ public float PulseRange;          // 41200000h
	    /* 0x08 */ public float PulseTime;           // 41200000h
	    /* 0x0C */ public bool PlayAudioOnMarkers;   // 1
	    /* 0x10 */ public float ChargeTime;          // 40800000h
    }
}
