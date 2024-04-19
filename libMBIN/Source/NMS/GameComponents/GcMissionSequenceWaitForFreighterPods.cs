namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x41556C893A6A3E2, NameHash = 0x779C608FD9761375)]
    public class GcMissionSequenceWaitForFreighterPods : NMSTemplate
    {
        /* 0x000 */ public int Amount;
        /* 0x004 */ public NMSString0x80 DebugText;
        /* 0x084 */ public NMSString0x80 Message;
        /* 0x104 */ public bool TakeAmountFromPulseEncounter;
    }
}
