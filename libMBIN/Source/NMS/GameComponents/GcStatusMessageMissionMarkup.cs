namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBE39D03F2CDE8335, NameHash = 0x8E8EC2C807363E97)]
    public class GcStatusMessageMissionMarkup : NMSTemplate
    {
        // size: 0x11
        public enum MissionMarkupEnum : uint {
            KillFiend,
            KillPirate,
            KillSentinel,
            KillHazardousPlants,
            KillTraders,
            KillCreatures,
            KillPredators,
            KillDepot,
            KillWorms,
            FeedCreature,
            CollectBones,
            CollectScrap,
            Discover,
            CollectSubstanceProduct,
            Build,
            Always,
            None,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MissionMarkupEnum MissionMarkup;
    }
}
