namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x40, Alignment = 0x8)]
    public class GcMissionConditionBasePartBuilt : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string PartID;
        /* 0x10 */ public int Count;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x14 */ public byte[] Padding14;
        /* 0x18 */ public GcBuildingPartSearchType Type;
        /* 0x38 */ public int PartInCurrentBase;
        public string[] PartInCurrentBaseValues()
        {
            return new[] { "DontCare", "YesAllPlayerOwned"};
        }
    }
}
