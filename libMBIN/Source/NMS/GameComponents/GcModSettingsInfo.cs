using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF658C5CC0A4A78DE, NameHash = 0xC0CE6220E5E98BD9)]
    public class GcModSettingsInfo : NMSTemplate
    {
        /* 0x000 */ public List<ulong> Dependencies;
        /* 0x010 */ public ulong AuthorID;
        /* 0x018 */ public ulong ID;
        /* 0x020 */ public ulong LastUpdated;
        /* 0x028 */ public ushort LoadOrder;
        /* 0x02A */ public NMSString0x80 Author;
        /* 0x0AA */ public NMSString0x80 Name;
        /* 0x12A */ public bool Enabled;
        /* 0x12B */ public bool EnabledVR;
    }
}
