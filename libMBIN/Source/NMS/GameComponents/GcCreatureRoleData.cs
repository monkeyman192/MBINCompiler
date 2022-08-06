using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x76AD5A14FDD0E268, NameHash = 0x3330409D2B3F48C1)]
    public class GcCreatureRoleData : NMSTemplate
    {
        /* 0x000 */ public GcSeed Seed;
        /* 0x010 */ public GcCreatureTypes Type;
        /* 0x018 */ public NMSString0x10 CreatureId;
        /* 0x028 */ public GcCreatureRoleDescription Description;
        /* 0x090 */ public GcCreatureInfo Info;
        /* 0x5A8 */ public GcTerrainTileType TileType;
		/* 0x5AC */ public GcCreatureDiet Diet;
        /* 0x5B0 */ public float GroupsPerSquareKm;
        /* 0x5B4 */ public GcCreatureHemiSphere HemiSphere;
        /* 0x5B8 */ public NMSString0x20A Filter;
    }
}
