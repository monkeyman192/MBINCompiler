using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0xB0)]
    public class GcRefinerRecipe : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x00 */ public string Name;
        /* 0x80 */ public float TimeToMake;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x84 */ public byte[] Padding84;
        /* 0x88 */ public GcRefinerRecipeElement Result;
        /* 0xA0 */ public List<GcRefinerRecipeElement> Ingredients;
    }
}
