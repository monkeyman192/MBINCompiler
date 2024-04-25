namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4F9277F3701200F0, NameHash = 0xFAB38B2DF669FFB3)]
    public class GcMissionSequenceQuickWarp : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public NMSString0x20A ScanEventToWarpTo;
        [NMS(Index = 4)]
        /* 0x020 */ public NMSString0x10 CameraShakeID;
        [NMS(Index = 8)]
        /* 0x030 */ public float EffectTime;
        [NMS(Index = 7)]
        /* 0x034 */ public float SequenceTime;
        [NMS(Index = 2)]
        /* 0x038 */ public NMSString0x80 DebugText;
        [NMS(Index = 1)]
        /* 0x0B8 */ public NMSString0x80 MessageCannotWarp;
        [NMS(Index = 0)]
        /* 0x138 */ public NMSString0x80 MessageWarping;
        [NMS(Index = 5)]
        /* 0x1B8 */ public bool DoCameraShake;
        [NMS(Index = 6)]
        /* 0x1B9 */ public bool DoWhiteout;
    }
}
