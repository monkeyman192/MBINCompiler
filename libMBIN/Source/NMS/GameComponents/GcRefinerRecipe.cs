using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x70, GUID = 0x6F96CB41617F4C19, NameHash = 0x309D52938C546138)]
    public class GcRefinerRecipe : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Id;
        /* 0x20 */ public NMSString0x20A Name;
        /* 0x40 */ public float TimeToMake;
        /* 0x44 */ public bool Cooking;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x45 */ public byte[] Padding45;
        /* 0x48 */ public GcRefinerRecipeElement Result;
        /* 0x60 */ public List<GcRefinerRecipeElement> Ingredients;
    }
}
