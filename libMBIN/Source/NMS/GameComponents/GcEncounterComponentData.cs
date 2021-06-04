using libMBIN.NMS.Toolkit;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0xF6476E87C35043E4, NameHash = 0x1BAD68301EABDA5C)]
    public class GcEncounterComponentData : NMSTemplate
    {
        public enum EncounterTypeEnum { FactoryGuards, HarvesterGuards, ScrapHeap, CorruptedDroneReward, CorruptedDroneInteract }
        public EncounterTypeEnum EncounterType;
        public List<NMSString0x10> InteractMissionTable;
    }
}