namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xADA26EA67A0AA85C, NameHash = 0xB6F9D0E7CC7397EC)]
    public class GcWonderRecord : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x2)]
        /* 0x00 */ public ulong[] GenerationID;
        [NMS(Index = 1)]
        /* 0x10 */ public float WonderStatValue;
        [NMS(Index = 2)]
        /* 0x14 */ public bool SeenInFrontend;
    }
}
