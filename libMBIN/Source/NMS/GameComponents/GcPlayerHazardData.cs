using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD6B6AC08F3007F1F, NameHash = 0x18642126695741B5)]
    public class GcPlayerHazardData : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public NMSString0x10 Damage;
        [NMS(Index = 2)]
        /* 0x10 */ public Vector2f DamageRate;
        [NMS(Index = 1)]
        /* 0x18 */ public Vector2f ProtectionTime;
        [NMS(Index = 3)]
        /* 0x20 */ public Vector2f WoundRate;
        [NMS(Index = 10)]
        /* 0x28 */ public float CapValue;
        [NMS(Index = 11)]
        /* 0x2C */ public float CriticalValue;
        [NMS(Index = 14)]
        /* 0x30 */ public float OutputMaxAddition;
        [NMS(Index = 13)]
        /* 0x34 */ public float OutputMinAddition;
        [NMS(Index = 12)]
        /* 0x38 */ public float OutputMultiplier;
        [NMS(Index = 0)]
        /* 0x3C */ public float ProtectionInitialTime;
        [NMS(Index = 4)]
        /* 0x40 */ public float RechargeInitialTime;
        [NMS(Index = 5)]
        /* 0x44 */ public float RechargeTime;
        [NMS(Index = 9)]
        /* 0x48 */ public float TriggerValue;
        [NMS(Index = 8)]
        /* 0x4C */ public TkCurveType DisplayCurve;
        [NMS(Index = 7)]
        /* 0x4D */ public bool Increases;
    }
}
