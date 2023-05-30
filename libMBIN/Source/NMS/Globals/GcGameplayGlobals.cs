using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    public class GcGameplayGlobals : NMSTemplate
    {
        // generated with MBINRawTemplateParser

        // line: char *__fastcall sub_14014DB40(__int64 a1)
        // line: {
        // line:   __int64 v1; // rdi@1
        // line:   char *result; // rax@1
        public bool Unknown0;     // offset: 0, sz: 1, origin: 0, parsed: 0        // line:   *(_BYTE *)a1 = 0;

        // missing 3 bytes at offset 0
        // does 0 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding1;        // offset: 1, sz: 3, comment: auto padding 

        public int Unknown4;     // offset: 4, sz: 4, origin: 2, parsed: 2        // line:   *(_DWORD *)(a1 + 4) = 2;
        public float Unknown8;     // offset: 8, sz: 4, origin: 1082130432, parsed: 4        // line:   *(_DWORD *)(a1 + 8) = 1082130432;
        public int UnknownC;     // offset: 12, sz: 4, origin: 4, parsed: 4        // line:   *(_DWORD *)(a1 + 12) = 4;
        public float Unknown10;     // offset: 16, sz: 4, origin: 1109393408, parsed: 40        // line:   *(_DWORD *)(a1 + 16) = 1109393408;
        public float Unknown14;     // offset: 20, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(a1 + 20) = 1056964608;
        public float Unknown18;     // offset: 24, sz: 4, origin: 1061997773, parsed: 0.8        // line:   *(_DWORD *)(a1 + 24) = 1061997773;
        public float Unknown1C;     // offset: 28, sz: 4, origin: 1040522936, parsed: 0.13        // line:   *(_DWORD *)(a1 + 28) = 1040522936;
        public int Unknown20;     // offset: 32, sz: 4, origin: 10, parsed: 10        // line:   *(_DWORD *)(a1 + 32) = 10;
        public int Unknown24;     // offset: 36, sz: 4, origin: 30, parsed: 30        // line:   *(_DWORD *)(a1 + 36) = 30;
        public float Unknown28;     // offset: 40, sz: 4, origin: 1106247680, parsed: 30        // line:   *(_DWORD *)(a1 + 40) = 1106247680;
        public float Unknown2C;     // offset: 44, sz: 4, origin: 1106247680, parsed: 30        // line:   *(_DWORD *)(a1 + 44) = 1106247680;
        public float Unknown30;     // offset: 48, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(a1 + 48) = 1114636288;
        public float Unknown34;     // offset: 52, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(a1 + 52) = 1114636288;
        public float Unknown38;     // offset: 56, sz: 4, origin: 1123024896, parsed: 120        // line:   *(_DWORD *)(a1 + 56) = 1123024896;
        public float Unknown3C;     // offset: 60, sz: 4, origin: 1123024896, parsed: 120        // line:   *(_DWORD *)(a1 + 60) = 1123024896;
        public int Unknown40;     // offset: 64, sz: 4, origin: 60, parsed: 60        // line:   *(_DWORD *)(a1 + 64) = 60;
        public int Unknown44;     // offset: 68, sz: 4, origin: 10, parsed: 10        // line:   *(_DWORD *)(a1 + 68) = 10;
        public int Unknown48;     // offset: 72, sz: 4, origin: 30, parsed: 30        // line:   *(_DWORD *)(a1 + 72) = 30;
        public float Unknown4C;     // offset: 76, sz: 4, origin: 1106247680, parsed: 30        // line:   *(_DWORD *)(a1 + 76) = 1106247680;
        public float Unknown50;     // offset: 80, sz: 4, origin: 1106247680, parsed: 30        // line:   *(_DWORD *)(a1 + 80) = 1106247680;
        public float Unknown54;     // offset: 84, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(a1 + 84) = 1114636288;
        public float Unknown58;     // offset: 88, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(a1 + 88) = 1114636288;
        public float Unknown5C;     // offset: 92, sz: 4, origin: 1123024896, parsed: 120        // line:   *(_DWORD *)(a1 + 92) = 1123024896;
        public float Unknown60;     // offset: 96, sz: 4, origin: 1123024896, parsed: 120        // line:   *(_DWORD *)(a1 + 96) = 1123024896;
        public int Unknown64;     // offset: 100, sz: 4, origin: 10, parsed: 10        // line:   *(_DWORD *)(a1 + 100) = 10;
        public int Unknown68;     // offset: 104, sz: 4, origin: 30, parsed: 30        // line:   *(_DWORD *)(a1 + 104) = 30;
        public float Unknown6C;     // offset: 108, sz: 4, origin: 1106247680, parsed: 30        // line:   *(_DWORD *)(a1 + 108) = 1106247680;
        public float Unknown70;     // offset: 112, sz: 4, origin: 1106247680, parsed: 30        // line:   *(_DWORD *)(a1 + 112) = 1106247680;
        public float Unknown74;     // offset: 116, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(a1 + 116) = 1114636288;
        public float Unknown78;     // offset: 120, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(a1 + 120) = 1114636288;
        public float Unknown7C;     // offset: 124, sz: 4, origin: 1123024896, parsed: 120        // line:   *(_DWORD *)(a1 + 124) = 1123024896;
        public float Unknown80;     // offset: 128, sz: 4, origin: 1123024896, parsed: 120        // line:   *(_DWORD *)(a1 + 128) = 1123024896;
        public int Unknown84;     // offset: 132, sz: 4, origin: 10, parsed: 10        // line:   *(_DWORD *)(a1 + 132) = 10;
        public int Unknown88;     // offset: 136, sz: 4, origin: 30, parsed: 30        // line:   *(_DWORD *)(a1 + 136) = 30;
        public float Unknown8C;     // offset: 140, sz: 4, origin: 1106247680, parsed: 30        // line:   *(_DWORD *)(a1 + 140) = 1106247680;
        public float Unknown90;     // offset: 144, sz: 4, origin: 1106247680, parsed: 30        // line:   *(_DWORD *)(a1 + 144) = 1106247680;
        public float Unknown94;     // offset: 148, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(a1 + 148) = 1114636288;
        public float Unknown98;     // offset: 152, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(a1 + 152) = 1114636288;
        public float Unknown9C;     // offset: 156, sz: 4, origin: 1123024896, parsed: 120        // line:   *(_DWORD *)(a1 + 156) = 1123024896;
        public float UnknownA0;     // offset: 160, sz: 4, origin: 1123024896, parsed: 120        // line:   *(_DWORD *)(a1 + 160) = 1123024896;
        public int UnknownA4;     // offset: 164, sz: 4, origin: 10, parsed: 10        // line:   *(_DWORD *)(a1 + 164) = 10;
        public int UnknownA8;     // offset: 168, sz: 4, origin: 30, parsed: 30        // line:   *(_DWORD *)(a1 + 168) = 30;
        public float UnknownAC;     // offset: 172, sz: 4, origin: 1106247680, parsed: 30        // line:   *(_DWORD *)(a1 + 172) = 1106247680;
        public float UnknownB0;     // offset: 176, sz: 4, origin: 1106247680, parsed: 30        // line:   *(_DWORD *)(a1 + 176) = 1106247680;
        public float UnknownB4;     // offset: 180, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(a1 + 180) = 1114636288;
        public float UnknownB8;     // offset: 184, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(a1 + 184) = 1114636288;
        public float UnknownBC;     // offset: 188, sz: 4, origin: 1123024896, parsed: 120        // line:   *(_DWORD *)(a1 + 188) = 1123024896;
        public float UnknownC0;     // offset: 192, sz: 4, origin: 1123024896, parsed: 120        // line:   *(_DWORD *)(a1 + 192) = 1123024896;
        // line:   v1 = a1;
        public int UnknownC4;     // offset: 196, sz: 4, origin: 10, parsed: 10        // line:   *(_DWORD *)(a1 + 196) = 10;
        public long UnknownC8;     // offset: 200, sz: 8, origin: 30i64, parsed: 30        // line:   *(_QWORD *)(a1 + 200) = 30i64;
        public float UnknownD0;     // offset: 208, sz: 4, origin: 1120403456, parsed: 100        // line:   *(_DWORD *)(a1 + 208) = 1120403456;
        public float UnknownD4;     // offset: 212, sz: 4, origin: 1082130432, parsed: 4        // line:   *(_DWORD *)(a1 + 212) = 1082130432;
        public int UnknownD8;     // offset: 216, sz: 4, origin: 250, parsed: 250        // line:   *(_DWORD *)(a1 + 216) = 250;
        public int UnknownDC;     // offset: 220, sz: 4, origin: 3, parsed: 3        // line:   *(_DWORD *)(a1 + 220) = 3;
        public float UnknownE0;     // offset: 224, sz: 4, origin: 1145569280, parsed: 800        // line:   *(_DWORD *)(a1 + 224) = 1145569280;
        public float UnknownE4;     // offset: 228, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(a1 + 228) = 1077936128;
        public int UnknownE8;     // offset: 232, sz: 4, origin: 2, parsed: 2        // line:   *(_DWORD *)(a1 + 232) = 2;
        public int UnknownEC;     // offset: 236, sz: 4, origin: 20, parsed: 20        // line:   *(_DWORD *)(a1 + 236) = 20;
        public int UnknownF0;     // offset: 240, sz: 4, origin: 50, parsed: 50        // line:   *(_DWORD *)(a1 + 240) = 50;
        public int UnknownF4;     // offset: 244, sz: 4, origin: 20, parsed: 20        // line:   *(_DWORD *)(a1 + 244) = 20;
        public int UnknownF8;     // offset: 248, sz: 4, origin: 1, parsed: 1        // line:   *(_DWORD *)(a1 + 248) = 1;
        public int UnknownFC;     // offset: 252, sz: 4, origin: 1, parsed: 1        // line:   *(_DWORD *)(a1 + 252) = 1;
        public int Unknown100;     // offset: 256, sz: 4, origin: 2, parsed: 2        // line:   *(_DWORD *)(a1 + 256) = 2;
        public int Unknown104;     // offset: 260, sz: 4, origin: 1, parsed: 1        // line:   *(_DWORD *)(a1 + 260) = 1;
        public int Unknown108;     // offset: 264, sz: 4, origin: 1, parsed: 1        // line:   *(_DWORD *)(a1 + 264) = 1;
        public int Unknown10C;     // offset: 268, sz: 4, origin: 8, parsed: 8        // line:   *(_DWORD *)(a1 + 268) = 8;
        public NMSString0x20 Unknown110;     // offset: 272, sz: 32, origin:  "Hr"        // line:   strncpy((char *)(a1 + 272), "Hr", 0x20ui64);
        // line:   *(_BYTE *)(v1 + 303) = 0;
        public NMSString0x20 Unknown130;     // offset: 304, sz: 32, origin:  "Ch"        // line:   strncpy((char *)(v1 + 304), "Ch", 0x20ui64);
        // line:   *(_BYTE *)(v1 + 335) = 0;
        public float Unknown150;     // offset: 336, sz: 4, origin: 1099956224, parsed: 18        // line:   *(_DWORD *)(v1 + 336) = 1099956224;
        public float Unknown154;     // offset: 340, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 340) = 1092616192;
        public float Unknown158;     // offset: 344, sz: 4, origin: 1121714176, parsed: 110        // line:   *(_DWORD *)(v1 + 344) = 1121714176;
        public float Unknown15C;     // offset: 348, sz: 4, origin: -1102263091, parsed: -0.2        // line:   *(_DWORD *)(v1 + 348) = -1102263091;
        public float Unknown160;     // offset: 352, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(v1 + 352) = 1036831949;
        public float Unknown164;     // offset: 356, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 356) = 1045220557;
        public float Unknown168;     // offset: 360, sz: 4, origin: 1067030938, parsed: 1.2        // line:   *(_DWORD *)(v1 + 360) = 1067030938;
        public float Unknown16C;     // offset: 364, sz: 4, origin: 1075838976, parsed: 2.5        // line:   *(_DWORD *)(v1 + 364) = 1075838976;
        public float Unknown170;     // offset: 368, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v1 + 368) = 1056964608;
        public float Unknown174;     // offset: 372, sz: 4, origin: 1063675494, parsed: 0.9        // line:   *(_DWORD *)(v1 + 372) = 1063675494;
        public float Unknown178;     // offset: 376, sz: 4, origin: 1060320051, parsed: 0.7        // line:   *(_DWORD *)(v1 + 376) = 1060320051;
        public float Unknown17C;     // offset: 380, sz: 4, origin: 1066192077, parsed: 1.1        // line:   *(_DWORD *)(v1 + 380) = 1066192077;
        public float Unknown180;     // offset: 384, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v1 + 384) = 1056964608;
        public float Unknown184;     // offset: 388, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 388) = 0x40000000;
        public float Unknown188;     // offset: 392, sz: 4, origin: 1069547520, parsed: 1.5        // line:   *(_DWORD *)(v1 + 392) = 1069547520;
        public float Unknown18C;     // offset: 396, sz: 4, origin: 1082130432, parsed: 4        // line:   *(_DWORD *)(v1 + 396) = 1082130432;
        public float Unknown190;     // offset: 400, sz: 4, origin: 1062836634i64, parsed: 0.85, comment: two packed floats in a QWORD?(1)
        public float Unknown194;     // offset: 404, sz: 4, origin: 1062836634i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 400) = 1062836634i64;
        public float Unknown198;     // offset: 408, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 408) = 1092616192;
        public float Unknown19C;     // offset: 412, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 412) = 1092616192;
        public bool Unknown1A0;     // offset: 416, sz: 1, origin: 1, parsed: 1        // line:   *(_BYTE *)(v1 + 416) = 1;

        // missing 3 bytes at offset 416
        // does 416 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding1A1;        // offset: 417, sz: 3, comment: auto padding 

        public float Unknown1A4;     // offset: 420, sz: 4, origin: 1082130432i64, parsed: 4, comment: two packed floats in a QWORD?(1)
        public float Unknown1A8;     // offset: 424, sz: 4, origin: 1082130432i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 420) = 1082130432i64;
        public float Unknown1AC;     // offset: 428, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 428) = 1092616192;
        public float Unknown1B0;     // offset: 432, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 432) = 1092616192;
        public bool Unknown1B4;     // offset: 436, sz: 1, origin: 1, parsed: 1        // line:   *(_BYTE *)(v1 + 436) = 1;

        // missing 3 bytes at offset 436
        // does 436 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding1B5;        // offset: 437, sz: 3, comment: auto padding 

        public float Unknown1B8;     // offset: 440, sz: 4, origin: 1082130432i64, parsed: 4, comment: two packed floats in a QWORD?(1)
        public float Unknown1BC;     // offset: 444, sz: 4, origin: 1082130432i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 440) = 1082130432i64;
        public float Unknown1C0;     // offset: 448, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 448) = 1092616192;
        public float Unknown1C4;     // offset: 452, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 452) = 1092616192;
        public bool Unknown1C8;     // offset: 456, sz: 1, origin: 1, parsed: 1        // line:   *(_BYTE *)(v1 + 456) = 1;

        // missing 3 bytes at offset 456
        // does 456 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding1C9;        // offset: 457, sz: 3, comment: auto padding 

        public float Unknown1CC;     // offset: 460, sz: 4, origin: 1082130432i64, parsed: 4, comment: two packed floats in a QWORD?(1)
        public float Unknown1D0;     // offset: 464, sz: 4, origin: 1082130432i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 460) = 1082130432i64;
        public float Unknown1D4;     // offset: 468, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 468) = 1092616192;
        public float Unknown1D8;     // offset: 472, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 472) = 1092616192;
        public bool Unknown1DC;     // offset: 476, sz: 1, origin: 1, parsed: 1        // line:   *(_BYTE *)(v1 + 476) = 1;

        // missing 3 bytes at offset 476
        // does 476 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding1DD;        // offset: 477, sz: 3, comment: auto padding 

        public float Unknown1E0;     // offset: 480, sz: 4, origin: 1082130432i64, parsed: 4, comment: two packed floats in a QWORD?(1)
        public float Unknown1E4;     // offset: 484, sz: 4, origin: 1082130432i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 480) = 1082130432i64;
        public float Unknown1E8;     // offset: 488, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 488) = 1092616192;
        public float Unknown1EC;     // offset: 492, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 492) = 1092616192;
        public bool Unknown1F0;     // offset: 496, sz: 1, origin: 1, parsed: 1        // line:   *(_BYTE *)(v1 + 496) = 1;

        // missing 3 bytes at offset 496
        // does 496 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding1F1;        // offset: 497, sz: 3, comment: auto padding 

        public float Unknown1F4;     // offset: 500, sz: 4, origin: 1082130432i64, parsed: 4, comment: two packed floats in a QWORD?(1)
        public float Unknown1F8;     // offset: 504, sz: 4, origin: 1082130432i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 500) = 1082130432i64;
        public float Unknown1FC;     // offset: 508, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 508) = 1092616192;
        public float Unknown200;     // offset: 512, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 512) = 1092616192;
        public bool Unknown204;     // offset: 516, sz: 1, origin: 1, parsed: 1        // line:   *(_BYTE *)(v1 + 516) = 1;

        // missing 3 bytes at offset 516
        // does 516 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding205;        // offset: 517, sz: 3, comment: auto padding 

        public float Unknown208;     // offset: 520, sz: 4, origin: 1082130432i64, parsed: 4, comment: two packed floats in a QWORD?(1)
        public float Unknown20C;     // offset: 524, sz: 4, origin: 1082130432i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 520) = 1082130432i64;
        public float Unknown210;     // offset: 528, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 528) = 1092616192;
        public float Unknown214;     // offset: 532, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 532) = 1092616192;
        public bool Unknown218;     // offset: 536, sz: 1, origin: 1, parsed: 1        // line:   *(_BYTE *)(v1 + 536) = 1;

        // missing 3 bytes at offset 536
        // does 536 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding219;        // offset: 537, sz: 3, comment: auto padding 

        public float Unknown21C;     // offset: 540, sz: 4, origin: 1082130432i64, parsed: 4, comment: two packed floats in a QWORD?(1)
        public float Unknown220;     // offset: 544, sz: 4, origin: 1082130432i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 540) = 1082130432i64;
        public float Unknown224;     // offset: 548, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 548) = 1092616192;
        public float Unknown228;     // offset: 552, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 552) = 1092616192;
        public bool Unknown22C;     // offset: 556, sz: 1, origin: 1, parsed: 1        // line:   *(_BYTE *)(v1 + 556) = 1;

        // missing 3 bytes at offset 556
        // does 556 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding22D;        // offset: 557, sz: 3, comment: auto padding 

        public float Unknown230;     // offset: 560, sz: 4, origin: 1082130432i64, parsed: 4, comment: two packed floats in a QWORD?(1)
        public float Unknown234;     // offset: 564, sz: 4, origin: 1082130432i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 560) = 1082130432i64;
        public float Unknown238;     // offset: 568, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 568) = 1092616192;
        public float Unknown23C;     // offset: 572, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 572) = 1092616192;
        public bool Unknown240;     // offset: 576, sz: 1, origin: 1, parsed: 1        // line:   *(_BYTE *)(v1 + 576) = 1;

        // missing 3 bytes at offset 576
        // does 576 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding241;        // offset: 577, sz: 3, comment: auto padding 

        public float Unknown244;     // offset: 580, sz: 4, origin: 1082130432i64, parsed: 4, comment: two packed floats in a QWORD?(1)
        public float Unknown248;     // offset: 584, sz: 4, origin: 1082130432i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 580) = 1082130432i64;
        public float Unknown24C;     // offset: 588, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 588) = 1092616192;
        public float Unknown250;     // offset: 592, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 592) = 1092616192;
        public bool Unknown254;     // offset: 596, sz: 1, origin: 1, parsed: 1        // line:   *(_BYTE *)(v1 + 596) = 1;

        // missing 3 bytes at offset 596
        // does 596 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding255;        // offset: 597, sz: 3, comment: auto padding 

        public float Unknown258;     // offset: 600, sz: 4, origin: 1082130432, parsed: 4        // line:   *(_DWORD *)(v1 + 600) = 1082130432;
        public float Unknown25C;     // offset: 604, sz: 4, origin: 1142292480, parsed: 600        // line:   *(_DWORD *)(v1 + 604) = 1142292480;
        public float Unknown260;     // offset: 608, sz: 4, origin: 1061997773, parsed: 0.8        // line:   *(_DWORD *)(v1 + 608) = 1061997773;
        public float Unknown264;     // offset: 612, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 612) = 1045220557;
        public long Unknown268;     // offset: 616, sz: 8, origin: 1i64, parsed: 1        // line:   *(_QWORD *)(v1 + 616) = 1i64;
        public float Unknown270;     // offset: 624, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 624) = 1065353216;
        public float Unknown274;     // offset: 628, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 628) = 1092616192;
        public float Unknown278;     // offset: 632, sz: 4, origin: 1092616192i64, parsed: 10, comment: two packed floats in a QWORD?(1)
        public float Unknown27C;     // offset: 636, sz: 4, origin: 1092616192i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 632) = 1092616192i64;
        public float Unknown280;     // offset: 640, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 640) = 1092616192;
        public float Unknown284;     // offset: 644, sz: 4, origin: 1065353216i64, parsed: 1, comment: two packed floats in a QWORD?(1)
        public float Unknown288;     // offset: 648, sz: 4, origin: 1065353216i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 644) = 1065353216i64;
        public float Unknown28C;     // offset: 652, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 652) = 1065353216;
        public float Unknown290;     // offset: 656, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 656) = 1092616192;
        public float Unknown294;     // offset: 660, sz: 4, origin: 1092616192i64, parsed: 10, comment: two packed floats in a QWORD?(1)
        public float Unknown298;     // offset: 664, sz: 4, origin: 1092616192i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 660) = 1092616192i64;
        public float Unknown29C;     // offset: 668, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 668) = 1092616192;
        public float Unknown2A0;     // offset: 672, sz: 4, origin: 1065353216i64, parsed: 1, comment: two packed floats in a QWORD?(1)
        public float Unknown2A4;     // offset: 676, sz: 4, origin: 1065353216i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 672) = 1065353216i64;
        public float Unknown2A8;     // offset: 680, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 680) = 1065353216;
        public float Unknown2AC;     // offset: 684, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 684) = 1092616192;
        public float Unknown2B0;     // offset: 688, sz: 4, origin: 1092616192i64, parsed: 10, comment: two packed floats in a QWORD?(1)
        public float Unknown2B4;     // offset: 692, sz: 4, origin: 1092616192i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 688) = 1092616192i64;
        public float Unknown2B8;     // offset: 696, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 696) = 1092616192;
        public float Unknown2BC;     // offset: 700, sz: 4, origin: 1065353216i64, parsed: 1, comment: two packed floats in a QWORD?(1)
        public float Unknown2C0;     // offset: 704, sz: 4, origin: 1065353216i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 700) = 1065353216i64;
        public float Unknown2C4;     // offset: 708, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 708) = 1065353216;
        public float Unknown2C8;     // offset: 712, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 712) = 1092616192;
        public float Unknown2CC;     // offset: 716, sz: 4, origin: 1092616192i64, parsed: 10, comment: two packed floats in a QWORD?(1)
        public float Unknown2D0;     // offset: 720, sz: 4, origin: 1092616192i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 716) = 1092616192i64;
        public float Unknown2D4;     // offset: 724, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 724) = 1092616192;
        public float Unknown2D8;     // offset: 728, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 728) = 1065353216;

        // missing 4 bytes at offset 728
        // could be a subroutine, padding or something that the parser skipped
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding2DC;        // offset: 732, sz: 4, comment: auto padding 

        public float Unknown2E0;     // offset: 736, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 736) = 0;

        // missing 12 bytes at offset 736
        // could be a subroutine, padding or something that the parser skipped
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding2E4;        // offset: 740, sz: 12, comment: auto padding 

        public float Unknown2F0;     // offset: 752, sz: 4, origin: 1062383649, parsed: 0.823        // line:   *(_DWORD *)(v1 + 752) = 1062383649;
        public float Unknown2F4;     // offset: 756, sz: 4, origin: 1056125747, parsed: 0.475        // line:   *(_DWORD *)(v1 + 756) = 1056125747;
        public float Unknown2F8;     // offset: 760, sz: 4, origin: 1054682907, parsed: 0.432        // line:   *(_DWORD *)(v1 + 760) = 1054682907;
        public float Unknown2FC;     // offset: 764, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 764) = 1065353216;
        public float Unknown300;     // offset: 768, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 768) = 1045220557;
        public float Unknown304;     // offset: 772, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(v1 + 772) = 1036831949;
        public float Unknown308;     // offset: 776, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(v1 + 776) = 1077936128;
        public bool Unknown30C;     // offset: 780, sz: 1, origin: 0, parsed: 0        // line:   *(_BYTE *)(v1 + 780) = 0;

        // missing 3 bytes at offset 780
        // does 780 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding30D;        // offset: 781, sz: 3, comment: auto padding 

        public float Unknown310;     // offset: 784, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 784) = 1045220557;
        public float Unknown314;     // offset: 788, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 788) = 1045220557;

        // missing 8 bytes at offset 788
        // could be a subroutine, padding or something that the parser skipped
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] Padding318;        // offset: 792, sz: 8, comment: auto padding 

        public float Unknown320;     // offset: 800, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 800) = 0;

        // missing 12 bytes at offset 800
        // could be a subroutine, padding or something that the parser skipped
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding324;        // offset: 804, sz: 12, comment: auto padding 

        public float Unknown330;     // offset: 816, sz: 4, origin: 1062383649, parsed: 0.823        // line:   *(_DWORD *)(v1 + 816) = 1062383649;
        public float Unknown334;     // offset: 820, sz: 4, origin: 1056125747, parsed: 0.475        // line:   *(_DWORD *)(v1 + 820) = 1056125747;
        public float Unknown338;     // offset: 824, sz: 4, origin: 1054682907, parsed: 0.432        // line:   *(_DWORD *)(v1 + 824) = 1054682907;
        public float Unknown33C;     // offset: 828, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 828) = 1065353216;
        public float Unknown340;     // offset: 832, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 832) = 1045220557;
        public float Unknown344;     // offset: 836, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(v1 + 836) = 1036831949;
        public float Unknown348;     // offset: 840, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(v1 + 840) = 1077936128;
        public bool Unknown34C;     // offset: 844, sz: 1, origin: 0, parsed: 0        // line:   *(_BYTE *)(v1 + 844) = 0;

        // missing 3 bytes at offset 844
        // does 844 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding34D;        // offset: 845, sz: 3, comment: auto padding 

        public float Unknown350;     // offset: 848, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 848) = 1045220557;
        public float Unknown354;     // offset: 852, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 852) = 1045220557;

        // missing 8 bytes at offset 852
        // could be a subroutine, padding or something that the parser skipped
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] Padding358;        // offset: 856, sz: 8, comment: auto padding 

        public float Unknown360;     // offset: 864, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 864) = 0;

        // missing 12 bytes at offset 864
        // could be a subroutine, padding or something that the parser skipped
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding364;        // offset: 868, sz: 12, comment: auto padding 

        public float Unknown370;     // offset: 880, sz: 4, origin: 1062383649, parsed: 0.823        // line:   *(_DWORD *)(v1 + 880) = 1062383649;
        public float Unknown374;     // offset: 884, sz: 4, origin: 1056125747, parsed: 0.475        // line:   *(_DWORD *)(v1 + 884) = 1056125747;
        public float Unknown378;     // offset: 888, sz: 4, origin: 1054682907, parsed: 0.432        // line:   *(_DWORD *)(v1 + 888) = 1054682907;
        public float Unknown37C;     // offset: 892, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 892) = 1065353216;
        public float Unknown380;     // offset: 896, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 896) = 1045220557;
        public float Unknown384;     // offset: 900, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(v1 + 900) = 1036831949;
        public float Unknown388;     // offset: 904, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(v1 + 904) = 1077936128;
        public bool Unknown38C;     // offset: 908, sz: 1, origin: 0, parsed: 0        // line:   *(_BYTE *)(v1 + 908) = 0;

        // missing 3 bytes at offset 908
        // does 908 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding38D;        // offset: 909, sz: 3, comment: auto padding 

        public float Unknown390;     // offset: 912, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 912) = 1045220557;
        public float Unknown394;     // offset: 916, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 916) = 1045220557;

        // missing 8 bytes at offset 916
        // could be a subroutine, padding or something that the parser skipped
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] Padding398;        // offset: 920, sz: 8, comment: auto padding 

        public float Unknown3A0;     // offset: 928, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 928) = 0;

        // missing 12 bytes at offset 928
        // could be a subroutine, padding or something that the parser skipped
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding3A4;        // offset: 932, sz: 12, comment: auto padding 

        public float Unknown3B0;     // offset: 944, sz: 4, origin: 1062383649, parsed: 0.823        // line:   *(_DWORD *)(v1 + 944) = 1062383649;
        public float Unknown3B4;     // offset: 948, sz: 4, origin: 1056125747, parsed: 0.475        // line:   *(_DWORD *)(v1 + 948) = 1056125747;
        public float Unknown3B8;     // offset: 952, sz: 4, origin: 1054682907, parsed: 0.432        // line:   *(_DWORD *)(v1 + 952) = 1054682907;
        public float Unknown3BC;     // offset: 956, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 956) = 1065353216;
        public float Unknown3C0;     // offset: 960, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 960) = 1045220557;
        public float Unknown3C4;     // offset: 964, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(v1 + 964) = 1036831949;
        public float Unknown3C8;     // offset: 968, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(v1 + 968) = 1077936128;
        public bool Unknown3CC;     // offset: 972, sz: 1, origin: 0, parsed: 0        // line:   *(_BYTE *)(v1 + 972) = 0;

        // missing 3 bytes at offset 972
        // does 972 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding3CD;        // offset: 973, sz: 3, comment: auto padding 

        public float Unknown3D0;     // offset: 976, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 976) = 1045220557;
        public float Unknown3D4;     // offset: 980, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 980) = 1045220557;

        // missing 8 bytes at offset 980
        // could be a subroutine, padding or something that the parser skipped
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] Padding3D8;        // offset: 984, sz: 8, comment: auto padding 

        public float Unknown3E0;     // offset: 992, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 992) = 0;

        // missing 12 bytes at offset 992
        // could be a subroutine, padding or something that the parser skipped
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding3E4;        // offset: 996, sz: 12, comment: auto padding 

        public float Unknown3F0;     // offset: 1008, sz: 4, origin: 1062383649, parsed: 0.823        // line:   *(_DWORD *)(v1 + 1008) = 1062383649;
        public float Unknown3F4;     // offset: 1012, sz: 4, origin: 1056125747, parsed: 0.475        // line:   *(_DWORD *)(v1 + 1012) = 1056125747;
        public float Unknown3F8;     // offset: 1016, sz: 4, origin: 1054682907, parsed: 0.432        // line:   *(_DWORD *)(v1 + 1016) = 1054682907;
        public float Unknown3FC;     // offset: 1020, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 1020) = 1065353216;
        public float Unknown400;     // offset: 1024, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 1024) = 1045220557;
        public float Unknown404;     // offset: 1028, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(v1 + 1028) = 1036831949;
        public float Unknown408;     // offset: 1032, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(v1 + 1032) = 1077936128;
        public bool Unknown40C;     // offset: 1036, sz: 1, origin: 0, parsed: 0        // line:   *(_BYTE *)(v1 + 1036) = 0;

        // missing 3 bytes at offset 1036
        // does 1036 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding40D;        // offset: 1037, sz: 3, comment: auto padding 

        public float Unknown410;     // offset: 1040, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 1040) = 1045220557;
        public float Unknown414;     // offset: 1044, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 1044) = 1045220557;

        // missing 8 bytes at offset 1044
        // could be a subroutine, padding or something that the parser skipped
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] Padding418;        // offset: 1048, sz: 8, comment: auto padding 

        public short Unknown420;     // offset: 1056, sz: 2, origin: 0, parsed: 0        // line:   *(_WORD *)(v1 + 1056) = 0;

        // missing 2 bytes at offset 1056
        // could be a subroutine, padding or something that the parser skipped
        [NMS(Size = 0x2, Ignore = true)]
        public byte[] Padding422;        // offset: 1058, sz: 2, comment: auto padding 

        public float Unknown424;     // offset: 1060, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 1060) = 0;
        public float Unknown428;     // offset: 1064, sz: 4, origin: 1101004800, parsed: 20        // line:   *(_DWORD *)(v1 + 1064) = 1101004800;
        public float Unknown42C;     // offset: 1068, sz: 4, origin: 1148846080i64, parsed: 1000, comment: two packed floats in a QWORD?(1)
        public float Unknown430;     // offset: 1072, sz: 4, origin: 1148846080i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 1068) = 1148846080i64;
        public float Unknown434;     // offset: 1076, sz: 4, origin: 1123024896, parsed: 120        // line:   *(_DWORD *)(v1 + 1076) = 1123024896;
        public float Unknown438;     // offset: 1080, sz: 4, origin: 1084227584, parsed: 5        // line:   *(_DWORD *)(v1 + 1080) = 1084227584;
        public float Unknown43C;     // offset: 1084, sz: 4, origin: 1103626240, parsed: 25        // line:   *(_DWORD *)(v1 + 1084) = 1103626240;
        public float Unknown440;     // offset: 1088, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v1 + 1088) = 1056964608;
        public float Unknown444;     // offset: 1092, sz: 4, origin: 1108082688, parsed: 35        // line:   *(_DWORD *)(v1 + 1092) = 1108082688;
        public float Unknown448;     // offset: 1096, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(v1 + 1096) = 1077936128;
        public float Unknown44C;     // offset: 1100, sz: 4, origin: 1075419546, parsed: 2.4        // line:   *(_DWORD *)(v1 + 1100) = 1075419546;
        public float Unknown450;     // offset: 1104, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v1 + 1104) = 1056964608;
        public float Unknown454;     // offset: 1108, sz: 4, origin: 1117782016, parsed: 80        // line:   *(_DWORD *)(v1 + 1108) = 1117782016;
        public float Unknown458;     // offset: 1112, sz: 4, origin: 1063675494, parsed: 0.9        // line:   *(_DWORD *)(v1 + 1112) = 1063675494;
        public float Unknown45C;     // offset: 1116, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 1116) = 1045220557;
        public float Unknown460;     // offset: 1120, sz: 4, origin: 1053609165, parsed: 0.4        // line:   *(_DWORD *)(v1 + 1120) = 1053609165;
        public float Unknown464;     // offset: 1124, sz: 4, origin: 1050253722, parsed: 0.3        // line:   *(_DWORD *)(v1 + 1124) = 1050253722;
        public bool Unknown468;     // offset: 1128, sz: 1, origin: 1, parsed: 1        // line:   *(_BYTE *)(v1 + 1128) = 1;

        // missing 7 bytes at offset 1128
        // does 1128 contain a QWORD?
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] Padding469;        // offset: 1129, sz: 7, comment: auto padding 

        public float Unknown470;     // offset: 1136, sz: 4, origin: 1050253722, parsed: 0.3        // line:   *(_DWORD *)(v1 + 1136) = 1050253722;
        public float Unknown474;     // offset: 1140, sz: 4, origin: 1063675494, parsed: 0.9        // line:   *(_DWORD *)(v1 + 1140) = 1063675494;
        public float Unknown478;     // offset: 1144, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 1144) = 1065353216;
        public float Unknown47C;     // offset: 1148, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 1148) = 1065353216;
        public float Unknown480;     // offset: 1152, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 1152) = 1065353216;
        public float Unknown484;     // offset: 1156, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v1 + 1156) = 1056964608;
        public float Unknown488;     // offset: 1160, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 1160) = 1045220557;
        public float Unknown48C;     // offset: 1164, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 1164) = 1065353216;
        public float Unknown490;     // offset: 1168, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 1168) = 1045220557;
        public float Unknown494;     // offset: 1172, sz: 4, origin: 1117782016, parsed: 80        // line:   *(_DWORD *)(v1 + 1172) = 1117782016;
        public float Unknown498;     // offset: 1176, sz: 4, origin: 1176256512, parsed: 10000        // line:   *(_DWORD *)(v1 + 1176) = 1176256512;
        public float Unknown49C;     // offset: 1180, sz: 4, origin: 1148846080, parsed: 1000        // line:   *(_DWORD *)(v1 + 1180) = 1148846080;
        public float Unknown4A0;     // offset: 1184, sz: 4, origin: 1069547520, parsed: 1.5        // line:   *(_DWORD *)(v1 + 1184) = 1069547520;
        public float Unknown4A4;     // offset: 1188, sz: 4, origin: 1028443341, parsed: 0.05        // line:   *(_DWORD *)(v1 + 1188) = 1028443341;
        public float Unknown4A8;     // offset: 1192, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(v1 + 1192) = 1036831949;
        public float Unknown4AC;     // offset: 1196, sz: 4, origin: 1125515264, parsed: 150        // line:   *(_DWORD *)(v1 + 1196) = 1125515264;
        public float Unknown4B0;     // offset: 1200, sz: 4, origin: 1058642330, parsed: 0.6        // line:   *(_DWORD *)(v1 + 1200) = 1058642330;
        public bool Unknown4B4;     // offset: 1204, sz: 1, origin: 0, parsed: 0        // line:   *(_BYTE *)(v1 + 1204) = 0;

        // missing 3 bytes at offset 1204
        // does 1204 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding4B5;        // offset: 1205, sz: 3, comment: auto padding 

        public float Unknown4B8;     // offset: 1208, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v1 + 1208) = 1056964608;
        public float Unknown4BC;     // offset: 1212, sz: 4, origin: 1069547520, parsed: 1.5        // line:   *(_DWORD *)(v1 + 1212) = 1069547520;
        public float Unknown4C0;     // offset: 1216, sz: 4, origin: 1128792064, parsed: 200        // line:   *(_DWORD *)(v1 + 1216) = 1128792064;
        public float Unknown4C4;     // offset: 1220, sz: 4, origin: 1137180672, parsed: 400        // line:   *(_DWORD *)(v1 + 1220) = 1137180672;
        public float Unknown4C8;     // offset: 1224, sz: 4, origin: 1133903872, parsed: 300        // line:   *(_DWORD *)(v1 + 1224) = 1133903872;
        public float Unknown4CC;     // offset: 1228, sz: 4, origin: 1133903872, parsed: 300        // line:   *(_DWORD *)(v1 + 1228) = 1133903872;
        public float Unknown4D0;     // offset: 1232, sz: 4, origin: 1058625552, parsed: 0.599        // line:   *(_DWORD *)(v1 + 1232) = 1058625552;
        public float Unknown4D4;     // offset: 1236, sz: 4, origin: 1059246309, parsed: 0.636        // line:   *(_DWORD *)(v1 + 1236) = 1059246309;
        public float Unknown4D8;     // offset: 1240, sz: 4, origin: 1064346583, parsed: 0.94        // line:   *(_DWORD *)(v1 + 1240) = 1064346583;
        public float Unknown4DC;     // offset: 1244, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 1244) = 1065353216;
        public float Unknown4E0;     // offset: 1248, sz: 4, origin: 1064732459, parsed: 0.963        // line:   *(_DWORD *)(v1 + 1248) = 1064732459;
        public float Unknown4E4;     // offset: 1252, sz: 4, origin: 1045019230, parsed: 0.197        // line:   *(_DWORD *)(v1 + 1252) = 1045019230;
        public float Unknown4E8;     // offset: 1256, sz: 4, origin: 1045019230, parsed: 0.197        // line:   *(_DWORD *)(v1 + 1256) = 1045019230;
        public float Unknown4EC;     // offset: 1260, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 1260) = 1065353216;
        public float Unknown4F0;     // offset: 1264, sz: 4, origin: -1046478848, parsed: -20        // line:   *(_DWORD *)(v1 + 1264) = -1046478848;
        public float Unknown4F4;     // offset: 1268, sz: 4, origin: 1060320051, parsed: 0.7        // line:   *(_DWORD *)(v1 + 1268) = 1060320051;
        public float Unknown4F8;     // offset: 1272, sz: 4, origin: 1137836032, parsed: 420        // line:   *(_DWORD *)(v1 + 1272) = 1137836032;

        // missing 4 bytes at offset 1272
        // could be a subroutine, padding or something that the parser skipped
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4FC;        // offset: 1276, sz: 4, comment: auto padding 

        public GcShipHUDTargetData Template500;     // offset: 1280, sz: 1072, origin: sub_14014C2E0(v1 + 1280);, comment: call sub        // line:   sub_14014C2E0(v1 + 1280);
        public float Unknown930;     // offset: 2352, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v1 + 2352) = 1056964608;
        public float Unknown934;     // offset: 2356, sz: 4, origin: 1110704128, parsed: 45        // line:   *(_DWORD *)(v1 + 2356) = 1110704128;
        public float Unknown938;     // offset: 2360, sz: 4, origin: 1128792064, parsed: 200        // line:   *(_DWORD *)(v1 + 2360) = 1128792064;
        public float Unknown93C;     // offset: 2364, sz: 4, origin: -1063256064, parsed: -5        // line:   *(_DWORD *)(v1 + 2364) = -1063256064;
        public float Unknown940;     // offset: 2368, sz: 4, origin: 1069547520, parsed: 1.5        // line:   *(_DWORD *)(v1 + 2368) = 1069547520;
        public float Unknown944;     // offset: 2372, sz: 4, origin: 1095761920, parsed: 13        // line:   *(_DWORD *)(v1 + 2372) = 1095761920;
        public float Unknown948;     // offset: 2376, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v1 + 2376) = 1056964608;
        public float Unknown94C;     // offset: 2380, sz: 4, origin: 1084227584, parsed: 5        // line:   *(_DWORD *)(v1 + 2380) = 1084227584;
        public NMSString0x80 Unknown950;     // offset: 2384, sz: 128, origin:  "MODELS/COMMON/PROJECTILES/RESOURCESHARD.SCENE.MBIN"        // line:   strncpy((char *)(v1 + 2384), "MODELS/COMMON/PROJECTILES/RESOURCESHARD.SCENE.MBIN", 0x80ui64);
        // line:   *(_BYTE *)(v1 + 2511) = 0;
        public float Unknown9D0;     // offset: 2512, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 2512) = 0x40000000;
        public float Unknown9D4;     // offset: 2516, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 2516) = 1092616192;
        public int Unknown9D8;     // offset: 2520, sz: 4, origin: 8, parsed: 8        // line:   *(_DWORD *)(v1 + 2520) = 8;
        public int Unknown9DC;     // offset: 2524, sz: 4, origin: 1, parsed: 1        // line:   *(_DWORD *)(v1 + 2524) = 1;
        public float Unknown9E0;     // offset: 2528, sz: 4, origin: 1143930880, parsed: 700        // line:   *(_DWORD *)(v1 + 2528) = 1143930880;
        public float Unknown9E4;     // offset: 2532, sz: 4, origin: 1152319488, parsed: 1400        // line:   *(_DWORD *)(v1 + 2532) = 1152319488;
        public float Unknown9E8;     // offset: 2536, sz: 4, origin: 1097859072, parsed: 15        // line:   *(_DWORD *)(v1 + 2536) = 1097859072;
        public float Unknown9EC;     // offset: 2540, sz: 4, origin: 1098907648, parsed: 16        // line:   *(_DWORD *)(v1 + 2540) = 1098907648;
        public float Unknown9F0;     // offset: 2544, sz: 4, origin: 1130102784, parsed: 220        // line:   *(_DWORD *)(v1 + 2544) = 1130102784;
        public float Unknown9F4;     // offset: 2548, sz: 4, origin: 1067030938, parsed: 1.2        // line:   *(_DWORD *)(v1 + 2548) = 1067030938;
        public float Unknown9F8;     // offset: 2552, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 2552) = 1065353216;
        public float Unknown9FC;     // offset: 2556, sz: 4, origin: 1101004800, parsed: 20        // line:   *(_DWORD *)(v1 + 2556) = 1101004800;
        public float UnknownA00;     // offset: 2560, sz: 4, origin: 1101004800, parsed: 20        // line:   *(_DWORD *)(v1 + 2560) = 1101004800;
        public float UnknownA04;     // offset: 2564, sz: 4, origin: 1133903872, parsed: 300        // line:   *(_DWORD *)(v1 + 2564) = 1133903872;
        public float UnknownA08;     // offset: 2568, sz: 4, origin: 1112014848, parsed: 50        // line:   *(_DWORD *)(v1 + 2568) = 1112014848;
        public float UnknownA0C;     // offset: 2572, sz: 4, origin: 1008981770, parsed: 0.01        // line:   *(_DWORD *)(v1 + 2572) = 1008981770;
        public float UnknownA10;     // offset: 2576, sz: 4, origin: 1034147594, parsed: 0.08        // line:   *(_DWORD *)(v1 + 2576) = 1034147594;
        public float UnknownA14;     // offset: 2580, sz: 4, origin: 1097859072, parsed: 15        // line:   *(_DWORD *)(v1 + 2580) = 1097859072;
        public float UnknownA18;     // offset: 2584, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 2584) = 1092616192;
        public float UnknownA1C;     // offset: 2588, sz: 4, origin: 1065353216i64, parsed: 1, comment: two packed floats in a QWORD?(1)
        public float UnknownA20;     // offset: 2592, sz: 4, origin: 1065353216i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 2588) = 1065353216i64;

        // missing 12 bytes at offset 2588
        // could be a subroutine, padding or something that the parser skipped
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] PaddingA24;        // offset: 2596, sz: 12, comment: auto padding 

        public float UnknownA30;     // offset: 2608, sz: 4, origin: 1052938076, parsed: 0.38        // line:   *(_DWORD *)(v1 + 2608) = 1052938076;
        public float UnknownA34;     // offset: 2612, sz: 4, origin: 1060336828, parsed: 0.701        // line:   *(_DWORD *)(v1 + 2612) = 1060336828;
        public float UnknownA38;     // offset: 2616, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 2616) = 1065353216;
        public float UnknownA3C;     // offset: 2620, sz: 4, origin: 1065353216i64, parsed: 1, comment: two packed floats in a QWORD?(1)
        public float UnknownA40;     // offset: 2624, sz: 4, origin: 1065353216i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 2620) = 1065353216i64;
        public long UnknownA44;     // offset: 2628, sz: 8, origin: 0i64, parsed: 0. comment: either a long or two floats        // line:   *(_QWORD *)(v1 + 2628) = 0i64;
        public float UnknownA4C;     // offset: 2636, sz: 4, origin: 1101004800, parsed: 20        // line:   *(_DWORD *)(v1 + 2636) = 1101004800;
        public float UnknownA50;     // offset: 2640, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 2640) = 1092616192;
        public float UnknownA54;     // offset: 2644, sz: 4, origin: 1008981770, parsed: 0.01        // line:   *(_DWORD *)(v1 + 2644) = 1008981770;
        public float UnknownA58;     // offset: 2648, sz: 4, origin: 1050253722, parsed: 0.3        // line:   *(_DWORD *)(v1 + 2648) = 1050253722;
        public float UnknownA5C;     // offset: 2652, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(v1 + 2652) = 1114636288;
        public float UnknownA60;     // offset: 2656, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 2656) = 1065353216;
        public float UnknownA64;     // offset: 2660, sz: 4, origin: 1095761920, parsed: 13        // line:   *(_DWORD *)(v1 + 2660) = 1095761920;
        public float UnknownA68;     // offset: 2664, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 2664) = 1065353216;
        public float UnknownA6C;     // offset: 2668, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(v1 + 2668) = 1077936128;
        public float UnknownA70;     // offset: 2672, sz: 4, origin: 1101004800, parsed: 20        // line:   *(_DWORD *)(v1 + 2672) = 1101004800;
        public float UnknownA74;     // offset: 2676, sz: 4, origin: 1140457472, parsed: 500        // line:   *(_DWORD *)(v1 + 2676) = 1140457472;
        public float UnknownA78;     // offset: 2680, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 2680) = 1092616192;
        public float UnknownA7C;     // offset: 2684, sz: 4, origin: 1120403456, parsed: 100        // line:   *(_DWORD *)(v1 + 2684) = 1120403456;
        public float UnknownA80;     // offset: 2688, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 2688) = 1065353216;
        public float UnknownA84;     // offset: 2692, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 2692) = 1065353216;
        public float UnknownA88;     // offset: 2696, sz: 4, origin: 1101004800, parsed: 20        // line:   *(_DWORD *)(v1 + 2696) = 1101004800;
        public float UnknownA8C;     // offset: 2700, sz: 4, origin: 1140457472, parsed: 500        // line:   *(_DWORD *)(v1 + 2700) = 1140457472;
        public float UnknownA90;     // offset: 2704, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 2704) = 1092616192;
        public float UnknownA94;     // offset: 2708, sz: 4, origin: 1120403456, parsed: 100        // line:   *(_DWORD *)(v1 + 2708) = 1120403456;
        public float UnknownA98;     // offset: 2712, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 2712) = 1065353216;
        public float UnknownA9C;     // offset: 2716, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 2716) = 1065353216;
        // line: //*(_QWORD *)(v1 + 2720) = 0i64;
        // line: //*(_QWORD *)(v1 + 2728) = 0i64;
        [NMS(Size = 3)]
        public string UnknownAA0;     // offset: 2720, sz: 3, origin:  "RUN"        // line:   strncpy((char *)(v1 + 2720), "RUN", 3ui64);
        // line:   *(_BYTE *)(v1 + 2723) = 0;

        // missing 13 bytes at offset 2720
        // could be a subroutine, padding or something that the parser skipped
        [NMS(Size = 0xD, Ignore = true)]
        public byte[] PaddingAA3;        // offset: 2723, sz: 13, comment: auto padding 

        public bool UnknownAB0;     // offset: 2736, sz: 1, origin: 0, parsed: 0        // line:   *(_BYTE *)(v1 + 2736) = 0;

        // missing 3 bytes at offset 2736
        // does 2736 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] PaddingAB1;        // offset: 2737, sz: 3, comment: auto padding 

        public float UnknownAB4;     // offset: 2740, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 2740) = 1065353216;
        public float UnknownAB8;     // offset: 2744, sz: 4, origin: 1135869952, parsed: 360        // line:   *(_DWORD *)(v1 + 2744) = 1135869952;
        public float UnknownABC;     // offset: 2748, sz: 4, origin: 0x40000000i64, parsed: 2, comment: two packed floats in a QWORD?(1)
        public float UnknownAC0;     // offset: 2752, sz: 4, origin: 0x40000000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 2748) = 0x40000000i64;
        public float UnknownAC4;     // offset: 2756, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 2756) = 1065353216;
        public float UnknownAC8;     // offset: 2760, sz: 4, origin: -1082130432, parsed: -1        // line:   *(_DWORD *)(v1 + 2760) = -1082130432;
        public float UnknownACC;     // offset: 2764, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 2764) = 0;
        public float UnknownAD0;     // offset: 2768, sz: 4, origin: 1063893598, parsed: 0.913        // line:   *(_DWORD *)(v1 + 2768) = 1063893598;
        public float UnknownAD4;     // offset: 2772, sz: 4, origin: 1063541277, parsed: 0.892        // line:   *(_DWORD *)(v1 + 2772) = 1063541277;
        public float UnknownAD8;     // offset: 2776, sz: 4, origin: 1060974363, parsed: 0.739        // line:   *(_DWORD *)(v1 + 2776) = 1060974363;
        public float UnknownADC;     // offset: 2780, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 2780) = 1065353216;
        public float UnknownAE0;     // offset: 2784, sz: 4, origin: 1113325568, parsed: 55        // line:   *(_DWORD *)(v1 + 2784) = 1113325568;
        public float UnknownAE4;     // offset: 2788, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 2788) = 1092616192;
        public float UnknownAE8;     // offset: 2792, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 2792) = 0x40000000;
        public float UnknownAEC;     // offset: 2796, sz: 4, origin: 1113325568, parsed: 55        // line:   *(_DWORD *)(v1 + 2796) = 1113325568;
        public float UnknownAF0;     // offset: 2800, sz: 4, origin: 1097859072, parsed: 15        // line:   *(_DWORD *)(v1 + 2800) = 1097859072;
        public float UnknownAF4;     // offset: 2804, sz: 4, origin: 1101004800, parsed: 20        // line:   *(_DWORD *)(v1 + 2804) = 1101004800;
        public float UnknownAF8;     // offset: 2808, sz: 4, origin: 1140457472, parsed: 500        // line:   *(_DWORD *)(v1 + 2808) = 1140457472;
        public float UnknownAFC;     // offset: 2812, sz: 4, origin: 1090519040, parsed: 8        // line:   *(_DWORD *)(v1 + 2812) = 1090519040;
        public float UnknownB00;     // offset: 2816, sz: 4, origin: 1082130432, parsed: 4        // line:   *(_DWORD *)(v1 + 2816) = 1082130432;
        public float UnknownB04;     // offset: 2820, sz: 4, origin: 1112014848, parsed: 50        // line:   *(_DWORD *)(v1 + 2820) = 1112014848;
        public float UnknownB08;     // offset: 2824, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 2824) = 0x40000000;
        public NMSString0x80 UnknownB0C;     // offset: 2828, sz: 128, origin:  "MODELS/PLANETS/BIOMES/COMMON/BUILDINGS/DISTRESSSIGNAL/DISTRESSSCENE.DAE"        // line:   result = strncpy((char *)(v1 + 2828), "MODELS/PLANETS/BIOMES/COMMON/BUILDINGS/DISTRESSSIGNAL/DISTRESSSCENE.DAE", 0x80ui64);
        // line:   *(_BYTE *)(v1 + 2955) = 0;
        public float UnknownB8C;     // offset: 2956, sz: 4, origin: 1031127695, parsed: 0.06        // line:   *(_DWORD *)(v1 + 2956) = 1031127695;
        public float UnknownB90;     // offset: 2960, sz: 4, origin: 1025758986, parsed: 0.04        // line:   *(_DWORD *)(v1 + 2960) = 1025758986;
        public float UnknownB94;     // offset: 2964, sz: 4, origin: 1028443341, parsed: 0.05        // line:   *(_DWORD *)(v1 + 2964) = 1028443341;
        public float UnknownB98;     // offset: 2968, sz: 4, origin: 1022739087, parsed: 0.03        // line:   *(_DWORD *)(v1 + 2968) = 1022739087;
        public float UnknownB9C;     // offset: 2972, sz: 4, origin: 1103626240, parsed: 25        // line:   *(_DWORD *)(v1 + 2972) = 1103626240;
        public float UnknownBA0;     // offset: 2976, sz: 4, origin: 1090519040, parsed: 8        // line:   *(_DWORD *)(v1 + 2976) = 1090519040;
        public float UnknownBA4;     // offset: 2980, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(v1 + 2980) = 1114636288;
        public float UnknownBA8;     // offset: 2984, sz: 4, origin: 1084227584, parsed: 5        // line:   *(_DWORD *)(v1 + 2984) = 1084227584;
        public float UnknownBAC;     // offset: 2988, sz: 4, origin: 1148846080, parsed: 1000        // line:   *(_DWORD *)(v1 + 2988) = 1148846080;
        public int UnknownBB0;     // offset: 2992, sz: 4, origin: 3, parsed: 3        // line:   *(_DWORD *)(v1 + 2992) = 3;
        public float UnknownBB4;     // offset: 2996, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 2996) = 0x40000000;
        public float UnknownBB8;     // offset: 3000, sz: 4, origin: 1167867904, parsed: 5000        // line:   *(_DWORD *)(v1 + 3000) = 1167867904;
        public int UnknownBBC;     // offset: 3004, sz: 4, origin: 3, parsed: 3        // line:   *(_DWORD *)(v1 + 3004) = 3;
        public float UnknownBC0;     // offset: 3008, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 3008) = 0x40000000;
        // line:   return result;
        // line: }

        [NMS(Size = 0x8, Ignore = true)]
        public byte[] PaddingBC4;        // offset: 3012, sz: 8, comment: manual padding to fit size
    }
}
