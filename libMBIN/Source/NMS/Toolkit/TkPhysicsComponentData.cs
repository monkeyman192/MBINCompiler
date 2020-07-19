using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Alignment = 0x8, Size = 0x80, GUID = 0x851C12B102B3DD53, NameHash = 0xC58660803669C46F)]
    public class TkPhysicsComponentData : NMSTemplate
    {
        /* 0x00 */ public TkPhysicsData Data;
        /* 0x18 */ public NMSTemplate RagdollData;
        /* 0x68 */ public TkVolumeTriggerType VolumeTriggerType;
		public enum SurfacePropertiesEnum { None, Glass }
		/* 0x6C */ public SurfacePropertiesEnum SurfaceProperties;
        /* 0x70 */ public bool TriggerVolume;
        /* 0x71 */ public bool Climbable;
        /* 0x72 */ public bool Floor;
        /* 0x73 */ public bool IgnoreModelOwner;
        /* 0x74 */ public bool NoVehicleCollide;
        /* 0x75 */ public bool NoPlayerCollide;
        /* 0x76 */ public bool CameraInvisible;
        /* 0x77 */ public bool InvisibleForInteraction;
        /* 0x78 */ public bool AllowTeleporter;
        /* 0x79 */ public bool BlockTeleporter;
        /* 0x7A */ public bool DisableGravity;
        /* 0x7C */ public float SpinOnCreate;
    }
}
