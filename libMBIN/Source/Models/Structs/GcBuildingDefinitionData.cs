namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x58)]
    public class GcBuildingDefinitionData : NMSTemplate
    {
        /* 0x00 */ public TkNoiseFlattenOptions FlattenType;
        /* 0x08 */ public GcBuildingClusterPlacement BuildingClusterPlacement;
        /* 0x0C */ public bool AddWaypoint;
        /* 0x0D */ public bool AddShelter;
        /* 0x0E */ public bool AddLandingPad;

        [NMS(Size = 5)]
        /* 0x10 */ public float[] Density;

        /* 0x24 */ public int NumOverridesToGenerate;
        /* 0x28 */ public int NumModelsToGenerate;

        [NMS(Size = 4, Ignore = true)]
        /* 0x2C */ public byte[] Padding2C;

        [NMS(Size = 0x20)]
        /* 0x30 */ public string TextureNameHint;
        /* 0x50 */ public float OverrideRadius;
        /* 0x54 */ public bool GivesShelter;

        [NMS(Size = 3, Ignore = true)]
        /* 0x55 */ public byte[] Padding55;
    }
}
