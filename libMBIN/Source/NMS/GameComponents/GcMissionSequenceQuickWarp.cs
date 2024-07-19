namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x663AEA32A792A2CE, NameHash = 0x2D93EAFA)]
    public class GcMissionSequenceQuickWarp : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x20A ScanEventToWarpTo;
        [NMS(Index = 4)]
        /* 0x20 */ public NMSString0x10 CameraShakeID;
        [NMS(Index = 2)]
        /* 0x30 */ public VariableSizeString DebugText;
        [NMS(Index = 1)]
        /* 0x40 */ public VariableSizeString MessageCannotWarp;
        [NMS(Index = 0)]
        /* 0x50 */ public VariableSizeString MessageWarping;
        [NMS(Index = 8)]
        /* 0x60 */ public float EffectTime;
        [NMS(Index = 7)]
        /* 0x64 */ public float SequenceTime;
        [NMS(Index = 5)]
        /* 0x68 */ public bool DoCameraShake;
        [NMS(Index = 6)]
        /* 0x69 */ public bool DoWhiteout;
    }
}
