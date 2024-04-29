using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2921DBBD1757EA66, NameHash = 0xCDB7AC6D11C9DF03)]
    public class GcCustomisationTextureOption : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 Group;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 Layer;
        [NMS(Index = 3)]
        /* 0x20 */ public List<NMSString0x20A> Options;
        [NMS(Index = 0)]
        /* 0x30 */ public NMSString0x10 TextureOptionsID;
        [NMS(Index = 4)]
        /* 0x40 */ public List<NMSString0x20A> Tips;
    }
}
