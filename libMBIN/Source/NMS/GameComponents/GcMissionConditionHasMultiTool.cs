using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE48CA3A293E9A35B, NameHash = 0xF65D2CFF75A05B47)]
    public class GcMissionConditionHasMultiTool : NMSTemplate
    {
        public GcInventoryClass InventoryClass;
        public bool CheckAllTools;
        public bool BetterClassMatches;
        public bool TakeValueFromSeasonData;
    }
}
