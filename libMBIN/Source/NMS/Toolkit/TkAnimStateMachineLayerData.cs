using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA73DCA78D736C9EB, NameHash = 0x367D7C3)]
    public class TkAnimStateMachineLayerData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkAnimStateMachineData StateMachineContainer;
        [NMS(Index = 0)]
        /* 0x48 */ public NMSString0x10 Id;
    }
}
