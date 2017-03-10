namespace MBINCompiler.Models.Structs
{
    public class GcBaseBuildingComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string RegisterID;
        /* 0x010 */ public GcPersistentBaseTypes Type;
    }
}