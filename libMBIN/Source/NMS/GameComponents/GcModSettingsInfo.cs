using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF658C5CC0A4A78DE, NameHash = 0xC0CE6220E5E98BD9)]
    public class GcModSettingsInfo : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x000 */ public List<ulong> Dependencies;
        [NMS(Index = 3)]
        /* 0x010 */ public ulong AuthorID;
        [NMS(Index = 2)]
        /* 0x018 */ public ulong ID;
        [NMS(Index = 4)]
        /* 0x020 */ public ulong LastUpdated;
        [NMS(Index = 5)]
        /* 0x028 */ public ushort LoadOrder;
        [NMS(Index = 1)]
        /* 0x02A */ public NMSString0x80 Author;
        [NMS(Index = 0)]
        /* 0x0AA */ public NMSString0x80 Name;
        [NMS(Index = 6)]
        /* 0x12A */ public bool Enabled;
        [NMS(Index = 7)]
        /* 0x12B */ public bool EnabledVR;
    }
}
