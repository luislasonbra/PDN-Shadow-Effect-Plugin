﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Seren.PaintDotNet.Effects.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Seren.PaintDotNet.Effects.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Icons_ShadowEffect_bmp {
            get {
                object obj = ResourceManager.GetObject("Icons.ShadowEffect.bmp", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Opacity.
        /// </summary>
        internal static string ShadowEffect_AlphaAmountLabel {
            get {
                return ResourceManager.GetString("ShadowEffect.AlphaAmountLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Gaussian Blur Radius.
        /// </summary>
        internal static string ShadowEffect_BlurAmountLabel {
            get {
                return ResourceManager.GetString("ShadowEffect.BlurAmountLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Diffusion Factor.
        /// </summary>
        internal static string ShadowEffect_DiffusionLabel {
            get {
                return ResourceManager.GetString("ShadowEffect.DiffusionLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Shadow.
        /// </summary>
        internal static string ShadowEffect_Name {
            get {
                return ResourceManager.GetString("ShadowEffect.Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Keep Original Image.
        /// </summary>
        internal static string ShadowEffect_OriginalImage {
            get {
                return ResourceManager.GetString("ShadowEffect.OriginalImage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ShadowEffect_sample {
            get {
                object obj = ResourceManager.GetObject("ShadowEffect.sample", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Angle of shadow (left to right).
        /// </summary>
        internal static string ShadowEffect_ShadowAngle {
            get {
                return ResourceManager.GetString("ShadowEffect.ShadowAngle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Angle of shadow depth (front to back).
        /// </summary>
        internal static string ShadowEffect_ShadowDepthAngle {
            get {
                return ResourceManager.GetString("ShadowEffect.ShadowDepthAngle", resourceCulture);
            }
        }
    }
}
