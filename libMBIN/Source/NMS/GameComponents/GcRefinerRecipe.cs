using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x17AA7FEA362BC5A8, NameHash = 0x309D52938C546138)]
    public class GcRefinerRecipe : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Id;
        /* 0x20 */ public NMSString0x20A RecipeType;
        /* 0x40 */ public NMSString0x20A RecipeName;
        /* 0x60 */ public float TimeToMake;
        /* 0x64 */ public bool Cooking;
        /* 0x68 */ public GcRefinerRecipeElement Result;
        /* 0x80 */ public List<GcRefinerRecipeElement> Ingredients;
    }
}
