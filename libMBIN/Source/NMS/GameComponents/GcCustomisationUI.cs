using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD5B0D2740307A549, NameHash = 0x9391BB23A2DA934)]
    public class GcCustomisationUI : NMSTemplate
    {
        /* 0x00 */ public GcCustomisationGroups Common;
        /* 0x10 */ public List<GcCustomisationRace> Races;
        /* 0x20 */ public GcCustomisationCameraData RacesCameraData;
    }
}
