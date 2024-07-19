namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE087386F100C7DD3, NameHash = 0xA866E946)]
    public class GcTerrainOverlayColours : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public float Cutoff;
        [NMS(Index = 3)]
        /* 0x04 */ public float FlightStrength;
        [NMS(Index = 5)]
        /* 0x08 */ public float PulsePeriod;
        [NMS(Index = 4)]
        /* 0x0C */ public float PulseStrength;
        [NMS(Index = 1)]
        /* 0x10 */ public float Scale;
        [NMS(Index = 2)]
        /* 0x14 */ public float Strength;
    }
}
