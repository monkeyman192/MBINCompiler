using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEEF433CCED95C3D8, NameHash = 0x1A45D4DF)]
    public class GcSelectableObjectList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Name;
        [NMS(Index = 2)]
        /* 0x10 */ public List<GcSelectableObjectData> Options;
        [NMS(Index = 1)]
        /* 0x20 */ public GcAlienRace Race;
    }
}
