﻿using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcTeleportEndpoint : NMSTemplate
    {
        /* 0x00 */ public GcUniverseAddressData UniverseAddress;
        /* 0x20 */ public Vector4f Position;
        /* 0x30 */ public Vector4f Facing;
        public int TeleporterType;
        /* 0x40 */ public string[] TeleporterTypeValues()
        {
            return new[] { "Base", "SpaceStation" };
        }
    }
}
