namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x88B34845F702A880, NameHash = 0x5CE6C6E85ABBB6DB)]
    public class GcMechTargetSelectionWeightingSettings : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public float CloseDistance;
        [NMS(Index = 6)]
        /* 0x04 */ public float CloseDistanceWeightFactorExponent;
        [NMS(Index = 2)]
        /* 0x08 */ public float DistanceWeightFactorBase;
        [NMS(Index = 9)]
        /* 0x0C */ public float FarDistance;
        [NMS(Index = 10)]
        /* 0x10 */ public float FarDistanceWeightFactorExponent;
        [NMS(Index = 1)]
        /* 0x14 */ public float FwdDirectionWeightFactorBase;
        [NMS(Index = 7)]
        /* 0x18 */ public float MidDistance;
        [NMS(Index = 8)]
        /* 0x1C */ public float MidDistanceWeightFactorExponent;
        [NMS(Index = 0)]
        /* 0x20 */ public float ThreatWeightFactorBase;
        [NMS(Index = 3)]
        /* 0x24 */ public float VeryCloseDistance;
        [NMS(Index = 4)]
        /* 0x28 */ public float VeryCloseDistanceWeightFactorExponent;
        [NMS(Index = 11)]
        /* 0x2C */ public float VeryFarDistanceWeightFactorExponent;
    }
}
