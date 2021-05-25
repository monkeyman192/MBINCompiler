using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x89F8948FA2B8AD2A, NameHash = 0xC652A220FFABA4FE)]
    public class GcProjectileImpactType : NMSTemplate
    {
        // size: 0xF
        public enum ImpactEnum {
            Default, Terrain, Substance, Rock, Asteroid, Shield, Creature, Robot,
            Freighter, Cargo, Ship, Plant, NeedsTech, Player, OtherPlayer
        }
        public ImpactEnum Impact;
    }
}
