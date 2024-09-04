using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7885626087C6D1F8, NameHash = 0x9677B142)]
    public class GcRewardActivateFiends : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public NMSString0x20A ActiveFailureOSD;
        [NMS(Index = 5)]
        /* 0x20 */ public NMSString0x20A WaterFailureOSD;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x10 SpawnID;
        [NMS(Index = 1)]
        /* 0x50 */ public GcFiendCrime CrimeType;
        [NMS(Index = 3)]
        /* 0x54 */ public bool AllowInWater;
        [NMS(Index = 2)]
        /* 0x55 */ public bool FailIfAlreadyActive;
    }
}
