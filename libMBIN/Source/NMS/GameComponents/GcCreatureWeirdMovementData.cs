using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x120, GUID = 0x495ADF9A25F53FEF, NameHash = 0xBE42E310FC94C8E3)]
    public class GcCreatureWeirdMovementData : NMSTemplate
    {
        public enum MoveModeEnum { Roll, Float }
        /* 0x000 */ public MoveModeEnum MoveMode;
        [NMS(Size = 0x100)]
        /* 0x004 */ public string Node;
        /* 0x104 */ public float BobSpeed;
        /* 0x108 */ public float BobAmount;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x10C */ public byte[] Padding10C;
        /* 0x110 */ public List<NMSString0x100> FeetNames;
    }
}
