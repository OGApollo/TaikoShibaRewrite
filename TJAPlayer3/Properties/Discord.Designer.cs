﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TJAPlayer3.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Discord {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Discord() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TJAPlayer3.Properties.Discord", typeof(Discord).Assembly);
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
        ///   Looks up a localized string similar to AI.
        /// </summary>
        internal static string Info_IsAuto {
            get {
                return ResourceManager.GetString("Info_IsAuto", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Currently playing.
        /// </summary>
        internal static string Stage_InGame {
            get {
                return ResourceManager.GetString("Stage_InGame", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Watching the results....
        /// </summary>
        internal static string Stage_Result {
            get {
                return ResourceManager.GetString("Stage_Result", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuring the game....
        /// </summary>
        internal static string Stage_Settings {
            get {
                return ResourceManager.GetString("Stage_Settings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Selecting a song....
        /// </summary>
        internal static string Stage_SongSelect {
            get {
                return ResourceManager.GetString("Stage_SongSelect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Just started playing.
        /// </summary>
        internal static string Stage_StartUp {
            get {
                return ResourceManager.GetString("Stage_StartUp", resourceCulture);
            }
        }
    }
}