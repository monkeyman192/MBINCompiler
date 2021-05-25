using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x6476C8FAA37A51C2, NameHash = 0x82204A5605D64063)]
    public class GcPetBehaviours : NMSTemplate
    {
        // size: 0x1C
        public enum PetBehaviourEnum { 
            None, Idle, Eat, Poop, LayEgg, FollowPlayer, AdoptedFollowPlayer, ScanForResource, FindResource, FindHazards, AttackHazard,
            FindBuilding, Fetch, Explore, Emote, GestureReact, OrderedToPos, ComeHere, Mine, Summoned, Adopted, Hatched, PostInteract, Rest,
            Attack, Watch, Greet, TeleportToPlayer
            }
        /* 0x0 */ public PetBehaviourEnum PetBehaviour;
    }
}
