using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA801F76738B0CD88, NameHash = 0x496780B)]
    public class GcSolarSystemLocator : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public Vector3f Direction;
        [NMS(Index = 2)]
        /* 0x10 */ public Vector3f Position;
        [NMS(Index = 4)]
        /* 0x20 */ public float Radius;
        [NMS(Index = 1)]
        /* 0x24 */ public GcSolarSystemLocatorTypes Type;
        [NMS(Index = 0)]
        /* 0x28 */ public NMSString0x20 Name;
    }
}
