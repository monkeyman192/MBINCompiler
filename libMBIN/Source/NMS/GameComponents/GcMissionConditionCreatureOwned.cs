using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7C176A230F59889E, NameHash = 0x1518FAA28FFA87F7)]
    public class GcMissionConditionCreatureOwned : NMSTemplate
    {
        /* 0x00 */ public int Amount;
        /* 0x04 */ public TkEqualityEnum Test;
        /* 0x08 */ public NMSString0x10 SpecificCreatureID;
        /* 0x18 */ public bool AnyPredator;
    }
}
