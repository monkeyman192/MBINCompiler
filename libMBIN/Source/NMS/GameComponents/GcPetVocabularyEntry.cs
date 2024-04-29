using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF561F768E1D96F8C, NameHash = 0x370A2ECAE460B961)]
    public class GcPetVocabularyEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A GenericFallback;
        [NMS(Index = 2)]
        /* 0x20 */ public List<GcPetVocabularyTraitEntry> Vocabulary;
        [NMS(Index = 1)]
        /* 0x30 */ public float OddsOfProcReplacement;
    }
}
