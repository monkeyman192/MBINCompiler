using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3574C34B687AFFE5, NameHash = 0x370A2ECAE460B961)]
    public class GcPetVocabularyEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A GenericFallback;
        /* 0x20 */ public List<GcPetVocabularyTraitEntry> Vocabulary;
        /* 0x30 */ public float OddsOfProcReplacement;
    }
}
