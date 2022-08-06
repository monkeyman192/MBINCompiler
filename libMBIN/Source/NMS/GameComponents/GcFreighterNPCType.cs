using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA41EE807A4839393, NameHash = 0xC53DA60AB5E3B8A5)]
    public class GcFreighterNPCType : NMSTemplate
    {
        // size: 0x5
        public enum FreighterNPCTypeEnum { SquadronPilot, FrigateCaptain, WorkerBio, WorkerTech, WorkerIndustry }
        public FreighterNPCTypeEnum FreighterNPCType;
    }
}
