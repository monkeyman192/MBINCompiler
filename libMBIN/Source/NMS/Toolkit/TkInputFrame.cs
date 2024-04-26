namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xFEBE52C18D488494, NameHash = 0xF3DC604B80A24AD)]
    public class TkInputFrame : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Vector2f LeftStick;
        [NMS(Index = 1)]
        /* 0x08 */ public Vector2f RightStick;
        [NMS(Index = 2)]
        /* 0x10 */ public float LeftTrigger;
        [NMS(Index = 3)]
        /* 0x14 */ public float RightTrigger;
        [NMS(Index = 4)]
        /* 0x18 */ public short Buttons;
    }
}
