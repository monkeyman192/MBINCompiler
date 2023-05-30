// generated output for subroutine:
// __int64 __fastcall GcAISpaceshipGlobals_LoadDefaults(__int64 a1) -----> hash: C7EC6D18
// hash of whole input: 21519724

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    public class GcAISpaceshipGlobals : NMSTemplate
    {
        // generated with MBINRawTemplateParser

        // line: __int64 __fastcall GcAISpaceshipGlobals_LoadDefaults(__int64 a1)
        // line: {
        // line:   __int64 v1; // rdi@1
        public bool Unknown0;     // offset: 0, sz: 1, origin: 0, parsed: 0        // line:   *(_BYTE *)a1 = 0;

        // missing 3 bytes at offset 0
        // does 0 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding1;        // offset: 1, sz: 3, comment: auto padding 

        public float Unknown4;     // offset: 4, sz: 4, origin: 0x41A00000, parsed: 20        // line:   *(_DWORD *)(a1 + 4) = 0x41A00000;
        public float Unknown8;     // offset: 8, sz: 4, origin: 0x42F00000, parsed: 120        // line:   *(_DWORD *)(a1 + 8) = 0x42F00000;
        public float UnknownC;     // offset: 0xC, sz: 4, origin: 0x41A00000, parsed: 20        // line:   *(_DWORD *)(a1 + 0xC) = 0x41A00000;
        public float Unknown10;     // offset: 0x10, sz: 4, origin: 0x3F266666, parsed: 0.65        // line:   *(_DWORD *)(a1 + 0x10) = 0x3F266666;
        public int Unknown14;     // offset: 0x14, sz: 4, origin: 0x14, parsed: 20        // line:   *(_DWORD *)(a1 + 0x14) = 0x14;
        public int Unknown18;     // offset: 0x18, sz: 4, origin: 0xA0, parsed: 160        // line:   *(_DWORD *)(a1 + 0x18) = 0xA0;
        public int Unknown1C;     // offset: 0x1C, sz: 4, origin: 0xC8, parsed: 200        // line:   *(_DWORD *)(a1 + 0x1C) = 0xC8;
        public int Unknown20;     // offset: 0x20, sz: 4, origin: 0x12C, parsed: 300        // line:   *(_DWORD *)(a1 + 0x20) = 0x12C;
        // line:   v1 = a1;

        // missing 4 bytes at offset 32
        // could be padding, a undefined subroutine or a pointer accessing larger memory
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding24;        // offset: 36, sz: 4, comment: auto padding 

        public NMSString0x10 Unknown28;     // offset: 0x28, sz: 10, origin:  "BOUNTYGUN1"        // line:   strncpy((char *)(a1 + 0x28), "BOUNTYGUN1", 0xAui64);

        public NMSString0x10 Unknown38;     // offset: 0x38, sz: 10, origin:  "BOUNTYGUN2"        // line:   strncpy((char *)(v1 + 0x38), "BOUNTYGUN2", 0xAui64);

        public NMSString0x10 Unknown48;     // offset: 0x48, sz: 10, origin:  "BOUNTYGUN2"        // line:   strncpy((char *)(v1 + 0x48), "BOUNTYGUN2", 0xAui64);

        public int Unknown58;     // offset: 0x58, sz: 4, origin: 0xF, parsed: 15        // line:   *(_DWORD *)(v1 + 0x58) = 0xF;
        public int Unknown5C;     // offset: 0x5C, sz: 4, origin: 0x14, parsed: 20        // line:   *(_DWORD *)(v1 + 0x5C) = 0x14;
        public int Unknown60;     // offset: 0x60, sz: 4, origin: 0x1E, parsed: 30        // line:   *(_DWORD *)(v1 + 0x60) = 0x1E;
        public int Unknown64;     // offset: 0x64, sz: 4, origin: 0x2710, parsed: 10000        // line:   *(_DWORD *)(v1 + 0x64) = 0x2710;
        public int Unknown68;     // offset: 0x68, sz: 4, origin: 0x7530, parsed: 30000        // line:   *(_DWORD *)(v1 + 0x68) = 0x7530;
        public int Unknown6C;     // offset: 0x6C, sz: 4, origin: 0x13880, parsed: 80000        // line:   *(_DWORD *)(v1 + 0x6C) = 0x13880;
        public float Unknown70;     // offset: 0x70, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 0x70) = 0x40000000;
        public float Unknown74;     // offset: 0x74, sz: 4, origin: 0x42A00000, parsed: 80        // line:   *(_DWORD *)(v1 + 0x74) = 0x42A00000;

        public GcShipAIAttackData Unknown78;

        public float Unknown104;     // offset: 0x104, sz: 4, origin: 0x43FA0000, parsed: 500        // line:   *(_DWORD *)(v1 + 0x104) = 0x43FA0000;
        public float Unknown108;     // offset: 0x108, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x108) = 0x40400000;
        public float Unknown10C;     // offset: 0x10C, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x10C) = 0x40400000;
        public float Unknown110;     // offset: 0x110, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x110) = 0x41200000;
        public float Unknown114;     // offset: 0x114, sz: 4, origin: 0x40A00000, parsed: 5        // line:   *(_DWORD *)(v1 + 0x114) = 0x40A00000;
        public float Unknown118;     // offset: 0x118, sz: 4, origin: 0x40A00000, parsed: 5        // line:   *(_DWORD *)(v1 + 0x118) = 0x40A00000;
        public float Unknown11C;     // offset: 0x11C, sz: 4, origin: 0x461C4000, parsed: 10000        // line:   *(_DWORD *)(v1 + 0x11C) = 0x461C4000;
        public int Unknown120;     // offset: 0x120, sz: 4, origin: 9, parsed: 9        // line:   *(_DWORD *)(v1 + 0x120) = 9;
        public int Unknown124;     // offset: 0x124, sz: 4, origin: 6, parsed: 6        // line:   *(_DWORD *)(v1 + 0x124) = 6;
        public float Unknown128;     // offset: 0x128, sz: 4, origin: 0x41F00000, parsed: 30        // line:   *(_DWORD *)(v1 + 0x128) = 0x41F00000;
        public float Unknown12C;     // offset: 0x12C, sz: 4, origin: 0x453B8000, parsed: 3000        // line:   *(_DWORD *)(v1 + 0x12C) = 0x453B8000;
        public float Unknown130;     // offset: 0x130, sz: 4, origin: 0x41A00000, parsed: 20        // line:   *(_DWORD *)(v1 + 0x130) = 0x41A00000;
        public float Unknown134;     // offset: 0x134, sz: 4, origin: 0x41A00000, parsed: 20        // line:   *(_DWORD *)(v1 + 0x134) = 0x41A00000;
        public float Unknown138;     // offset: 0x138, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x138) = 0x40400000;
        public float Unknown13C;     // offset: 0x13C, sz: 4, origin: 0x41F00000, parsed: 30        // line:   *(_DWORD *)(v1 + 0x13C) = 0x41F00000;
        public float Unknown140;     // offset: 0x140, sz: 4, origin: 0x42200000, parsed: 40        // line:   *(_DWORD *)(v1 + 0x140) = 0x42200000;
        public float Unknown144;     // offset: 0x144, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x144) = 0x40400000;
        public float Unknown148;     // offset: 0x148, sz: 4, origin: 0x42200000, parsed: 40        // line:   *(_DWORD *)(v1 + 0x148) = 0x42200000;
        public float Unknown14C;     // offset: 0x14C, sz: 4, origin: 0x40800000, parsed: 4        // line:   *(_DWORD *)(v1 + 0x14C) = 0x40800000;
        public float Unknown150;     // offset: 0x150, sz: 4, origin: 0x42480000, parsed: 50        // line:   *(_DWORD *)(v1 + 0x150) = 0x42480000;
        public bool Unknown154;     // offset: 0x154, sz: 1, origin: 1, parsed: 1        // line:   *(_BYTE *)(v1 + 0x154) = 1;
        public float Unknown158;     // offset: 0x158, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x158) = 0x3F800000;
        public float Unknown15C;     // offset: 0x15C, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x15C) = 0x40400000;
        public float Unknown160;     // offset: 0x160, sz: 4, origin: 0x40A00000, parsed: 5        // line:   *(_DWORD *)(v1 + 0x160) = 0x40A00000;
        public bool Unknown164;     // offset: 0x164, sz: 1, origin: 1, parsed: 1        // line:   *(_BYTE *)(v1 + 0x164) = 1;
        public int Unknown168;     // offset: 0x168, sz: 4, origin: 0xC, parsed: 12        // line:   *(_DWORD *)(v1 + 0x168) = 0xC;
        public int Unknown16C;     // offset: 0x16C, sz: 4, origin: 0x64, parsed: 100        // line:   *(_DWORD *)(v1 + 0x16C) = 0x64;
        public int Unknown170;     // offset: 0x170, sz: 4, origin: 0x3C, parsed: 60        // line:   *(_DWORD *)(v1 + 0x170) = 0x3C;
        public int Unknown174;     // offset: 0x174, sz: 4, origin: 0x3C, parsed: 60        // line:   *(_DWORD *)(v1 + 0x174) = 0x3C;
        public float Unknown178;     // offset: 0x178, sz: 4, origin: 0x3F000000, parsed: 0.5        // line:   *(_DWORD *)(v1 + 0x178) = 0x3F000000;
        public float Unknown17C;     // offset: 0x17C, sz: 4, origin: 0x3E99999A, parsed: 0.3        // line:   *(_DWORD *)(v1 + 0x17C) = 0x3E99999A;
        public float Unknown180;     // offset: 0x180, sz: 4, origin: 0x44FA0000, parsed: 2000        // line:   *(_DWORD *)(v1 + 0x180) = 0x44FA0000;
        public float Unknown184;     // offset: 0x184, sz: 4, origin: 0x44FA0000, parsed: 2000        // line:   *(_DWORD *)(v1 + 0x184) = 0x44FA0000;
        public float Unknown188;     // offset: 0x188, sz: 4, origin: 0x40A00000, parsed: 5        // line:   *(_DWORD *)(v1 + 0x188) = 0x40A00000;
        public float Unknown18C;     // offset: 0x18C, sz: 4, origin: 0x41000000, parsed: 8        // line:   *(_DWORD *)(v1 + 0x18C) = 0x41000000;
        public float Unknown190;     // offset: 0x190, sz: 4, origin: 0x453B8000, parsed: 3000        // line:   *(_DWORD *)(v1 + 0x190) = 0x453B8000;
        public float Unknown194;     // offset: 0x194, sz: 4, origin: 0x3F000000, parsed: 0.5        // line:   *(_DWORD *)(v1 + 0x194) = 0x3F000000;
        public float Unknown198;     // offset: 0x198, sz: 4, origin: 0x43480000, parsed: 200        // line:   *(_DWORD *)(v1 + 0x198) = 0x43480000;
        public float Unknown19C;     // offset: 0x19C, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x19C) = 0x3F800000;
        public float Unknown1A0;     // offset: 0x1A0, sz: 4, origin: 0x469C4000, parsed: 20000        // line:   *(_DWORD *)(v1 + 0x1A0) = 0x469C4000;
        public float Unknown1A4;     // offset: 0x1A4, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 0x1A4) = 0x40000000;
        public float Unknown1A8;     // offset: 0x1A8, sz: 4, origin: 0x40000000i64, parsed: 2, comment: two packed floats in a QWORD?(1)
        public float Unknown1AC;     // offset: 428, sz: 4, origin: 0x40000000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x1A8) = 0x40000000i64;
        public float Unknown1B0;     // offset: 0x1B0, sz: 4, origin: 0x459C4000, parsed: 5000        // line:   *(_DWORD *)(v1 + 0x1B0) = 0x459C4000;
        public float Unknown1B4;     // offset: 0x1B4, sz: 4, origin: 0x44FA0000, parsed: 2000        // line:   *(_DWORD *)(v1 + 0x1B4) = 0x44FA0000;

        public NMSString0x100 Unknown1B8;     // offset: 0x1B8, sz: 256, origin:  "TEXTURES\\UI\\HUD\\CROSSHAIRDOT.DDS"        // line:   strncpy((char *)(v1 + 0x1B8), "TEXTURES\\UI\\HUD\\CROSSHAIRDOT.DDS", 0x100ui64);

        public float Unknown2B8;     // offset: 0x2B8, sz: 4, origin: 0x459C4000, parsed: 5000        // line:   *(_DWORD *)(v1 + 0x2B8) = 0x459C4000;
        public float Unknown2BC;     // offset: 0x2BC, sz: 4, origin: 0x4788B800, parsed: 70000        // line:   *(_DWORD *)(v1 + 0x2BC) = 0x4788B800;
        public float Unknown2C0;     // offset: 0x2C0, sz: 4, origin: 0x3FE00000, parsed: 1.75        // line:   *(_DWORD *)(v1 + 0x2C0) = 0x3FE00000;
        public float Unknown2C4;     // offset: 0x2C4, sz: 4, origin: 0x3E99999A, parsed: 0.3        // line:   *(_DWORD *)(v1 + 0x2C4) = 0x3E99999A;
        public float Unknown2C8;     // offset: 0x2C8, sz: 4, origin: 0x457A0000, parsed: 4000        // line:   *(_DWORD *)(v1 + 0x2C8) = 0x457A0000;
        public float Unknown2CC;     // offset: 0x2CC, sz: 4, origin: 0x44480000, parsed: 800        // line:   *(_DWORD *)(v1 + 0x2CC) = 0x44480000;
        public float Unknown2D0;     // offset: 0x2D0, sz: 4, origin: 0x44FA0000, parsed: 2000        // line:   *(_DWORD *)(v1 + 0x2D0) = 0x44FA0000;
        public float Unknown2D4;     // offset: 0x2D4, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x2D4) = 0x41200000;
        public int Unknown2D8;     // offset: 0x2D8, sz: 4, origin: 0xC8, parsed: 200        // line:   *(_DWORD *)(v1 + 0x2D8) = 0xC8;
        public float Unknown2DC;     // offset: 0x2DC, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x2DC) = 0x41200000;
        public float Unknown2E0;     // offset: 0x2E0, sz: 4, origin: 0x3C23D70A, parsed: 0.01        // line:   *(_DWORD *)(v1 + 0x2E0) = 0x3C23D70A;
        public int Unknown2E4;     // offset: 0x2E4, sz: 4, origin: 0xF, parsed: 15        // line:   *(_DWORD *)(v1 + 0x2E4) = 0xF;

        // missing 8 bytes at offset 740
        // could be padding, a undefined subroutine or a pointer accessing larger memory
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] Padding2E8;        // offset: 744, sz: 8, comment: auto padding 

        public float Unknown2F0;     // offset: 0x2F0, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x2F0) = 0x3F800000;
        public float Unknown2F4;     // offset: 0x2F4, sz: 4, origin: 0x3EE6E979, parsed: 0.451        // line:   *(_DWORD *)(v1 + 0x2F4) = 0x3EE6E979;
        public float Unknown2F8;     // offset: 0x2F8, sz: 4, origin: 0x3EE6E979, parsed: 0.451        // line:   *(_DWORD *)(v1 + 0x2F8) = 0x3EE6E979;
        public float Unknown2FC;     // offset: 0x2FC, sz: 4, origin: 0x3CA3D70A, parsed: 0.02        // line:   *(_DWORD *)(v1 + 0x2FC) = 0x3CA3D70A;
        public float Unknown300;     // offset: 0x300, sz: 4, origin: 0x3F42D0E5, parsed: 0.761        // line:   *(_DWORD *)(v1 + 0x300) = 0x3F42D0E5;
        public float Unknown304;     // offset: 0x304, sz: 4, origin: 0x3F676C8B, parsed: 0.904        // line:   *(_DWORD *)(v1 + 0x304) = 0x3F676C8B;
        public float Unknown308;     // offset: 0x308, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x308) = 0x3F800000;
        public float Unknown30C;     // offset: 0x30C, sz: 4, origin: 0x3CA3D70A, parsed: 0.02        // line:   *(_DWORD *)(v1 + 0x30C) = 0x3CA3D70A;
        public float Unknown310;     // offset: 0x310, sz: 4, origin: 0x3F726E98, parsed: 0.947        // line:   *(_DWORD *)(v1 + 0x310) = 0x3F726E98;
        public float Unknown314;     // offset: 0x314, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x314) = 0x3F800000;
        public float Unknown318;     // offset: 0x318, sz: 4, origin: 0x3F12F1AA, parsed: 0.574        // line:   *(_DWORD *)(v1 + 0x318) = 0x3F12F1AA;
        public float Unknown31C;     // offset: 0x31C, sz: 4, origin: 0x3CA3D70A, parsed: 0.02        // line:   *(_DWORD *)(v1 + 0x31C) = 0x3CA3D70A;
        public float Unknown320;     // offset: 0x320, sz: 4, origin: 0x3F56872B, parsed: 0.838        // line:   *(_DWORD *)(v1 + 0x320) = 0x3F56872B;
        public float Unknown324;     // offset: 0x324, sz: 4, origin: 0x3F195810, parsed: 0.599        // line:   *(_DWORD *)(v1 + 0x324) = 0x3F195810;
        public float Unknown328;     // offset: 0x328, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x328) = 0x3F800000;
        public float Unknown32C;     // offset: 0x32C, sz: 4, origin: 0x3CA3D70A, parsed: 0.02        // line:   *(_DWORD *)(v1 + 0x32C) = 0x3CA3D70A;
        public float Unknown330;     // offset: 0x330, sz: 4, origin: 0x3F54FDF4, parsed: 0.832        // line:   *(_DWORD *)(v1 + 0x330) = 0x3F54FDF4;
        public float Unknown334;     // offset: 0x334, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x334) = 0x3F800000;
        public float Unknown338;     // offset: 0x338, sz: 4, origin: 0x3F449BA6, parsed: 0.768        // line:   *(_DWORD *)(v1 + 0x338) = 0x3F449BA6;
        public float Unknown33C;     // offset: 0x33C, sz: 4, origin: 0x3CA3D70A, parsed: 0.02        // line:   *(_DWORD *)(v1 + 0x33C) = 0x3CA3D70A;
        public bool Unknown340;     // offset: 0x340, sz: 1, origin: 1, parsed: 1        // line:   *(_BYTE *)(v1 + 0x340) = 1;
        public float Unknown344;     // offset: 0x344, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x344) = 0x3F800000;
        public float Unknown348;     // offset: 0x348, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x348) = 0x3F800000;
        public int Unknown34C;     // offset: 0x34C, sz: 4, origin: 3, parsed: 3        // line:   *(_DWORD *)(v1 + 0x34C) = 3;
        public float Unknown350;     // offset: 0x350, sz: 4, origin: 0x43C80000, parsed: 400        // line:   *(_DWORD *)(v1 + 0x350) = 0x43C80000;
        public float Unknown354;     // offset: 0x354, sz: 4, origin: 0x447A0000, parsed: 1000        // line:   *(_DWORD *)(v1 + 0x354) = 0x447A0000;
        public float Unknown358;     // offset: 0x358, sz: 4, origin: 0x42C80000, parsed: 100        // line:   *(_DWORD *)(v1 + 0x358) = 0x42C80000;
        public float Unknown35C;     // offset: 0x35C, sz: 4, origin: 0x43FA0000, parsed: 500        // line:   *(_DWORD *)(v1 + 0x35C) = 0x43FA0000;
        public float Unknown360;     // offset: 0x360, sz: 4, origin: 0x44160000, parsed: 600        // line:   *(_DWORD *)(v1 + 0x360) = 0x44160000;
        public float Unknown364;     // offset: 0x364, sz: 4, origin: 0x453B8000, parsed: 3000        // line:   *(_DWORD *)(v1 + 0x364) = 0x453B8000;
        public float Unknown368;     // offset: 0x368, sz: 4, origin: 0x42340000, parsed: 45        // line:   *(_DWORD *)(v1 + 0x368) = 0x42340000;
        public float Unknown36C;     // offset: 0x36C, sz: 4, origin: 0x40A00000, parsed: 5        // line:   *(_DWORD *)(v1 + 0x36C) = 0x40A00000;
        public float Unknown370;     // offset: 0x370, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x370) = 0x41200000;
        public float Unknown374;     // offset: 0x374, sz: 4, origin: 0x41000000i64, parsed: 8, comment: two packed floats in a QWORD?(1)
        public float Unknown378;     // offset: 888, sz: 4, origin: 0x41000000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x374) = 0x41000000i64;
        public float Unknown37C;     // offset: 0x37C, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 0x37C) = 0;
        public float Unknown380;     // offset: 0x380, sz: 4, origin: 0x442F0000, parsed: 700        // line:   *(_DWORD *)(v1 + 0x380) = 0x442F0000;
        public float Unknown384;     // offset: 0x384, sz: 4, origin: 0x41700000, parsed: 15        // line:   *(_DWORD *)(v1 + 0x384) = 0x41700000;
        public float Unknown388;     // offset: 0x388, sz: 4, origin: 0x3F000000, parsed: 0.5        // line:   *(_DWORD *)(v1 + 0x388) = 0x3F000000;
        public bool Unknown38C;     // offset: 0x38C, sz: 1, origin: 0, parsed: 0        // line:   *(_BYTE *)(v1 + 0x38C) = 0;
        public int Unknown390;     // offset: 0x390, sz: 4, origin: 0x14, parsed: 20        // line:   *(_DWORD *)(v1 + 0x390) = 0x14;
        public int Unknown394;     // offset: 0x394, sz: 4, origin: 9, parsed: 9        // line:   *(_DWORD *)(v1 + 0x394) = 9;
        public float Unknown398;     // offset: 0x398, sz: 4, origin: 0x44FA0000, parsed: 2000        // line:   *(_DWORD *)(v1 + 0x398) = 0x44FA0000;
        public float Unknown39C;     // offset: 0x39C, sz: 4, origin: 0x42200000, parsed: 40        // line:   *(_DWORD *)(v1 + 0x39C) = 0x42200000;
        public float Unknown3A0;     // offset: 0x3A0, sz: 4, origin: 0x41F00000, parsed: 30        // line:   *(_DWORD *)(v1 + 0x3A0) = 0x41F00000;
        public float Unknown3A4;     // offset: 0x3A4, sz: 4, origin: 0x45DAC000, parsed: 7000        // line:   *(_DWORD *)(v1 + 0x3A4) = 0x45DAC000;
        public float Unknown3A8;     // offset: 0x3A8, sz: 4, origin: 0x3DCCCCCD, parsed: 0.1        // line:   *(_DWORD *)(v1 + 0x3A8) = 0x3DCCCCCD;
        public float Unknown3AC;     // offset: 0x3AC, sz: 4, origin: 0x43960000, parsed: 300        // line:   *(_DWORD *)(v1 + 0x3AC) = 0x43960000;
        public float Unknown3B0;     // offset: 0x3B0, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x3B0) = 0x3F800000;
        public float Unknown3B4;     // offset: 0x3B4, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x3B4) = 0x41200000;
        public float Unknown3B8;     // offset: 0x3B8, sz: 4, origin: 0x3E4CCCCD, parsed: 0.2        // line:   *(_DWORD *)(v1 + 0x3B8) = 0x3E4CCCCD;
        public float Unknown3BC;     // offset: 0x3BC, sz: 4, origin: 0x42480000, parsed: 50        // line:   *(_DWORD *)(v1 + 0x3BC) = 0x42480000;
        public float Unknown3C0;     // offset: 0x3C0, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x3C0) = 0x40400000;
        public float Unknown3C4;     // offset: 0x3C4, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x3C4) = 0x40400000;
        public float Unknown3C8;     // offset: 0x3C8, sz: 4, origin: 0x3F333333, parsed: 0.7        // line:   *(_DWORD *)(v1 + 0x3C8) = 0x3F333333;
        public float Unknown3CC;     // offset: 0x3CC, sz: 4, origin: 0x3F333333, parsed: 0.7        // line:   *(_DWORD *)(v1 + 0x3CC) = 0x3F333333;
        public float Unknown3D0;     // offset: 0x3D0, sz: 4, origin: 0x3F666666, parsed: 0.9        // line:   *(_DWORD *)(v1 + 0x3D0) = 0x3F666666;
        public float Unknown3D4;     // offset: 0x3D4, sz: 4, origin: 0x44BB8000, parsed: 1500        // line:   *(_DWORD *)(v1 + 0x3D4) = 0x44BB8000;
        public float Unknown3D8;     // offset: 0x3D8, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 0x3D8) = 0x40000000;
        public float Unknown3DC;     // offset: 0x3DC, sz: 4, origin: 0x3F8CCCCD, parsed: 1.1        // line:   *(_DWORD *)(v1 + 0x3DC) = 0x3F8CCCCD;
        public int Unknown3E0;     // offset: 0x3E0, sz: 4, origin: 5, parsed: 5        // line:   *(_DWORD *)(v1 + 0x3E0) = 5;
        public float Unknown3E4;     // offset: 0x3E4, sz: 4, origin: 0x40A00000, parsed: 5        // line:   *(_DWORD *)(v1 + 0x3E4) = 0x40A00000;
        public float Unknown3E8;     // offset: 0x3E8, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 0x3E8) = 0x40000000;
        public float Unknown3EC;     // offset: 0x3EC, sz: 4, origin: 0x44FA0000, parsed: 2000        // line:   *(_DWORD *)(v1 + 0x3EC) = 0x44FA0000;
        public float Unknown3F0;     // offset: 0x3F0, sz: 4, origin: 0x453B8000, parsed: 3000        // line:   *(_DWORD *)(v1 + 0x3F0) = 0x453B8000;
        public float Unknown3F4;     // offset: 0x3F4, sz: 4, origin: 0x40A00000, parsed: 5        // line:   *(_DWORD *)(v1 + 0x3F4) = 0x40A00000;
        public float Unknown3F8;     // offset: 0x3F8, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x3F8) = 0x41200000;
        public float Unknown3FC;     // offset: 0x3FC, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x3FC) = 0x40400000;
        public float Unknown400;     // offset: 0x400, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 0x400) = 0x40000000;
        public float Unknown404;     // offset: 0x404, sz: 4, origin: 0x42C80000, parsed: 100        // line:   *(_DWORD *)(v1 + 0x404) = 0x42C80000;
        public float Unknown408;     // offset: 0x408, sz: 4, origin: 0x41900000, parsed: 18        // line:   *(_DWORD *)(v1 + 0x408) = 0x41900000;
        public float Unknown40C;     // offset: 0x40C, sz: 4, origin: 0x42480000, parsed: 50        // line:   *(_DWORD *)(v1 + 0x40C) = 0x42480000;
        public float Unknown410;     // offset: 0x410, sz: 4, origin: 0x40A00000, parsed: 5        // line:   *(_DWORD *)(v1 + 0x410) = 0x40A00000;
        public float Unknown414;     // offset: 0x414, sz: 4, origin: 0x3E4CCCCD, parsed: 0.2        // line:   *(_DWORD *)(v1 + 0x414) = 0x3E4CCCCD;
        public float Unknown418;     // offset: 0x418, sz: 4, origin: 0x45FA0000, parsed: 8000        // line:   *(_DWORD *)(v1 + 0x418) = 0x45FA0000;
        public float Unknown41C;     // offset: 0x41C, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 0x41C) = 0x40000000;
        public float Unknown420;     // offset: 0x420, sz: 4, origin: 0x43960000, parsed: 300        // line:   *(_DWORD *)(v1 + 0x420) = 0x43960000;
        public float Unknown424;     // offset: 0x424, sz: 4, origin: 0x44BB8000, parsed: 1500        // line:   *(_DWORD *)(v1 + 0x424) = 0x44BB8000;
        public float Unknown428;     // offset: 0x428, sz: 4, origin: 0x459C4000, parsed: 5000        // line:   *(_DWORD *)(v1 + 0x428) = 0x459C4000;
        public float Unknown42C;     // offset: 0x42C, sz: 4, origin: 0x45BB8000, parsed: 6000        // line:   *(_DWORD *)(v1 + 0x42C) = 0x45BB8000;
        public float Unknown430;     // offset: 0x430, sz: 4, origin: 0x40A00000, parsed: 5        // line:   *(_DWORD *)(v1 + 0x430) = 0x40A00000;
        public float Unknown434;     // offset: 0x434, sz: 4, origin: 0x453B8000, parsed: 3000        // line:   *(_DWORD *)(v1 + 0x434) = 0x453B8000;
        public float Unknown438;     // offset: 0x438, sz: 4, origin: 0x3E4CCCCD, parsed: 0.2        // line:   *(_DWORD *)(v1 + 0x438) = 0x3E4CCCCD;
        public float Unknown43C;     // offset: 0x43C, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 0x43C) = 0x40000000;
        public float Unknown440;     // offset: 0x440, sz: 4, origin: 0x3F19999Ai64, parsed: 0.6, comment: two packed floats in a QWORD?(1)
        public float Unknown444;     // offset: 1092, sz: 4, origin: 0x3F19999Ai64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x440) = 0x3F19999Ai64;
        public float Unknown448;     // offset: 0x448, sz: 4, origin: 0x3E99999A, parsed: 0.3        // line:   *(_DWORD *)(v1 + 0x448) = 0x3E99999A;
        public float Unknown44C;     // offset: 0x44C, sz: 4, origin: 0x479C4000, parsed: 80000        // line:   *(_DWORD *)(v1 + 0x44C) = 0x479C4000;
        public float Unknown450;     // offset: 0x450, sz: 4, origin: 0x43C80000, parsed: 400        // line:   *(_DWORD *)(v1 + 0x450) = 0x43C80000;
        public float Unknown454;     // offset: 0x454, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x454) = 0x41200000;
        public float Unknown458;     // offset: 0x458, sz: 4, origin: 0x3F333333, parsed: 0.7        // line:   *(_DWORD *)(v1 + 0x458) = 0x3F333333;
        public float Unknown45C;     // offset: 0x45C, sz: 4, origin: 0x44E10000, parsed: 1800        // line:   *(_DWORD *)(v1 + 0x45C) = 0x44E10000;
        public float Unknown460;     // offset: 0x460, sz: 4, origin: 0x44FA0000, parsed: 2000        // line:   *(_DWORD *)(v1 + 0x460) = 0x44FA0000;
        public float Unknown464;     // offset: 0x464, sz: 4, origin: 0x42F00000, parsed: 120        // line:   *(_DWORD *)(v1 + 0x464) = 0x42F00000;
        public float Unknown468;     // offset: 0x468, sz: 4, origin: 0x43A00000, parsed: 320        // line:   *(_DWORD *)(v1 + 0x468) = 0x43A00000;
        public float Unknown46C;     // offset: 0x46C, sz: 4, origin: 0x3DCCCCCD, parsed: 0.1        // line:   *(_DWORD *)(v1 + 0x46C) = 0x3DCCCCCD;
        public float Unknown470;     // offset: 0x470, sz: 4, origin: 0x3E19999A, parsed: 0.15        // line:   *(_DWORD *)(v1 + 0x470) = 0x3E19999A;
        public float Unknown474;     // offset: 0x474, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x474) = 0x3F800000;
        public float Unknown478;     // offset: 0x478, sz: 4, origin: 0x41000000i64, parsed: 8, comment: two packed floats in a QWORD?(1)
        public float Unknown47C;     // offset: 1148, sz: 4, origin: 0x41000000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x478) = 0x41000000i64;
        public float Unknown480;     // offset: 0x480, sz: 4, origin: 0x3F800000i64, parsed: 1, comment: two packed floats in a QWORD?(1)
        public float Unknown484;     // offset: 1156, sz: 4, origin: 0x3F800000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x480) = 0x3F800000i64;
        public float Unknown488;     // offset: 0x488, sz: 4, origin: 0x44480000, parsed: 800        // line:   *(_DWORD *)(v1 + 0x488) = 0x44480000;
        public float Unknown48C;     // offset: 0x48C, sz: 4, origin: 0x43480000, parsed: 200        // line:   *(_DWORD *)(v1 + 0x48C) = 0x43480000;
        public float Unknown490;     // offset: 0x490, sz: 4, origin: 0x44FA0000, parsed: 2000        // line:   *(_DWORD *)(v1 + 0x490) = 0x44FA0000;
        public float Unknown494;     // offset: 0x494, sz: 4, origin: 0x42A00000, parsed: 80        // line:   *(_DWORD *)(v1 + 0x494) = 0x42A00000;
        public float Unknown498;     // offset: 0x498, sz: 4, origin: 0x432A0000, parsed: 170        // line:   *(_DWORD *)(v1 + 0x498) = 0x432A0000;
        public float Unknown49C;     // offset: 0x49C, sz: 4, origin: 0x447A0000, parsed: 1000        // line:   *(_DWORD *)(v1 + 0x49C) = 0x447A0000;
        public float Unknown4A0;     // offset: 0x4A0, sz: 4, origin: 0x42480000, parsed: 50        // line:   *(_DWORD *)(v1 + 0x4A0) = 0x42480000;
        public float Unknown4A4;     // offset: 0x4A4, sz: 4, origin: 0x40A00000, parsed: 5        // line:   *(_DWORD *)(v1 + 0x4A4) = 0x40A00000;
        public float Unknown4A8;     // offset: 0x4A8, sz: 4, origin: 0x3F333333, parsed: 0.7        // line:   *(_DWORD *)(v1 + 0x4A8) = 0x3F333333;
        public float Unknown4AC;     // offset: 0x4AC, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x4AC) = 0x40400000;
        public float Unknown4B0;     // offset: 0x4B0, sz: 4, origin: 0x3FC00000, parsed: 1.5        // line:   *(_DWORD *)(v1 + 0x4B0) = 0x3FC00000;
        public float Unknown4B4;     // offset: 0x4B4, sz: 4, origin: 0x41F00000, parsed: 30        // line:   *(_DWORD *)(v1 + 0x4B4) = 0x41F00000;
        public float Unknown4B8;     // offset: 0x4B8, sz: 4, origin: 0x42A00000, parsed: 80        // line:   *(_DWORD *)(v1 + 0x4B8) = 0x42A00000;
        public float Unknown4BC;     // offset: 0x4BC, sz: 4, origin: 0x43480000, parsed: 200        // line:   *(_DWORD *)(v1 + 0x4BC) = 0x43480000;
        public float Unknown4C0;     // offset: 0x4C0, sz: 4, origin: 0x42200000, parsed: 40        // line:   *(_DWORD *)(v1 + 0x4C0) = 0x42200000;
        public float Unknown4C4;     // offset: 0x4C4, sz: 4, origin: 0x3F000000, parsed: 0.5        // line:   *(_DWORD *)(v1 + 0x4C4) = 0x3F000000;
        public float Unknown4C8;     // offset: 0x4C8, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x4C8) = 0x40400000;
        public float Unknown4CC;     // offset: 0x4CC, sz: 4, origin: 0x3F99999A, parsed: 1.2        // line:   *(_DWORD *)(v1 + 0x4CC) = 0x3F99999A;
        public float Unknown4D0;     // offset: 0x4D0, sz: 4, origin: 0x3F4CCCCD, parsed: 0.8        // line:   *(_DWORD *)(v1 + 0x4D0) = 0x3F4CCCCD;
        public float Unknown4D4;     // offset: 0x4D4, sz: 4, origin: 0x3DCCCCCD, parsed: 0.1        // line:   *(_DWORD *)(v1 + 0x4D4) = 0x3DCCCCCD;
        public float Unknown4D8;     // offset: 0x4D8, sz: 4, origin: 0x41700000, parsed: 15        // line:   *(_DWORD *)(v1 + 0x4D8) = 0x41700000;
        public float Unknown4DC;     // offset: 0x4DC, sz: 4, origin: 0x42A00000, parsed: 80        // line:   *(_DWORD *)(v1 + 0x4DC) = 0x42A00000;
        public float Unknown4E0;     // offset: 0x4E0, sz: 4, origin: 0x432A0000, parsed: 170        // line:   *(_DWORD *)(v1 + 0x4E0) = 0x432A0000;
        public float Unknown4E4;     // offset: 0x4E4, sz: 4, origin: 0x447A0000, parsed: 1000        // line:   *(_DWORD *)(v1 + 0x4E4) = 0x447A0000;
        public float Unknown4E8;     // offset: 0x4E8, sz: 4, origin: 0x42480000, parsed: 50        // line:   *(_DWORD *)(v1 + 0x4E8) = 0x42480000;
        public float Unknown4EC;     // offset: 0x4EC, sz: 4, origin: 0x40A00000, parsed: 5        // line:   *(_DWORD *)(v1 + 0x4EC) = 0x40A00000;
        public float Unknown4F0;     // offset: 0x4F0, sz: 4, origin: 0x3F333333, parsed: 0.7        // line:   *(_DWORD *)(v1 + 0x4F0) = 0x3F333333;
        public float Unknown4F4;     // offset: 0x4F4, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x4F4) = 0x40400000;
        public float Unknown4F8;     // offset: 0x4F8, sz: 4, origin: 0x3FC00000, parsed: 1.5        // line:   *(_DWORD *)(v1 + 0x4F8) = 0x3FC00000;
        public float Unknown4FC;     // offset: 0x4FC, sz: 4, origin: 0x41F00000, parsed: 30        // line:   *(_DWORD *)(v1 + 0x4FC) = 0x41F00000;
        public float Unknown500;     // offset: 0x500, sz: 4, origin: 0x42A00000, parsed: 80        // line:   *(_DWORD *)(v1 + 0x500) = 0x42A00000;
        public float Unknown504;     // offset: 0x504, sz: 4, origin: 0x43480000, parsed: 200        // line:   *(_DWORD *)(v1 + 0x504) = 0x43480000;
        public float Unknown508;     // offset: 0x508, sz: 4, origin: 0x42200000, parsed: 40        // line:   *(_DWORD *)(v1 + 0x508) = 0x42200000;
        public float Unknown50C;     // offset: 0x50C, sz: 4, origin: 0x3F000000, parsed: 0.5        // line:   *(_DWORD *)(v1 + 0x50C) = 0x3F000000;
        public float Unknown510;     // offset: 0x510, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x510) = 0x40400000;
        public float Unknown514;     // offset: 0x514, sz: 4, origin: 0x3F99999A, parsed: 1.2        // line:   *(_DWORD *)(v1 + 0x514) = 0x3F99999A;
        public float Unknown518;     // offset: 0x518, sz: 4, origin: 0x3F4CCCCD, parsed: 0.8        // line:   *(_DWORD *)(v1 + 0x518) = 0x3F4CCCCD;
        public float Unknown51C;     // offset: 0x51C, sz: 4, origin: 0x3DCCCCCD, parsed: 0.1        // line:   *(_DWORD *)(v1 + 0x51C) = 0x3DCCCCCD;
        public float Unknown520;     // offset: 0x520, sz: 4, origin: 0x41700000, parsed: 15        // line:   *(_DWORD *)(v1 + 0x520) = 0x41700000;
        public float Unknown524;     // offset: 0x524, sz: 4, origin: 0x42A00000, parsed: 80        // line:   *(_DWORD *)(v1 + 0x524) = 0x42A00000;
        public float Unknown528;     // offset: 0x528, sz: 4, origin: 0x432A0000, parsed: 170        // line:   *(_DWORD *)(v1 + 0x528) = 0x432A0000;
        public float Unknown52C;     // offset: 0x52C, sz: 4, origin: 0x447A0000, parsed: 1000        // line:   *(_DWORD *)(v1 + 0x52C) = 0x447A0000;
        public float Unknown530;     // offset: 0x530, sz: 4, origin: 0x42480000, parsed: 50        // line:   *(_DWORD *)(v1 + 0x530) = 0x42480000;
        public float Unknown534;     // offset: 0x534, sz: 4, origin: 0x40A00000, parsed: 5        // line:   *(_DWORD *)(v1 + 0x534) = 0x40A00000;
        public float Unknown538;     // offset: 0x538, sz: 4, origin: 0x3F333333, parsed: 0.7        // line:   *(_DWORD *)(v1 + 0x538) = 0x3F333333;
        public float Unknown53C;     // offset: 0x53C, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x53C) = 0x40400000;
        public float Unknown540;     // offset: 0x540, sz: 4, origin: 0x3FC00000, parsed: 1.5        // line:   *(_DWORD *)(v1 + 0x540) = 0x3FC00000;
        public float Unknown544;     // offset: 0x544, sz: 4, origin: 0x41F00000, parsed: 30        // line:   *(_DWORD *)(v1 + 0x544) = 0x41F00000;
        public float Unknown548;     // offset: 0x548, sz: 4, origin: 0x42A00000, parsed: 80        // line:   *(_DWORD *)(v1 + 0x548) = 0x42A00000;
        public float Unknown54C;     // offset: 0x54C, sz: 4, origin: 0x43480000, parsed: 200        // line:   *(_DWORD *)(v1 + 0x54C) = 0x43480000;
        public float Unknown550;     // offset: 0x550, sz: 4, origin: 0x42200000, parsed: 40        // line:   *(_DWORD *)(v1 + 0x550) = 0x42200000;
        public float Unknown554;     // offset: 0x554, sz: 4, origin: 0x3F000000, parsed: 0.5        // line:   *(_DWORD *)(v1 + 0x554) = 0x3F000000;
        public float Unknown558;     // offset: 0x558, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x558) = 0x40400000;
        public float Unknown55C;     // offset: 0x55C, sz: 4, origin: 0x3F99999A, parsed: 1.2        // line:   *(_DWORD *)(v1 + 0x55C) = 0x3F99999A;
        public float Unknown560;     // offset: 0x560, sz: 4, origin: 0x3F4CCCCD, parsed: 0.8        // line:   *(_DWORD *)(v1 + 0x560) = 0x3F4CCCCD;
        public float Unknown564;     // offset: 0x564, sz: 4, origin: 0x3DCCCCCD, parsed: 0.1        // line:   *(_DWORD *)(v1 + 0x564) = 0x3DCCCCCD;
        public float Unknown568;     // offset: 0x568, sz: 4, origin: 0x41700000, parsed: 15        // line:   *(_DWORD *)(v1 + 0x568) = 0x41700000;
        public float Unknown56C;     // offset: 0x56C, sz: 4, origin: 0x42A00000, parsed: 80        // line:   *(_DWORD *)(v1 + 0x56C) = 0x42A00000;
        public float Unknown570;     // offset: 0x570, sz: 4, origin: 0x432A0000, parsed: 170        // line:   *(_DWORD *)(v1 + 0x570) = 0x432A0000;
        public float Unknown574;     // offset: 0x574, sz: 4, origin: 0x447A0000, parsed: 1000        // line:   *(_DWORD *)(v1 + 0x574) = 0x447A0000;
        public float Unknown578;     // offset: 0x578, sz: 4, origin: 0x42480000, parsed: 50        // line:   *(_DWORD *)(v1 + 0x578) = 0x42480000;
        public float Unknown57C;     // offset: 0x57C, sz: 4, origin: 0x40A00000, parsed: 5        // line:   *(_DWORD *)(v1 + 0x57C) = 0x40A00000;
        public float Unknown580;     // offset: 0x580, sz: 4, origin: 0x3F333333, parsed: 0.7        // line:   *(_DWORD *)(v1 + 0x580) = 0x3F333333;
        public float Unknown584;     // offset: 0x584, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x584) = 0x40400000;
        public float Unknown588;     // offset: 0x588, sz: 4, origin: 0x3FC00000, parsed: 1.5        // line:   *(_DWORD *)(v1 + 0x588) = 0x3FC00000;
        public float Unknown58C;     // offset: 0x58C, sz: 4, origin: 0x41F00000, parsed: 30        // line:   *(_DWORD *)(v1 + 0x58C) = 0x41F00000;
        public float Unknown590;     // offset: 0x590, sz: 4, origin: 0x42A00000, parsed: 80        // line:   *(_DWORD *)(v1 + 0x590) = 0x42A00000;
        public float Unknown594;     // offset: 0x594, sz: 4, origin: 0x43480000, parsed: 200        // line:   *(_DWORD *)(v1 + 0x594) = 0x43480000;
        public float Unknown598;     // offset: 0x598, sz: 4, origin: 0x42200000, parsed: 40        // line:   *(_DWORD *)(v1 + 0x598) = 0x42200000;
        public float Unknown59C;     // offset: 0x59C, sz: 4, origin: 0x3F000000, parsed: 0.5        // line:   *(_DWORD *)(v1 + 0x59C) = 0x3F000000;
        public float Unknown5A0;     // offset: 0x5A0, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x5A0) = 0x40400000;
        public float Unknown5A4;     // offset: 0x5A4, sz: 4, origin: 0x3F99999A, parsed: 1.2        // line:   *(_DWORD *)(v1 + 0x5A4) = 0x3F99999A;
        public float Unknown5A8;     // offset: 0x5A8, sz: 4, origin: 0x3F4CCCCD, parsed: 0.8        // line:   *(_DWORD *)(v1 + 0x5A8) = 0x3F4CCCCD;
        public float Unknown5AC;     // offset: 0x5AC, sz: 4, origin: 0x3DCCCCCD, parsed: 0.1        // line:   *(_DWORD *)(v1 + 0x5AC) = 0x3DCCCCCD;
        public float Unknown5B0;     // offset: 0x5B0, sz: 4, origin: 0x41700000, parsed: 15        // line:   *(_DWORD *)(v1 + 0x5B0) = 0x41700000;
        public float Unknown5B4;     // offset: 0x5B4, sz: 4, origin: 0x42A00000, parsed: 80        // line:   *(_DWORD *)(v1 + 0x5B4) = 0x42A00000;
        public float Unknown5B8;     // offset: 0x5B8, sz: 4, origin: 0x432A0000, parsed: 170        // line:   *(_DWORD *)(v1 + 0x5B8) = 0x432A0000;
        public float Unknown5BC;     // offset: 0x5BC, sz: 4, origin: 0x447A0000, parsed: 1000        // line:   *(_DWORD *)(v1 + 0x5BC) = 0x447A0000;
        public float Unknown5C0;     // offset: 0x5C0, sz: 4, origin: 0x42480000, parsed: 50        // line:   *(_DWORD *)(v1 + 0x5C0) = 0x42480000;
        public float Unknown5C4;     // offset: 0x5C4, sz: 4, origin: 0x40A00000, parsed: 5        // line:   *(_DWORD *)(v1 + 0x5C4) = 0x40A00000;
        public float Unknown5C8;     // offset: 0x5C8, sz: 4, origin: 0x3F333333, parsed: 0.7        // line:   *(_DWORD *)(v1 + 0x5C8) = 0x3F333333;
        public float Unknown5CC;     // offset: 0x5CC, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x5CC) = 0x40400000;
        public float Unknown5D0;     // offset: 0x5D0, sz: 4, origin: 0x3FC00000, parsed: 1.5        // line:   *(_DWORD *)(v1 + 0x5D0) = 0x3FC00000;
        public float Unknown5D4;     // offset: 0x5D4, sz: 4, origin: 0x41F00000, parsed: 30        // line:   *(_DWORD *)(v1 + 0x5D4) = 0x41F00000;
        public float Unknown5D8;     // offset: 0x5D8, sz: 4, origin: 0x42A00000, parsed: 80        // line:   *(_DWORD *)(v1 + 0x5D8) = 0x42A00000;
        public float Unknown5DC;     // offset: 0x5DC, sz: 4, origin: 0x43480000, parsed: 200        // line:   *(_DWORD *)(v1 + 0x5DC) = 0x43480000;
        public float Unknown5E0;     // offset: 0x5E0, sz: 4, origin: 0x42200000, parsed: 40        // line:   *(_DWORD *)(v1 + 0x5E0) = 0x42200000;
        public float Unknown5E4;     // offset: 0x5E4, sz: 4, origin: 0x3F000000, parsed: 0.5        // line:   *(_DWORD *)(v1 + 0x5E4) = 0x3F000000;
        public float Unknown5E8;     // offset: 0x5E8, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x5E8) = 0x40400000;
        public float Unknown5EC;     // offset: 0x5EC, sz: 4, origin: 0x3F99999A, parsed: 1.2        // line:   *(_DWORD *)(v1 + 0x5EC) = 0x3F99999A;
        public float Unknown5F0;     // offset: 0x5F0, sz: 4, origin: 0x3F4CCCCD, parsed: 0.8        // line:   *(_DWORD *)(v1 + 0x5F0) = 0x3F4CCCCD;
        public float Unknown5F4;     // offset: 0x5F4, sz: 4, origin: 0x3DCCCCCD, parsed: 0.1        // line:   *(_DWORD *)(v1 + 0x5F4) = 0x3DCCCCCD;
        public float Unknown5F8;     // offset: 0x5F8, sz: 4, origin: 0x41700000, parsed: 15        // line:   *(_DWORD *)(v1 + 0x5F8) = 0x41700000;
        public float Unknown5FC;     // offset: 0x5FC, sz: 4, origin: 0x43FA0000, parsed: 500        // line:   *(_DWORD *)(v1 + 0x5FC) = 0x43FA0000;
        public float Unknown600;     // offset: 0x600, sz: 4, origin: 0x447A0000, parsed: 1000        // line:   *(_DWORD *)(v1 + 0x600) = 0x447A0000;
        public float Unknown604;     // offset: 0x604, sz: 4, origin: 0x3F000000, parsed: 0.5        // line:   *(_DWORD *)(v1 + 0x604) = 0x3F000000;
        public float Unknown608;     // offset: 0x608, sz: 4, origin: 0x41700000, parsed: 15        // line:   *(_DWORD *)(v1 + 0x608) = 0x41700000;
        public float Unknown60C;     // offset: 0x60C, sz: 4, origin: 0x3FE66666, parsed: 1.8        // line:   *(_DWORD *)(v1 + 0x60C) = 0x3FE66666;
        public float Unknown610;     // offset: 0x610, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 0x610) = 0x40000000;
        public float Unknown614;     // offset: 0x614, sz: 4, origin: 0x43480000, parsed: 200        // line:   *(_DWORD *)(v1 + 0x614) = 0x43480000;
        public float Unknown618;     // offset: 0x618, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x618) = 0x41200000;
        public float Unknown61C;     // offset: 0x61C, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x61C) = 0x41200000;
        public float Unknown620;     // offset: 0x620, sz: 4, origin: 0x3C23D70A, parsed: 0.01        // line:   *(_DWORD *)(v1 + 0x620) = 0x3C23D70A;
        public float Unknown624;     // offset: 0x624, sz: 4, origin: 0x3F000000, parsed: 0.5        // line:   *(_DWORD *)(v1 + 0x624) = 0x3F000000;
        public float Unknown628;     // offset: 0x628, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x628) = 0x3F800000;
        public float Unknown62C;     // offset: 0x62C, sz: 4, origin: 0x3F333333i64, parsed: 0.7, comment: two packed floats in a QWORD?(1)
        public float Unknown630;     // offset: 1584, sz: 4, origin: 0x3F333333i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x62C) = 0x3F333333i64;
        public float Unknown634;     // offset: 0x634, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x634) = 0x41200000;
        public float Unknown638;     // offset: 0x638, sz: 4, origin: 0x42480000, parsed: 50        // line:   *(_DWORD *)(v1 + 0x638) = 0x42480000;
        public float Unknown63C;     // offset: 0x63C, sz: 4, origin: 0x49127C00, parsed: 600000        // line:   *(_DWORD *)(v1 + 0x63C) = 0x49127C00;
        public float Unknown640;     // offset: 0x640, sz: 4, origin: 0x49127C00, parsed: 600000        // line:   *(_DWORD *)(v1 + 0x640) = 0x49127C00;
        public float Unknown644;     // offset: 0x644, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x644) = 0x41200000;
        public float Unknown648;     // offset: 0x648, sz: 4, origin: 0x41A00000, parsed: 20        // line:   *(_DWORD *)(v1 + 0x648) = 0x41A00000;
        public float Unknown64C;     // offset: 0x64C, sz: 4, origin: 0x41C80000, parsed: 25        // line:   *(_DWORD *)(v1 + 0x64C) = 0x41C80000;
        public float Unknown650;     // offset: 0x650, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x650) = 0x3F800000;
        public float Unknown654;     // offset: 0x654, sz: 4, origin: 0x3F4CCCCD, parsed: 0.8        // line:   *(_DWORD *)(v1 + 0x654) = 0x3F4CCCCD;
        public float Unknown658;     // offset: 0x658, sz: 4, origin: 0x3F000000, parsed: 0.5        // line:   *(_DWORD *)(v1 + 0x658) = 0x3F000000;
        public float Unknown65C;     // offset: 0x65C, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x65C) = 0x3F800000;
        public float Unknown660;     // offset: 0x660, sz: 4, origin: 0x3F333333, parsed: 0.7        // line:   *(_DWORD *)(v1 + 0x660) = 0x3F333333;
        public float Unknown664;     // offset: 0x664, sz: 4, origin: 0x41A00000, parsed: 20        // line:   *(_DWORD *)(v1 + 0x664) = 0x41A00000;
        public float Unknown668;     // offset: 0x668, sz: 4, origin: 0x42700000, parsed: 60        // line:   *(_DWORD *)(v1 + 0x668) = 0x42700000;
        public float Unknown66C;     // offset: 0x66C, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x66C) = 0x3F800000;
        public float Unknown670;     // offset: 0x670, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x670) = 0x41200000;
        public float Unknown674;     // offset: 0x674, sz: 4, origin: 0x40E00000, parsed: 7        // line:   *(_DWORD *)(v1 + 0x674) = 0x40E00000;
        public float Unknown678;     // offset: 0x678, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x678) = 0x3F800000;
        public float Unknown67C;     // offset: 0x67C, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x67C) = 0x3F800000;
        public float Unknown680;     // offset: 0x680, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x680) = 0x40400000;
        public float Unknown684;     // offset: 0x684, sz: 4, origin: 0x41F00000, parsed: 30        // line:   *(_DWORD *)(v1 + 0x684) = 0x41F00000;
        public float Unknown688;     // offset: 0x688, sz: 4, origin: 0x43FA0000, parsed: 500        // line:   *(_DWORD *)(v1 + 0x688) = 0x43FA0000;
        public float Unknown68C;     // offset: 0x68C, sz: 4, origin: 0x41000000, parsed: 8        // line:   *(_DWORD *)(v1 + 0x68C) = 0x41000000;
        public float Unknown690;     // offset: 0x690, sz: 4, origin: 0x42700000, parsed: 60        // line:   *(_DWORD *)(v1 + 0x690) = 0x42700000;
        public float Unknown694;     // offset: 0x694, sz: 4, origin: 0x42F00000, parsed: 120        // line:   *(_DWORD *)(v1 + 0x694) = 0x42F00000;
        public float Unknown698;     // offset: 0x698, sz: 4, origin: 0x447A0000, parsed: 1000        // line:   *(_DWORD *)(v1 + 0x698) = 0x447A0000;
        public float Unknown69C;     // offset: 0x69C, sz: 4, origin: 0x43FA0000, parsed: 500        // line:   *(_DWORD *)(v1 + 0x69C) = 0x43FA0000;
        public float Unknown6A0;     // offset: 0x6A0, sz: 4, origin: 0x453B8000, parsed: 3000        // line:   *(_DWORD *)(v1 + 0x6A0) = 0x453B8000;
        public float Unknown6A4;     // offset: 0x6A4, sz: 4, origin: 0x42480000, parsed: 50        // line:   *(_DWORD *)(v1 + 0x6A4) = 0x42480000;
        public float Unknown6A8;     // offset: 0x6A8, sz: 4, origin: 0x3DCCCCCD, parsed: 0.1        // line:   *(_DWORD *)(v1 + 0x6A8) = 0x3DCCCCCD;
        public float Unknown6AC;     // offset: 0x6AC, sz: 4, origin: 0x42340000, parsed: 45        // line:   *(_DWORD *)(v1 + 0x6AC) = 0x42340000;
        public float Unknown6B0;     // offset: 0x6B0, sz: 4, origin: 0x40A00000, parsed: 5        // line:   *(_DWORD *)(v1 + 0x6B0) = 0x40A00000;
        public float Unknown6B4;     // offset: 0x6B4, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 0x6B4) = 0x40000000;
        public float Unknown6B8;     // offset: 0x6B8, sz: 4, origin: 0x3F4CCCCD, parsed: 0.8        // line:   *(_DWORD *)(v1 + 0x6B8) = 0x3F4CCCCD;
        public float Unknown6BC;     // offset: 0x6BC, sz: 4, origin: 0x3FE66666, parsed: 1.8        // line:   *(_DWORD *)(v1 + 0x6BC) = 0x3FE66666;
        public float Unknown6C0;     // offset: 0x6C0, sz: 4, origin: 0x41000000, parsed: 8        // line:   *(_DWORD *)(v1 + 0x6C0) = 0x41000000;
        public float Unknown6C4;     // offset: 0x6C4, sz: 4, origin: 0x3ECCCCCD, parsed: 0.4        // line:   *(_DWORD *)(v1 + 0x6C4) = 0x3ECCCCCD;
        public float Unknown6C8;     // offset: 0x6C8, sz: 4, origin: 0x41A00000, parsed: 20        // line:   *(_DWORD *)(v1 + 0x6C8) = 0x41A00000;
        public int Unknown6CC;     // offset: 0x6CC, sz: 4, origin: 2, parsed: 2        // line:   *(_DWORD *)(v1 + 0x6CC) = 2;
        public float Unknown6D0;     // offset: 0x6D0, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 0x6D0) = 0x40000000;
        public float Unknown6D4;     // offset: 0x6D4, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x6D4) = 0x3F800000;

        public GcShipAIAttackData Unknown6D8;
        public GcShipAIAttackData Unknown764;
        public GcShipAIAttackData Unknown7F0;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding87C;

        public GcShipAIPlanetPatrolData Unknown880;

        [NMS(Size = 8, Ignore = true)]
        public byte[] Padding8B8;
    }
}
