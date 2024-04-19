using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE6B0B3233CA22BC9, NameHash = 0x309D52938C546138)]
    public class GcRefinerRecipe : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Id;
        /* 0x20 */ public NMSString0x20A RecipeName;
        /* 0x40 */ public NMSString0x20A RecipeType;
        /* 0x60 */ public GcRefinerRecipeElement Result;
        /* 0x78 */ public List<GcRefinerRecipeElement> Ingredients;
        /* 0x88 */ public float TimeToMake;
        /* 0x8C */ public bool Cooking;
    }
}
