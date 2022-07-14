using libMBIN.Source.Common;
using System;

namespace libMBIN.NMS
{
    /// <summary>
    /// This class is a simple colour one. The values of each field must be between 0 and 1.
    /// To convert from the usual representation of a value between 0 and 255, you just need to divide the value
    /// by 255 to get the floating point representation used by the game.
    /// </summary>
    [NMS(Alignment = 0x10, Size = 0x10)]
    [NMSDescription(
        @"This class is a simple colour one. The values of each field must be between 0 and 1.
        To convert from the usual representation of a value between 0 and 255, you just need to divide the value
        by 255 to get the floating point representation used by the game."
    )]
    public class Colour : NMSTemplate
    {
        /// <summary>
        /// The Red component of the colour.
        /// </summary>
        [NMSDescription("The Red component of the colour")]
        public float R;

        /// <summary>
        /// The Green component of the colour.
        /// </summary>
        [NMSDescription("The Green component of the colour")]
        public float G;

        /// <summary>
        /// The Blue component of the colour.
        /// </summary>
        [NMSDescription("The Blue component of the colour")]
        public float B;

        /// <summary>
        /// The Alpha component of the colour.
        /// </summary>
        [NMSDescription("The Alpha component of the colour")]
        public float A;


        /// <summary>
        /// Creates a Color while providing it with float RGB values.
        /// <br/>Values must be between 0 - 1.
        /// </summary>
        /// <param name="R">Red component of the colour. Value can be anything between 0 and 1.</param>
        /// <param name="G">Green component of the colour. Value can be anything between 0 and 1.</param>
        /// <param name="B">Blue component of the colour. Value can be anything between 0 and 1.</param>
        /// <param name="A">Alpha component of the colour. Value can be anything between 0 and 1.</param>
        public Colour(float R, float G, float B, float A = 1f)
        {
            this.R = R;
            this.G = G;
            this.B = B;
            this.A = A;
        }

        /// <summary>
        /// Creates a Color while providing it with standard RGB values.
        /// <br/>Values must be whole numbers between 0 - 255.
        /// </summary>
        /// <param name="R">Red component of the colour. Value can be any whole number between 0 and 255.</param>
        /// <param name="G">Green component of the colour. Value can be any whole number between 0 and 255.</param>
        /// <param name="B">Blue component of the colour. Value can be any whole number between 0 and 255.</param>
        /// <param name="A">Alpha component of the colour. Value can be any whole number between 0 and 255.</param>
        public Colour(byte R, byte G, byte B, byte A = 255)
        {
            this.R = R / 255f;
            this.G = G / 255f;
            this.B = B / 255f;
            this.A = A / 255f;
        }

        public Colour() { }

        /// <summary>
        /// Returns a formatted string for this Color. Values will be printed in NMS-Style, between 0 and 1.
        /// <br/>Output: Colour [R: 0.58, G: 0.35, B: 0.80, A: 1]
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.ToString(true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FLOAT"></param>
        /// <param name="FORMAT"></param>
        /// <returns></returns>
        public string ToString(bool FLOAT, string FORMAT = "Colour [R: {0}, G: {1}, B: {2}, A: {3}]")
        {
            if (FLOAT) return string.Format(FORMAT, this.R, this.G, this.B, this.A);

            var color = this.ToSystemDrawingColor();
            return string.Format(FORMAT, color.R, color.G, color.B, color.A);
        }

        /// <summary>
        /// Creates a System.Drawing.Color from this Colour.
        /// </summary>
        /// <returns></returns>
        public System.Drawing.Color ToSystemDrawingColor()
        {
            int r = (int)MathHelper.Clamp(Math.Round((this.R * 255)), 0, 255);
            int g = (int)MathHelper.Clamp(Math.Round((this.G * 255)), 0, 255);
            int b = (int)MathHelper.Clamp(Math.Round((this.B * 255)), 0, 255);
            int a = (int)MathHelper.Clamp(Math.Round((this.A * 255)), 0, 255);
            return System.Drawing.Color.FromArgb(a, r, g, b);
        }

        /// <summary>
        /// Implicitly creates System.Color from a NMS Colour.
        /// </summary>
        /// <param name="colour"></param>
        public static implicit operator System.Drawing.Color(Colour colour)
        {
            return colour.ToSystemDrawingColor();
        }

        /// <summary>
        /// Implicitly creates a NMS Colour from a System.Color.
        /// </summary>
        /// <param name="systemColor"></param>
        public static implicit operator Colour(System.Drawing.Color systemColor)
        {
            return FromSystemDrawingColor(systemColor);
        }

        /// <summary>
        /// Creates a Colour from a System.Drawing.Color.
        /// </summary>
        /// <param name="systemColor"></param>
        /// <returns></returns>
        public static Colour FromSystemDrawingColor(System.Drawing.Color systemColor)
        {
            float a = systemColor.A / 255f;
            float r = systemColor.R / 255f;
            float g = systemColor.G / 255f;
            float b = systemColor.B / 255f;
            return new Colour(r, g, b, a);
        }
    }
}
