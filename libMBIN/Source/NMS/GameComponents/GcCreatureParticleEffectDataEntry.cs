using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x65B802B902D00DCA, NameHash = 0xBAAF5598)]
    public class GcCreatureParticleEffectDataEntry : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public VariableSizeString EffectLocator;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 EffectName;
        [NMS(Index = 5)]
        /* 0x20 */ public List<NMSTemplate> Requirements;
        [NMS(Index = 2)]
        /* 0x30 */ public float Scale;
        [NMS(Index = 3)]
        /* 0x34 */ public bool Attached;
        [NMS(Index = 4)]
        /* 0x35 */ public bool DetachOnRetire;
    }
}
