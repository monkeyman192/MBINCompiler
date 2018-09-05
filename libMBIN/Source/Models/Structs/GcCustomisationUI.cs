using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0xD3A0)]
    public class GcCustomisationUI : NMSTemplate
    {
        /* 0x00 */ public GcCustomisationCameraData RacesCameraData;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x34 */ public byte[] Padding34;
        /* 0x38 */ public List<GcCustomisationRace> Races;
        /* 0x48 */ public GcCustomisationGroups Common;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x58 */ public byte[] Padding58;
        /* 0x60 */ public GcPaletteList CustomisationColours;     // maybe??
    }
}
