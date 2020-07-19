using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x48, GUID = 0x86FB503A8D2FC455, NameHash = 0x44D6DFC8A512D8CB)]
    public class GcAntagonistPerception : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
        /* 0x10 */ public float Range;
        /* 0x14 */ public float XFOV;
        /* 0x18 */ public float YFOV;
        public enum ViewShapeEnum { Pyramid, Cone };
        /* 0x1C */ public ViewShapeEnum ViewShape;
        /* 0x20 */ public bool RayCast;
        [NMS(Size = 0x20)]
        /* 0x21 */ public string SenseLocator;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x42 */ public byte[] EndPadding;
    }
}