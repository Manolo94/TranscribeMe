﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TranscribeMe.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Lang {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Lang() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TranscribeMe.Resources.Lang", typeof(Lang).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to About TranscribeMe.
        /// </summary>
        public static string About {
            get {
                return ResourceManager.GetString("About", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Account.
        /// </summary>
        public static string Account {
            get {
                return ResourceManager.GetString("Account", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Audio to text.
        /// </summary>
        public static string AudioToText {
            get {
                return ResourceManager.GetString("AudioToText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Image to text.
        /// </summary>
        public static string ImageToText {
            get {
                return ResourceManager.GetString("ImageToText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your document is ready.
        /// </summary>
        public static string ToastMsg1 {
            get {
                return ResourceManager.GetString("ToastMsg1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Click on open.
        /// </summary>
        public static string ToastMsg2 {
            get {
                return ResourceManager.GetString("ToastMsg2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Translate document.
        /// </summary>
        public static string TranslateDocument {
            get {
                return ResourceManager.GetString("TranslateDocument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Video to text.
        /// </summary>
        public static string VideoToText {
            get {
                return ResourceManager.GetString("VideoToText", resourceCulture);
            }
        }
    }
}
