namespace MBINCompiler.Models.Structs
{
    public class GcGalaxyGlobals_old: NMSTemplate
    {
        // generated with MBINRawTemplateParser

        public float Unknown0;     // offset: 0, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)a1 = 1065353216;
        public float Unknown4;     // offset: 4, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 4) = 1065353216;
        public float Unknown8;     // offset: 8, sz: 4, origin: 1120927744, parsed: 104        // line:   *(_DWORD *)(a1 + 8) = 1120927744;
        public float UnknownC;     // offset: 12, sz: 4, origin: 1119223808, parsed: 91        // line:   *(_DWORD *)(a1 + 12) = 1119223808;
        public float Unknown10;     // offset: 16, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(a1 + 16) = 1092616192;
        public float Unknown14;     // offset: 20, sz: 4, origin: 1101004800, parsed: 20        // line:   *(_DWORD *)(a1 + 20) = 1101004800;
        public float Unknown18;     // offset: 24, sz: 4, origin: 1086324736, parsed: 6        // line:   *(_DWORD *)(a1 + 24) = 1086324736;
        public float Unknown1C;     // offset: 28, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(a1 + 28) = 1092616192;
        public float Unknown20;     // offset: 32, sz: 4, origin: 1096810496, parsed: 14        // line:   *(_DWORD *)(a1 + 32) = 1096810496;
        public float Unknown24;     // offset: 36, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(a1 + 36) = 1077936128;
        public float Unknown28;     // offset: 40, sz: 4, origin: 1074790400, parsed: 2.25        // line:   *(_DWORD *)(a1 + 40) = 1074790400;
        public float Unknown2C;     // offset: 44, sz: 4, origin: 1065353216i64, parsed: 1, comment: two packed floats in a QWORD?(1)
        public float Unknown30;     // offset: 48, sz: 4, origin: 1065353216i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(a1 + 44) = 1065353216i64;
        public float Unknown34;     // offset: 52, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(a1 + 52) = 0;

        // missing 8 bytes at offset 52
        // could be a subroutine, padding or something that the parser skipped
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] Padding38;        // offset: 56, sz: 8, comment: auto padding 

