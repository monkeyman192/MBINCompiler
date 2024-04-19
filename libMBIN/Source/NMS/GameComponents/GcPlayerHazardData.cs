using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x362521D640B1A7DE, NameHash = 0x18642126695741B5)]
    public class GcPlayerHazardData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Damage;
        /* 0x10 */ public Vector2f DamageRate;
        /* 0x18 */ public Vector2f ProtectionTime;
        /* 0x20 */ public Vector2f WoundRate;
        /* 0x28 */ public float CapValue;
        /* 0x2C */ public float CriticalValue;
        /* 0x30 */ public float OutputMaxAddition;
        /* 0x34 */ public float OutputMinAddition;
        /* 0x38 */ public float OutputMultiplier;
        /* 0x3C */ public float ProtectionInitialTime;
        /* 0x40 */ public float RechargeInitialTime;
        /* 0x44 */ public float RechargeTime;
        /* 0x48 */ public float TriggerValue;
        /* 0x4C */ public TkCurveType DisplayCurve;
        /* 0x4D */ public bool Increases;
    }
}
