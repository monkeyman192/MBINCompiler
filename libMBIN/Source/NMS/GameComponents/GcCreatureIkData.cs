using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x244274B9B0B2910C, NameHash = 0x3B356CAA76CA79F8)]
    public class GcCreatureIkData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcCreatureIkType Type;
        [NMS(Index = 1)]
        /* 0x4 */ public NMSString0x100 JointName;
    }
}
