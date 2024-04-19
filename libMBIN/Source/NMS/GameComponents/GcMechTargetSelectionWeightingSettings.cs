namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x88B34845F702A880, NameHash = 0x5CE6C6E85ABBB6DB)]
    public class GcMechTargetSelectionWeightingSettings : NMSTemplate
    {
        /* 0x00 */ public float CloseDistance;
        /* 0x04 */ public float CloseDistanceWeightFactorExponent;
        /* 0x08 */ public float DistanceWeightFactorBase;
        /* 0x0C */ public float FarDistance;
        /* 0x10 */ public float FarDistanceWeightFactorExponent;
        /* 0x14 */ public float FwdDirectionWeightFactorBase;
        /* 0x18 */ public float MidDistance;
        /* 0x1C */ public float MidDistanceWeightFactorExponent;
        /* 0x20 */ public float ThreatWeightFactorBase;
        /* 0x24 */ public float VeryCloseDistance;
        /* 0x28 */ public float VeryCloseDistanceWeightFactorExponent;
        /* 0x2C */ public float VeryFarDistanceWeightFactorExponent;
    }
}
