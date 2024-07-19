namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x79BF508B8E03FF5, NameHash = 0x3F67C43C)]
    public class GcCostMissionComplete : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A TextOverride;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 Cost;
        [NMS(Index = 2)]
        /* 0x30 */ public bool HideIfCompleted;
    }
}
