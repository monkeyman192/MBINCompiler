using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD5DC1FC5AF0969E4, NameHash = 0x09391BB23A2DA934)]
    public class GcCustomisationUI : NMSTemplate
    {
        /* 0x00 */ public GcCustomisationCameraData RacesCameraData;
        /* 0x38 */ public List<GcCustomisationRace> Races;
        /* 0x48 */ public GcCustomisationGroups Common;
    }
}
