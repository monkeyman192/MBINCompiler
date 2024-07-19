using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCF57C38D6605E44B, NameHash = 0xCF763D)]
    public class GcCostInteractionMissionState : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A CanAffordLocID;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20A CantAffordLocID;
        [NMS(Index = 0)]
        /* 0x40 */ public GcInteractionMissionState RequiredState;
        [NMS(Index = 5)]
        /* 0x44 */ public GcInteractionType ThisInteractionClassInMyBuilding;
        [NMS(Index = 3)]
        /* 0x48 */ public bool AlsoAcceptMaintenanceDone;
        [NMS(Index = 4)]
        /* 0x49 */ public bool TestThisInteraction;
    }
}
