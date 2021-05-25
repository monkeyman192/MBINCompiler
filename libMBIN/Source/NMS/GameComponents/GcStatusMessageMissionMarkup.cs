using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xCB39899C49E9126, NameHash = 0x8E8EC2C807363E97)]
    public class GcStatusMessageMissionMarkup : NMSTemplate
    {
        // size: 0x10
        public enum MissionMarkupEnum { KillFiend, KillPirate, KillSentinel, KillHazardousPlants, KillTraders, KillCreatures, KillPredators, KillDepot, FeedCreature,
            CollectBones, CollectScrap, Discover, CollectSubstanceProduct, Build, Always, None }
        public MissionMarkupEnum MissionMarkup;
    }
}