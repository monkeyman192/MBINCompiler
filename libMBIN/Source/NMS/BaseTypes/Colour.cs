﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System;
using System.Drawing;

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
        /// <param name="A">Alpha component of the colour. Value can be anything between 0 and 1.</param>
        public Colour(int R, int G, int B, float A = 1f)
        {
            this.R = R / 255;
            this.G = G / 255;
            this.B = B / 255;
            this.A = A;
        }

        public Colour() { }

        /// <summary>
        /// Returns a formatted string for this Color.
        /// <br/>Output: RGBA (R, G, B, A)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"RGBA ({R}, {G}, {B}, {A})";
        }

        /// <summary>
        /// Implicitly creates System.Color from a NMS Colour.
        /// </summary>
        /// <param name="colour"></param>
        public static implicit operator Color(Colour colour)
        {
            int a = (int)(colour.A * 255);
            int r = (int)(colour.R * 255);
            int g = (int)(colour.G * 255);
            int b = (int)(colour.B * 255);
            return Color.FromArgb(a, r, g, b);
        }

        /// <summary>
        /// Implicitly creates a NMS Colour from a System.Color.
        /// </summary>
        /// <param name="systemColor"></param>
        public static implicit operator Colour(Color systemColor)
        {
            float a = systemColor.A / 255;
            float r = systemColor.R / 255;
            float g = systemColor.G / 255;
            float b = systemColor.B / 255;
            return new Colour(r, g, b, a);
        }
    }
}
