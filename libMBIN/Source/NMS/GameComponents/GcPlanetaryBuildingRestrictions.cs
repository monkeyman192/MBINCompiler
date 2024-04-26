namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF7D92CBED552638A, NameHash = 0x20CBBE7621E0A37C)]
    public class GcPlanetaryBuildingRestrictions : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public bool RequiresCorruptSentinels;
        [NMS(Index = 1)]
        /* 0x1 */ public bool RequiresWater;
    }
}
