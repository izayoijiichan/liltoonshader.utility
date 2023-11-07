// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilAudioLink
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon AudioLink Interface
    /// </summary>
    public interface ILilAudioLink
    {
        /// <summary>Use Audio Link</summary>
        //[DefaultValue(false)]
        bool UseAudioLink { get; set; }

        /// <summary>Audio Link Default Value</summary>
        /// <remarks>Strength|Blink Strength|Blink Speed|Blink Threshold</remarks>
        //[DefaultValue(0.0,0.0,2.0,0.75)]
        Vector4 AudioLinkDefaultValue { get; set; }

        /// <summary>Audio Link UV Mode</summary>
        //[DefaultValue(LilAudioLinkUVMode.Rim)]
        LilAudioLinkUVMode AudioLinkUVMode { get; set; }

        /// <summary>Audio Link UV Parameters</summary>
        /// <remarks>Scale|Offset|Angle|Band</remarks>
        //[DefaultValue(0.25,0,0,0.125)]
        Vector4 AudioLinkUVParams { get; set; }

        /// <summary>Audio Link Start Position</summary>
        //[DefaultValue(0.0,0.0,0.0,0.0)]
        Vector4 AudioLinkStart { get; set; }

        /// <summary>Audio Link Mask</summary>
        Texture2D? AudioLinkMask { get; set; }

        /// <summary>Audio Link 2 Main 2nd</summary>
        //[DefaultValue(false)]
        bool AudioLink2Main2nd { get; set; }

        /// <summary>Audio Link 2 Main 3rd</summary>
        //[DefaultValue(false)]
        bool AudioLink2Main3rd { get; set; }

        /// <summary>Audio Link 2 Emission</summary>
        //[DefaultValue(false)]
        bool AudioLink2Emission { get; set; }

        /// <summary>Audio Link 2 Emission Gradation</summary>
        //[DefaultValue(false)]
        bool AudioLink2EmissionGrad { get; set; }

        /// <summary>Audio Link 2 Emission 2nd</summary>
        //[DefaultValue(false)]
        bool AudioLink2Emission2nd { get; set; }

        /// <summary>Audio Link 2 Emission 2nd Gradation</summary>
        //[DefaultValue(false)]
        bool AudioLink2Emission2ndGrad { get; set; }

        /// <summary>Audio Link 2 Vertex</summary>
        //[DefaultValue(false)]
        bool AudioLink2Vertex { get; set; }

        /// <summary>Audio Link Vertex UV Mode</summary>
        //[DefaultValue(LilAudioLinkVertexUVMode.Position)]
        LilAudioLinkVertexUVMode AudioLinkVertexUVMode { get; set; }

        /// <summary>Audio Link Vertex UV Parameters</summary>
        /// <remarks>Scale|Offset|Angle|Band</remarks>
        //[DefaultValue(0.25,0,0,0.125)]
        Vector4 AudioLinkVertexUVParams { get; set; }

        /// <summary>Audio Link Vertex Start Position</summary>
        //[DefaultValue(0.0,0.0,0.0,0.0)]
        Vector4 AudioLinkVertexStart { get; set; }

        /// <summary>Audio Link Vertex Strength</summary>
        /// <remarks>Moving Vector|Normal Strength</remarks>
        //[DefaultValue(0.0,0.0,0.0,1.0)]
        Vector4 AudioLinkVertexStrength { get; set; }

        /// <summary>Audio Link as Local</summary>
        //[DefaultValue(false)]
        bool AudioLinkAsLocal { get; set; }

        /// <summary>Audio Link Local Map</summary>
        Texture2D? AudioLinkLocalMap { get; set; }

        /// <summary>Audio Link Local Map Parameters</summary>
        /// <remarks>BPM|Notes|Offset</remarks>
        //[DefaultValue(120,1,0,0)]
        Vector4 AudioLinkLocalMapParams { get; set; }
    }
}