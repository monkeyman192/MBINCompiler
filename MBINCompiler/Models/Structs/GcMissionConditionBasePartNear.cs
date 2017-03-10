namespace MBINCompiler.Models.Structs
{
    public class GcMissionConditionBasePartNear : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string PartID;
        /* 0x10 */ public float Distance;
    }
}
