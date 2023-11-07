// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilLiteOutline
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Lite Outline Interface
    /// </summary>
    public interface ILilLiteOutline
    {
        /// <summary>Outline Color</summary>
        //[DefaultValue(0.8,0.85,0.9,1)]
        Color OutlineColor { get; set; }

        /// <summary>Outline Texture</summary>
        Texture2D? OutlineTex { get; set; }

        /// <summary>Outline Texture Scroll Rotate</summary>
        /// <remarks>Angle|UV Animation|Scroll|Rotate</remarks>
        //[DefaultValue(0,0,0,0)]
        Vector4 OutlineTex_ScrollRotate { get; set; }

        /// <summary>Outline Width</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.05f)]
        float OutlineWidth { get; set; }

        /// <summary>Outline Width Mask</summary>
        Texture2D? OutlineWidthMask { get; set; }

        /// <summary>Outline Fix Width</summary>
        //[DefaultValue(1)]
        int OutlineFixWidth { get; set; }

        /// <summary>Outline Vertex R2 Width</summary>
        LilVertexColorMode OutlineVertexR2Width { get; set; }

        /// <summary>Outline Enable Lighting</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float OutlineEnableLighting { get; set; }
    }
}