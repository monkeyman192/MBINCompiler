using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6014A71F79C6A516, NameHash = 0x5CE6C6E85ABBB6DB)]
    public class GcMechTargetSelectionWeightingSettings : NMSTemplate
    {
        /* 0x00 */ public float ThreatWeightFactorBase;
        /* 0x04 */ public float FwdDirectionWeightFactorBase;
        /* 0x08 */ public float DistanceWeightFactorBase;
        /* 0x0C */ public float VeryCloseDistance;
        /* 0x10 */ public float VeryCloseDistanceWeightFactorExponent;
        /* 0x14 */ public float CloseDistance;
        /* 0x18 */ public float CloseDistanceWeightFactorExponent;
        /* 0x1C */ public float MidDistance;
        /* 0x20 */ public float MidDistanceWeightFactorExponent;
        /* 0x24 */ public float FarDistance;
        /* 0x28 */ public float FarDistanceWeightFactorExponent;
        /* 0x2C */ public float VeryFarDistanceWeightFactorExponent;
    }
}