        public GcGalaxyMarkerSettings Template40;     // offset: 64, sz: 112, origin: sub_140141660(v1 + 64);, comment: call sub        // line:   sub_140141660(v1 + 64);
        public GcGalaxyMarkerSettings TemplateB0;     // offset: 176, sz: 112, origin: sub_140141660(v2 + 176); // cGcGalaxyMarkerSettings, comment: call sub        // line:   sub_140141660(v2 + 176); // cGcGalaxyMarkerSettings
        public GcGalaxyMarkerSettings Template120;     // offset: 288, sz: 112, origin: sub_140141660(v3 + 288);, comment: call sub        // line:   sub_140141660(v3 + 298);
        public GcGalaxyMarkerSettings Template190;     // offset: 400, sz: 112, origin: sub_140141660(v4 + 400);, comment: call sub        // line:   sub_140141660(v4 + 400);
        public GcGalaxyMarkerSettings Template200;     // offset: 512, sz: 112, origin: sub_140141660(v5 + 512);, comment: call sub        // line:   sub_140141660(v5 + 512);
        public GcGalaxyMarkerSettings Template270;     // offset: 624, sz: 112, origin: sub_140141660(v6 + 624);, comment: call sub        // line:   sub_140141660(v6 + 624);
        public float Unknown2E0;     // offset: 736, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v7 + 736) = 1056964608;
        public float Unknown2E4;     // offset: 740, sz: 4, origin: 1080033280, parsed: 3.5        // line:   *(_DWORD *)(v7 + 740) = 1080033280;
        public float Unknown2E8;     // offset: 744, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(v7 + 744) = 1077936128;
        public float Unknown2EC;     // offset: 748, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v7 + 748) = 0x40000000;
        public float Unknown2F0;     // offset: 752, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v7 + 752) = 0x40000000;
        public float Unknown2F4;     // offset: 756, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 756) = 1065353216;
        public float Unknown2F8;     // offset: 760, sz: 4, origin: 1073951539i64, parsed: 2.05, comment: two packed floats in a QWORD?(1)
        public float Unknown2FC;     // offset: 764, sz: 4, origin: 1073951539i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v7 + 760) = 1073951539i64;
        public float Unknown300;     // offset: 768, sz: 4, origin: 1117388800, parsed: 77        // line:   *(_DWORD *)(v7 + 768) = 1117388800;
        public float Unknown304;     // offset: 772, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(v7 + 772) = 1077936128;
        public float Unknown308;     // offset: 776, sz: 4, origin: 1109393408, parsed: 40        // line:   *(_DWORD *)(v7 + 776) = 1109393408;
        public float Unknown30C;     // offset: 780, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(v7 + 780) = 1036831949;
        public float Unknown310;     // offset: 784, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(v7 + 784) = 1036831949;
        public float Unknown314;     // offset: 788, sz: 4, origin: 1135542272, parsed: 350        // line:   *(_DWORD *)(v7 + 788) = 1135542272;
        public float Unknown318;     // offset: 792, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v7 + 792) = 1056964608;
        public float Unknown31C;     // offset: 796, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 796) = 1065353216;
        public float Unknown320;     // offset: 800, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(v7 + 800) = 1077936128;
        public float Unknown324;     // offset: 804, sz: 4, origin: 1200142336, parsed: 70000        // line:   *(_DWORD *)(v7 + 804) = 1200142336;
        public float Unknown328;     // offset: 808, sz: 4, origin: 1082130432, parsed: 4        // line:   *(_DWORD *)(v7 + 808) = 1082130432;
        public float Unknown32C;     // offset: 812, sz: 4, origin: 1133903872, parsed: 300        // line:   *(_DWORD *)(v7 + 812) = 1133903872;
        public float Unknown330;     // offset: 816, sz: 4, origin: 1109393408, parsed: 40        // line:   *(_DWORD *)(v7 + 816) = 1109393408;
        public int Unknown334;     // offset: 820, sz: 4, origin: 10, parsed: 10        // line:   *(_DWORD *)(v7 + 820) = 10;
        public float Unknown338;     // offset: 824, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(v7 + 824) = 1036831949;
        public float Unknown33C;     // offset: 828, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v7 + 828) = 1045220557;
        public float Unknown340;     // offset: 832, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v7 + 832) = 1056964608;
        public float Unknown344;     // offset: 836, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v7 + 836) = 1056964608;
        public float Unknown348;     // offset: 840, sz: 4, origin: 1112014848, parsed: 50        // line:   *(_DWORD *)(v7 + 840) = 1112014848;
        public float Unknown34C;     // offset: 844, sz: 4, origin: 1069547520, parsed: 1.5        // line:   *(_DWORD *)(v7 + 844) = 1069547520;
        public float Unknown350;     // offset: 848, sz: 4, origin: 1075838976, parsed: 2.5        // line:   *(_DWORD *)(v7 + 848) = 1075838976;
        public float Unknown354;     // offset: 852, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v7 + 852) = 1092616192;
        public float Unknown358;     // offset: 856, sz: 4, origin: 1050253722, parsed: 0.3        // line:   *(_DWORD *)(v7 + 856) = 1050253722;
        public float Unknown35C;     // offset: 860, sz: 4, origin: 1051260355i64, parsed: 0.33, comment: two packed floats in a QWORD?(1)
        public int Unknown360; // code treats 360/368 as two seperate ints
        public int Unknown364;

        [NMS(Size = 0x8, Ignore = true)]
        public byte[] Padding368;

        public float Unknown370;     // offset: 880, sz: 4, origin: 1053609165, parsed: 0.4        // line:   *(_DWORD *)(v7 + 880) = 1053609165;
        public float Unknown374;     // offset: 884, sz: 4, origin: 1050253722, parsed: 0.3        // line:   *(_DWORD *)(v7 + 884) = 1050253722;
        public float Unknown378;     // offset: 888, sz: 4, origin: 1061997773, parsed: 0.8        // line:   *(_DWORD *)(v7 + 888) = 1061997773;
        public float Unknown37C;     // offset: 892, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 892) = 1065353216;
        public float Unknown380;     // offset: 896, sz: 4, origin: 1048576000, parsed: 0.25        // line:   *(_DWORD *)(v7 + 896) = 1048576000;
        public float Unknown384;     // offset: 900, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v7 + 900) = 1056964608;
        public float Unknown388;     // offset: 904, sz: 4, origin: 1063675494, parsed: 0.9        // line:   *(_DWORD *)(v7 + 904) = 1063675494;
        public float Unknown38C;     // offset: 908, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 908) = 1065353216;
        public float Unknown390;     // offset: 912, sz: 4, origin: 1050253722, parsed: 0.3        // line:   *(_DWORD *)(v7 + 912) = 1050253722;
        public float Unknown394;     // offset: 916, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(v7 + 916) = 1036831949;
        public float Unknown398;     // offset: 920, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v7 + 920) = 1056964608;

