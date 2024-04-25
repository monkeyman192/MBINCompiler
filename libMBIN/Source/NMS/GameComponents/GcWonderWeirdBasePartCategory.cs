namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC4FD35234E48565C, NameHash = 0xBF7B60D4CA07A9C0)]
    public class GcWonderWeirdBasePartCategory : NMSTemplate
    {
        // size: 0xB
        public enum WonderWeirdBasePartCategoryEnum : uint {
            EngineOrb,
            BeamStone,
            BubbleCluster,
            MedGeometric,
            Shard,
            StarJoint,
            BoneGarden,
            ContourPod,
            HydroPod,
            ShellWhite,
            WeirdCube,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WonderWeirdBasePartCategoryEnum WonderWeirdBasePartCategory;
    }
}
