namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE814BD4EE11B207A, NameHash = 0xE3E7C630)]
    public class GcDrainedTerrainResourceDeposit : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector3f Position;
        [NMS(Index = 0)]
        /* 0x10 */ public ulong GalacticAddress;
    }
}
