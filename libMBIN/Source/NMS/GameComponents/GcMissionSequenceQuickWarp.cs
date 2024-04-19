namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4F9277F3701200F0, NameHash = 0xFAB38B2DF669FFB3)]
    public class GcMissionSequenceQuickWarp : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A ScanEventToWarpTo;
        /* 0x020 */ public NMSString0x10 CameraShakeID;
        /* 0x030 */ public float EffectTime;
        /* 0x034 */ public float SequenceTime;
        /* 0x038 */ public NMSString0x80 DebugText;
        /* 0x0B8 */ public NMSString0x80 MessageCannotWarp;
        /* 0x138 */ public NMSString0x80 MessageWarping;
        /* 0x1B8 */ public bool DoCameraShake;
        /* 0x1B9 */ public bool DoWhiteout;
    }
}
