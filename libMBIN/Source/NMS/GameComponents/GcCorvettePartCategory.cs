using System;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x32CD6C9B1F5283FC, NameHash = 0x42559895)]
    public class GcCorvettePartCategory : NMSTemplate
    {
        // size: 0xF
        [Flags]
        public enum CorvettePartCategoryEnum : uint {
            None = 0x0,
            Cockpit = 0x1,
            Hab = 0x2,
            Gear = 0x4,
            Gun = 0x8,
            Shield = 0x10,
            Hull = 0x20,
            Access = 0x40,
            Wing = 0x80,
            Engine = 0x100,
            Reactor = 0x200,
            Connector = 0x400,
            Decor = 0x800,
            Interior = 0x1000,
            TractorBeam = 0x2000,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CorvettePartCategoryEnum CorvettePartCategory;
    }
}
