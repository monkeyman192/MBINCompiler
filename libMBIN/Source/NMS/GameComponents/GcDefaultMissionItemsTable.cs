using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB61378ABA919F3CC, NameHash = 0x87FB8E825C599E66)]
    public class GcDefaultMissionItemsTable : NMSTemplate
    {
        /* 0x00 */ public List<GcDefaultMissionSubstance> PrimarySubstances;
        /* 0x10 */ public List<GcDefaultMissionSubstance> SecondarySubstances;
        /* 0x20 */ public List<GcDefaultMissionProduct> PrimaryProducts;
        /* 0x30 */ public List<GcDefaultMissionProduct> SecondaryProducts;
    }
}
