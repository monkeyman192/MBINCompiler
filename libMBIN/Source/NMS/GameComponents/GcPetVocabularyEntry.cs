using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x39061A95706175B3, NameHash = 0x370A2ECAE460B961)]
    public class GcPetVocabularyEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A GenericFallback;
        /* 0x20 */ public float OddsOfProcReplacement;
        /* 0x28 */ public List<GcPetVocabularyTraitEntry> Vocabulary;
    }
}
