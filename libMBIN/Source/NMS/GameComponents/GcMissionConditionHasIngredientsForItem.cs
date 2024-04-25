using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEAD7D437BD0066A8, NameHash = 0x84BBBF70C34631CA)]
    public class GcMissionConditionHasIngredientsForItem : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A TakeTargetItemsFromScanEvent;
        [NMS(Index = 0)]
        /* 0x20 */ public List<NMSString0x10> TargetItems;
        [NMS(Index = 3)]
        /* 0x30 */ public int ExpectedTargetItemsFromScanEvent;
        [NMS(Index = 6)]
        /* 0x34 */ public int HorribleJustFormatTargetAmount;
        [NMS(Index = 2)]
        /* 0x38 */ public GcMaintenanceElementGroups ScanEventTargetGroup;
        [NMS(Index = 5)]
        /* 0x3C */ public bool FormatTextOneReqAtATime;
        [NMS(Index = 8)]
        /* 0x3D */ public bool NeverReturnTrueOnlyUseForFormatting;
        [NMS(Index = 7)]
        /* 0x3E */ public bool Repair;
        [NMS(Index = 4)]
        /* 0x3F */ public bool TakeTargetFromSeasonData;
    }
}
