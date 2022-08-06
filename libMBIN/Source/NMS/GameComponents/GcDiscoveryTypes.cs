using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE974FE4BD4CE757C, NameHash = 0x822DDBC250BAB267)]
    public class GcDiscoveryTypes : NMSTemplate
    {
        // size: 0x11
        public enum DiscoveryTypeEnum { Unknown, SolarSystem, Planet, Animal, Flora, Mineral, Sector, Building, Interactable,
            Sentinel, Starship, Artifact, Mystery, Treasure, Control,
            HarvestPlant, FriendlyDrone
        }
        /* 0x0 */ public DiscoveryTypeEnum DiscoveryType;
    }
}
