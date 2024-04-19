using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7B01B326678584BC, NameHash = 0x56A2461EC4620A47)]
    public class GcCostInteractionMissionState : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A CanAffordLocID;
        /* 0x20 */ public NMSString0x20A CantAffordLocID;
        /* 0x40 */ public GcInteractionMissionState RequiredState;
        /* 0x44 */ public GcInteractionType ThisInteractionClassInMyBuilding;
        /* 0x48 */ public bool AlsoAcceptMaintenanceDone;
        /* 0x49 */ public bool TestThisInteraction;
    }
}
