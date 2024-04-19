using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEAD7D437BD0066A8, NameHash = 0x84BBBF70C34631CA)]
    public class GcMissionConditionHasIngredientsForItem : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A TakeTargetItemsFromScanEvent;
        /* 0x20 */ public List<NMSString0x10> TargetItems;
        /* 0x30 */ public int ExpectedTargetItemsFromScanEvent;
        /* 0x34 */ public int HorribleJustFormatTargetAmount;
        /* 0x38 */ public GcMaintenanceElementGroups ScanEventTargetGroup;
        /* 0x3C */ public bool FormatTextOneReqAtATime;
        /* 0x3D */ public bool NeverReturnTrueOnlyUseForFormatting;
        /* 0x3E */ public bool Repair;
        /* 0x3F */ public bool TakeTargetFromSeasonData;
    }
}