        // missing 4 bytes at offset 920
        // could be a subroutine, padding or something that the parser skipped
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding39C;        // offset: 924, sz: 4, comment: auto padding 

        public float Unknown3A0;     // offset: 928, sz: 4, origin: 1053609165, parsed: 0.4        // line:   *(_DWORD *)(v7 + 928) = 1053609165;
        public float Unknown3A4;     // offset: 932, sz: 4, origin: 1050253722, parsed: 0.3        // line:   *(_DWORD *)(v7 + 932) = 1050253722;
        public float Unknown3A8;     // offset: 936, sz: 4, origin: 1061997773, parsed: 0.8        // line:   *(_DWORD *)(v7 + 936) = 1061997773;
        public float Unknown3AC;     // offset: 940, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 940) = 1065353216;
        public float Unknown3B0;     // offset: 944, sz: 4, origin: 1048576000, parsed: 0.25        // line:   *(_DWORD *)(v7 + 944) = 1048576000;
        public float Unknown3B4;     // offset: 948, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v7 + 948) = 1056964608;
        public float Unknown3B8;     // offset: 952, sz: 4, origin: 1063675494, parsed: 0.9        // line:   *(_DWORD *)(v7 + 952) = 1063675494;
        public float Unknown3BC;     // offset: 956, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 956) = 1065353216;
        public float Unknown3C0;     // offset: 960, sz: 4, origin: 1050253722, parsed: 0.3        // line:   *(_DWORD *)(v7 + 960) = 1050253722;
        public float Unknown3C4;     // offset: 964, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(v7 + 964) = 1036831949;
        public float Unknown3C8;     // offset: 968, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v7 + 968) = 1056964608;

        // missing 4 bytes at offset 968
        // could be a subroutine, padding or something that the parser skipped
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding3CC;        // offset: 972, sz: 4, comment: auto padding 

        public float Unknown3D0;     // offset: 976, sz: 4, origin: 1064329806, parsed: 0.939        // line:   *(_DWORD *)(v7 + 976) = 1064329806;
        public float Unknown3D4;     // offset: 980, sz: 4, origin: 1058625552, parsed: 0.599        // line:   *(_DWORD *)(v7 + 980) = 1058625552;
        public float Unknown3D8;     // offset: 984, sz: 4, origin: 1030590824, parsed: 0.058        // line:   *(_DWORD *)(v7 + 984) = 1030590824;
        public float Unknown3DC;     // offset: 988, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 988) = 1065353216;
        public float Unknown3E0;     // offset: 992, sz: 4, origin: 1062719193, parsed: 0.843        // line:   *(_DWORD *)(v7 + 992) = 1062719193;
        public float Unknown3E4;     // offset: 996, sz: 4, origin: 1046764061, parsed: 0.223        // line:   *(_DWORD *)(v7 + 996) = 1046764061;
        public float Unknown3E8;     // offset: 1000, sz: 4, origin: 1057434370, parsed: 0.528        // line:   *(_DWORD *)(v7 + 1000) = 1057434370;
        public float Unknown3EC;     // offset: 1004, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1004) = 1065353216;
        public float Unknown3F0;     // offset: 1008, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v7 + 1008) = 1056964608;

        // missing 12 bytes at offset 1008
        // could be a subroutine, padding or something that the parser skipped
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding3F4;        // offset: 1012, sz: 12, comment: auto padding 

        public float Unknown400;     // offset: 1024, sz: 4, origin: 1058541666, parsed: 0.594        // line:   *(_DWORD *)(v7 + 1024) = 1058541666;
        public float Unknown404;     // offset: 1028, sz: 4, origin: 1060924031, parsed: 0.736        // line:   *(_DWORD *)(v7 + 1028) = 1060924031;
        public float Unknown408;     // offset: 1032, sz: 4, origin: 1061746115, parsed: 0.785        // line:   *(_DWORD *)(v7 + 1032) = 1061746115;
        public float Unknown40C;     // offset: 1036, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1036) = 1065353216;
        public float Unknown410;     // offset: 1040, sz: 4, origin: 1133903872, parsed: 300        // line:   *(_DWORD *)(v7 + 1040) = 1133903872;
        public float Unknown414;     // offset: 1044, sz: 4, origin: 1176256512, parsed: 10000        // line:   *(_DWORD *)(v7 + 1044) = 1176256512;

