using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x58, GUID = 0x9586CD35800C5D18, NameHash = 0x4845AFA2BB576F24)]
    public class GcAtlasSendMarkFeaturedBaseWithImage : NMSTemplate
    {
        /* 0x00 */ public ulong ClientUserdata;
        /* 0x08 */ public NMSString0x40 BaseID;
        /* 0x48 */ public NMSString0x10 Image;
    }
}
