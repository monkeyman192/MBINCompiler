using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB9CC2A1F5834A129, NameHash = 0xFF746C1098C0C4DE)]
    public class GcEncounterType : NMSTemplate
    {
        // size: 0x7
        public enum EncounterTypeEnum { FactoryGuards, HarvesterGuards, ScrapHeap, Reward, CorruptedDroneInteract, GroundWorms, DroneHiveGuards }
        public EncounterTypeEnum EncounterType;
    }
}