        // missing 8 bytes at offset 1044
        // could be a subroutine, padding or something that the parser skipped
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] Padding418;        // offset: 1048, sz: 8, comment: auto padding 

        public float Unknown420;     // offset: 1056, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1056) = 1065353216;
        public float Unknown424;     // offset: 1060, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1060) = 1065353216;
        public float Unknown428;     // offset: 1064, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1064) = 1065353216;
        public float Unknown42C;     // offset: 1068, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1068) = 1065353216;
        public float Unknown430;     // offset: 1072, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1072) = 1065353216;
        public float Unknown434;     // offset: 1076, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1076) = 1065353216;
        public float Unknown438;     // offset: 1080, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1080) = 1065353216;
        public float Unknown43C;     // offset: 1084, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1084) = 1065353216;
        public float Unknown440;     // offset: 1088, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1088) = 1065353216;
        public float Unknown444;     // offset: 1092, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1092) = 1065353216;
        public float Unknown448;     // offset: 1096, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1096) = 1065353216;
        public float Unknown44C;     // offset: 1100, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1100) = 1065353216;
        public float Unknown450;     // offset: 1104, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1104) = 1065353216;
        public float Unknown454;     // offset: 1108, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1108) = 1065353216;
        public float Unknown458;     // offset: 1112, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1112) = 1065353216;
        public float Unknown45C;     // offset: 1116, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1116) = 1065353216;
        public float Unknown460;     // offset: 1120, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1120) = 1065353216;
        public float Unknown464;     // offset: 1124, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1124) = 1065353216;
        public float Unknown468;     // offset: 1128, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1128) = 1065353216;
        public float Unknown46C;     // offset: 1132, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1132) = 1065353216;
        public float Unknown470;     // offset: 1136, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1136) = 1065353216;
        public float Unknown474;     // offset: 1140, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1140) = 1065353216;
        public float Unknown478;     // offset: 1144, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1144) = 1065353216;
        public float Unknown47C;     // offset: 1148, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1148) = 1065353216;
        public float Unknown480;     // offset: 1152, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1152) = 1065353216;
        public float Unknown484;     // offset: 1156, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1156) = 1065353216;
        public float Unknown488;     // offset: 1160, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1160) = 1065353216;
        public float Unknown48C;     // offset: 1164, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1164) = 1065353216;
        public float Unknown490;     // offset: 1168, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1168) = 1065353216;
        public float Unknown494;     // offset: 1172, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1172) = 1065353216;
        public float Unknown498;     // offset: 1176, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1176) = 1065353216;
        public float Unknown49C;     // offset: 1180, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1180) = 1065353216;
        public float Unknown4A0;     // offset: 1184, sz: 4, origin: 1120403456, parsed: 100        // line:   *(_DWORD *)(v7 + 1184) = 1120403456;
        public float Unknown4A4;     // offset: 1188, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(v7 + 1188) = 1077936128;
        public float Unknown4A8;     // offset: 1192, sz: 4, origin: 1084227584, parsed: 5        // line:   *(_DWORD *)(v7 + 1192) = 1084227584;
        public float Unknown4AC;     // offset: 1196, sz: 4, origin: 1082130432, parsed: 4        // line:   *(_DWORD *)(v7 + 1196) = 1082130432;
        public float Unknown4B0;     // offset: 1200, sz: 4, origin: 1063675494, parsed: 0.9        // line:   *(_DWORD *)(v7 + 1200) = 1063675494;
        public float Unknown4B4;     // offset: 1204, sz: 4, origin: 1101004800, parsed: 20        // line:   *(_DWORD *)(v7 + 1204) = 1101004800;
        public float Unknown4B8;     // offset: 1208, sz: 4, origin: 1128792064, parsed: 200        // line:   *(_DWORD *)(v7 + 1208) = 1128792064;
        public float Unknown4BC;     // offset: 1212, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1212) = 1065353216;
        public float Unknown4C0;     // offset: 1216, sz: 4, origin: 1076887552, parsed: 2.75        // line:   *(_DWORD *)(v7 + 1216) = 1076887552;
        public float Unknown4C4;     // offset: 1220, sz: 4, origin: 1106247680, parsed: 30        // line:   *(_DWORD *)(v7 + 1220) = 1106247680;
        public float Unknown4C8;     // offset: 1224, sz: 4, origin: 1123024896, parsed: 120        // line:   *(_DWORD *)(v7 + 1224) = 1123024896;
        public float Unknown4CC;     // offset: 1228, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v7 + 1228) = 0x40000000;
        public float Unknown4D0;     // offset: 1232, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1232) = 1065353216;
        public float Unknown4D4;     // offset: 1236, sz: 4, origin: 1061997773, parsed: 0.8        // line:   *(_DWORD *)(v7 + 1236) = 1061997773;
        public float Unknown4D8;     // offset: 1240, sz: 4, origin: -1085485875, parsed: -0.8        // line:   *(_DWORD *)(v7 + 1240) = -1085485875;
        public float Unknown4DC;     // offset: 1244, sz: 4, origin: 1074580685, parsed: 2.2        // line:   *(_DWORD *)(v7 + 1244) = 1074580685;
        public float Unknown4E0;     // offset: 1248, sz: 4, origin: 1053609165, parsed: 0.4        // line:   *(_DWORD *)(v7 + 1248) = 1053609165;
        public float Unknown4E4;     // offset: 1252, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(v7 + 1252) = 1077936128;
        public float Unknown4E8;     // offset: 1256, sz: 4, origin: 1050253722, parsed: 0.3        // line:   *(_DWORD *)(v7 + 1256) = 1050253722;
        public float Unknown4EC;     // offset: 1260, sz: 4, origin: 1028443341, parsed: 0.05        // line:   *(_DWORD *)(v7 + 1260) = 1028443341;
        public float Unknown4F0;     // offset: 1264, sz: 4, origin: 1082130432, parsed: 4        // line:   *(_DWORD *)(v7 + 1264) = 1082130432;
        public float Unknown4F4;     // offset: 1268, sz: 4, origin: 1065353216i64, parsed: 1, comment: two packed floats in a QWORD?(1)
        public int Unknown4F8;
        public int Unknown4FC;
        public int Unknown500;
        public int Unknown504;
        public int Unknown508;
        public int Unknown50C;
        public int Unknown510;
        public int Unknown514;
        public int Unknown518;
        public int Unknown51C;
        public int Unknown520;
        public int Unknown524;
        public int Unknown528;
        public int Unknown52C;
        public float Unknown530;
        public float Unknown534;     // offset: 1332, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(v7 + 1332) = 1036831949;
        public float Unknown538;     // offset: 1336, sz: 4, origin: 1120403456, parsed: 100        // line:   *(_DWORD *)(v7 + 1336) = 1120403456;
        public float Unknown53C;     // offset: 1340, sz: 4, origin: 1061997773, parsed: 0.8        // line:   *(_DWORD *)(v7 + 1340) = 1061997773;
        public float Unknown540;     // offset: 1344, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v7 + 1344) = 1065353216;
        public float Unknown544;     // offset: 1348, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v7 + 1348) = 1056964608;
        public float Unknown548;     // offset: 1352, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v7 + 1352) = 1056964608;
        public float Unknown54C;     // offset: 1356, sz: 4, origin: 1041697341, parsed: 0.1475        // line:   *(_DWORD *)(v7 + 1356) = 1041697341;
        public GcGalaxyRenderSetupData Template550;     // offset: 1360, sz: 496, origin: sub_1401440F0(v7 + 1360);, comment: call sub        // line:   sub_1401440F0(v7 + 1360);
        public GcGalaxyGenerationSetupData Template740;     // offset: 1856, sz: 368, origin: sub_140146E20(v9 + 1856);, comment: call sub        // line:   sub_140146E20(v9 + 1856);
        public GcGalaxyRenderSetupData Template8B0;     // offset: 2224, sz: 496, origin: sub_1401440F0(v10 + 2224);, comment: call sub        // line:   sub_1401440F0(v10 + 2224);
        public GcGalaxyGenerationSetupData TemplateAA0;     // offset: 2720, sz: 368, origin: sub_140146E20(v11 + 2720);, comment: call sub        // line:   sub_140146E20(v11 + 2720);
    }
}
