﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sage300Utilities {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Sage300Utilities.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Application.
        /// </summary>
        internal static string Msg_Application {
            get {
                return ResourceManager.GetString("Msg_Application", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifying this flag indicates that you wish rebuild the \src\wizards\templates\Web\ folder based on sources located elsewhere. If set to false or not specified, the templates folders will not be updated at all..
        /// </summary>
        internal static string Msg_CommandLineParameter_EnableTemplateUpdates {
            get {
                return ResourceManager.GetString("Msg_CommandLineParameter_EnableTemplateUpdates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifying this flag indicates that you wish to view the help for this application..
        /// </summary>
        internal static string Msg_CommandLineParameter_Help {
            get {
                return ResourceManager.GetString("Msg_CommandLineParameter_Help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifying this flag indicates that you wish to run the PreBuild process during the Visual Studio Pre-Build event..
        /// </summary>
        internal static string Msg_CommandLineParameter_PreBuild {
            get {
                return ResourceManager.GetString("Msg_CommandLineParameter_PreBuild", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifying this flag indicates that you wish to rebuild the Web.vstemplate file that lives in the \src\Wizards\Templates\Web\ folder based on the contents of this and it&apos;s sub-folders..
        /// </summary>
        internal static string Msg_CommandLineParameter_RebuildWebDotVstemplateFile {
            get {
                return ResourceManager.GetString("Msg_CommandLineParameter_RebuildWebDotVstemplateFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This is the path to the root Web SDK folder..
        /// </summary>
        internal static string Msg_CommandLineParameter_SDKRoot {
            get {
                return ResourceManager.GetString("Msg_CommandLineParameter_SDKRoot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This is the path to the source web files..
        /// </summary>
        internal static string Msg_CommandLineParameter_WebSource {
            get {
                return ResourceManager.GetString("Msg_CommandLineParameter_WebSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Inner Exception.
        /// </summary>
        internal static string Msg_InnerException {
            get {
                return ResourceManager.GetString("Msg_InnerException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Program Name:          {0}
        ///Version:               {1}
        ///Build Date:            {2}
        ///
        ///Copyright:             (c) 1994-{6} The Sage Group plc or its licensors.  
        ///                       All rights reserved.
        ///License:               The MIT Licence (MIT)
        ///
        ///Required 3rd party
        ///programs/components:   {3}
        ///
        ///
        ///Required Parameter(s):
        ///
        ///{4}
        ///
        ///Optional Parameter(s):
        ///
        ///{5}.
        /// </summary>
        internal static string Msg_ProgramUsageMessage {
            get {
                return ResourceManager.GetString("Msg_ProgramUsageMessage", resourceCulture);
            }
        }
    }
}
