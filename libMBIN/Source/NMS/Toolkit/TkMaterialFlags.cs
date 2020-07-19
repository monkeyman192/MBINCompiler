using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x4, GUID = 0x3FF1EC2ADB80C3AB, NameHash = 0x71610F70BA400437)]
    public class TkMaterialFlags : NMSTemplate
    {
        /// <summary>
        /// The material flags used by the ubershader. These can be cast to/from <see cref="MaterialFlagEnum"/>.
        /// These are mainly for outputting friendly names in the EXML files.
        /// All materials are assumed to be Ubershader materials for the sake of creating the EXML.
        /// Handling proper flag names for all shaders is infeasible and defaulting to the
        /// undecorated <see cref="MaterialFlagEnum"/> would be less intuitive.
        /// </summary>
        public enum UberFlagEnum {
            _F01_DIFFUSEMAP, _F02_SKINNED, _F03_NORMALMAP, _F04_, _F05_INVERT_ALPHA, _F06_BRIGHT_EDGE, _F07_UNLIT, _F08_, _F09_TRANSPARENT, _F10_NORECEIVESHADOW,
            _F11_ALPHACUTOUT, _F12_BATCHED_BILLBOARD, _F13_UVANIMATION, _F14_UVSCROLL, _F15_WIND, _F16_DIFFUSE2MAP, _F17_MULTIPLYDIFFUSE2MAP, _F18_UVTILES, _F19_BILLBOARD, _F20_PARALLAXMAP,
            _F21_VERTEXCOLOUR, _F22_TRANSPARENT_SCALAR, _F23_, _F24_AOMAP, _F25_ROUGHNESS_MASK, _F26_STRETCHY_PARTICLE, _F27_VBTANGENT, _F28_VBSKINNED, _F29_VBCOLOUR, _F30_REFRACTION_MAP,
            _F31_DISPLACEMENT, _F32_, _F33_SHELLS, _F34_GLOW, _F35_GLOW_MASK, _F36_DOUBLESIDED, _F37_, _F38_NO_DEFORM, _F39_METALLIC_MASK, _F40_SUBSURFACE_MASK,
            _F41_DETAIL_DIFFUSE, _F42_DETAIL_NORMAL, _F43_NORMAL_TILING, _F44_IMPOSTER, _F45_VERTEX_BLEND, _F46_BILLBOARD_AT, _F47_, _F48_WARPED_DIFFUSE_LIGHTING, _F49_DISABLE_AMBIENT, _F50_DISABLE_POSTPROCESS,
            _F51_DECAL_DIFFUSE, _F52_DECAL_NORMAL, _F53_COLOURISABLE, _F54_COLOURMASK, _F55_MULTITEXTURE, _F56_MATCH_GROUND, _F57_DETAIL_OVERLAY, _F58_USE_CENTRAL_NORMAL, _F59_SCREENSPACE_FADE, _F60_ACUTE_ANGLE_FADE,
            _F61_CLAMP_AMBIENT, _F62_DETAIL_ALPHACUTOUT, _F63_DISSOLVE, _F64_
        }

        // 04 -> no name


        /// <summary>
        /// Generic material flags enum. Any suffix can be used in EXML files and it will be stripped away.
        /// This conforms to the documented behaviour for the Horde3D engine. ( http://www.horde3d.org/docs/html/_pipeline.html Shaders/Code Section ):
        /// <code>
        /// The shader flags have a special naming convention: _F&lt;digit&gt;&lt;digit&gt;_&lt;name&gt;.
        /// The following would be a valid flag: _F06_MyFlag.
        /// The flag must have a number between 01 and 32 (note the leading zero).
        /// This number is exclusively used to identify the flag.
        /// The name is optional and just exists for convenience reasons in order to improve the code readability.
        /// </code>
        /// The only difference being that No Man's Sky handles flags values up to 64 instead of 32.
        /// </summary>
        public enum MaterialFlagEnum { _F01_, _F02_, _F03_, _F04_, _F05_, _F06_, _F07_, _F08_, _F09_, _F10_, _F11_, _F12_, _F13_, _F14_, _F15_, _F16_, _F17_, _F18_, _F19_, _F20_, _F21_, _F22_, _F23_, _F24_, _F25_, _F26_, _F27_, _F28_, _F29_, _F30_, _F31_, _F32_, _F33_, _F34_, _F35_, _F36_, _F37_, _F38_, _F39_, _F40_, _F41_, _F42_, _F43_, _F44_, _F45_, _F46_, _F47_, _F48_, _F49_, _F50_, _F51_, _F52_, _F53_, _F54_, _F55_, _F56_, _F57_, _F58_, _F59_, _F60_, _F61_, _F62_, _F63_, _F64_ }

        public MaterialFlagEnum MaterialFlag;
    }

}