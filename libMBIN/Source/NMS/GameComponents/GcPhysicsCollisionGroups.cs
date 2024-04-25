using System;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x33871F8C1A70C814, NameHash = 0x29A5D23AA5A4C794)]
    public class GcPhysicsCollisionGroups : NMSTemplate
    {
        // size: 0x10
        [Flags]
        public enum CollisionGroupEnum : uint {
            Normal = 0x1,
            Water = 0x2,
            Terrain = 0x4,
            Substance = 0x8,
            Asteroid = 0x10,
            TerrainInstance = 0x20,
            TerrainActivated = 0x40,
            Player = 0x80,
            Creature = 0x100,
            Spaceship = 0x200,
            Debris = 0x400,
            Shield = 0x800,
            Raycast = 0x1000,
            NetworkPlayer = 0x2000,
            NPCs = 0x4000,
            Trigger = 0x8000,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CollisionGroupEnum CollisionGroup;
    }
}
