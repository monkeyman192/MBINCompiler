using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE9DDAD00F059FF0A, NameHash = 0x73B8C106776DC488)]
    public class GcCustomisationThrusterJet : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 Effect;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 LocatorPrefix;
        [NMS(Index = 2)]
        /* 0x20 */ public TkModelResource JetMesh;
        [NMS(Index = 3)]
        /* 0xA4 */ public TkModelResource Trail;
    }
}
