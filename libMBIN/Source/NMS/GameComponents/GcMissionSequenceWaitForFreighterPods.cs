namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6537BF60A4AAB12B, NameHash = 0x779C608FD9761375)]
    public class GcMissionSequenceWaitForFreighterPods : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public int Amount;
        [NMS(Index = 3)]
        /* 0x004 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x084 */ public NMSString0x80 Message;
        [NMS(Index = 2)]
        /* 0x104 */ public bool TakeAmountFromPulseEncounter;
    }
}
