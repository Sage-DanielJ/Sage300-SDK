﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MergeISVProject {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MergeISVProject.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The post-build utility MergeISVProject could not compile the razor view(s). While the build was successful, the deployment was unsuccessful. Therefore, check view(s) for issue(s) (i.e. localization syntax)..
        /// </summary>
        internal static string Error_CouldNotCompileRazorViews {
            get {
                return ResourceManager.GetString("Error_CouldNotCompileRazorViews", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, the folder &apos;{0}&apos; could not be deleted. It appears as though the &apos;{0}&apos; folder is locked or in use. Please ensure that there are no command prompts or File Explorer instances referring to the &apos;{0}&apos; folder (or any of it&apos;s sub-folders)..
        /// </summary>
        internal static string Error_DeploymentFolderLockedOrInUse {
            get {
                return ResourceManager.GetString("Error_DeploymentFolderLockedOrInUse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}Error parsing &apos;{1}&apos;. No value was set..
        /// </summary>
        internal static string Error_ErrorParsingOptionNoValueWasSet {
            get {
                return ResourceManager.GetString("Error_ErrorParsingOptionNoValueWasSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}Error parsing &apos;{1}&apos;. The folder &apos;{2}&apos; does not exist..
        /// </summary>
        internal static string Error_ErrorParsingOptionTheFolderDoesNotExist {
            get {
                return ResourceManager.GetString("Error_ErrorParsingOptionTheFolderDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid build profile specified. &apos;Release&apos; mode must be used..
        /// </summary>
        internal static string Error_InvalidBuildProfile {
            get {
                return ResourceManager.GetString("Error_InvalidBuildProfile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid or missing command-line parameters.
        /// </summary>
        internal static string Error_InvalidCommandLineParameters {
            get {
                return ResourceManager.GetString("Error_InvalidCommandLineParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; was called with one or more invalid parameters..
        /// </summary>
        internal static string Error_MethodCalledWithInvalidParameter {
            get {
                return ResourceManager.GetString("Error_MethodCalledWithInvalidParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, the minification process appears to have failed..
        /// </summary>
        internal static string Error_MinificationFailed {
            get {
                return ResourceManager.GetString("Error_MinificationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sage 300 does not appear to be installed. This is a required application..
        /// </summary>
        internal static string Error_Sage300Missing {
            get {
                return ResourceManager.GetString("Error_Sage300Missing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The post-build utility MergeISVProject could not find the Online Web folder for the Web UIs. While the build was successful, the deployment was unsuccessful. Therefore, check view(s) for issue(s) (i.e. localization syntax)..
        /// </summary>
        internal static string Error_Sage300WebFolderMissing {
            get {
                return ResourceManager.GetString("Error_Sage300WebFolderMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find the program &apos;{0}&apos;. Path=&apos;[1]&apos;.
        /// </summary>
        internal static string Error_UnableToFindTheProgram {
            get {
                return ResourceManager.GetString("Error_UnableToFindTheProgram", resourceCulture);
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
        ///   Looks up a localized string similar to Set the target application type. (0 = Full Solution | 1 = Single Project).
        /// </summary>
        internal static string Msg_ApplicationModeOption {
            get {
                return ResourceManager.GetString("Msg_ApplicationModeOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The application has completed..
        /// </summary>
        internal static string Msg_ApplicationRunComplete {
            get {
                return ResourceManager.GetString("Msg_ApplicationRunComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument List:.
        /// </summary>
        internal static string Msg_ArgumentList {
            get {
                return ResourceManager.GetString("Msg_ArgumentList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Begin.
        /// </summary>
        internal static string Msg_Begin {
            get {
                return ResourceManager.GetString("Msg_Begin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Beginning minification process on directory &apos;{0}&apos;.
        /// </summary>
        internal static string Msg_BeginningMinificationProcessOnDirectory {
            get {
                return ResourceManager.GetString("Msg_BeginningMinificationProcessOnDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Checking for registry keys.
        /// </summary>
        internal static string Msg_CheckingForRegistryKeys {
            get {
                return ResourceManager.GetString("Msg_CheckingForRegistryKeys", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copying file.
        /// </summary>
        internal static string Msg_CopyingFile {
            get {
                return ResourceManager.GetString("Msg_CopyingFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete File &apos;{0}&apos;.
        /// </summary>
        internal static string Msg_DeleteFile {
            get {
                return ResourceManager.GetString("Msg_DeleteFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deployment to Sage 300 installation disabled..
        /// </summary>
        internal static string Msg_DeploymentToSage300InstallationDisabled {
            get {
                return ResourceManager.GetString("Msg_DeploymentToSage300InstallationDisabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Destination folder.
        /// </summary>
        internal static string Msg_DestinationFolder {
            get {
                return ResourceManager.GetString("Msg_DestinationFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do NOT copy assets to the local Sage 300 installation directory.
        /// </summary>
        internal static string Msg_DoNotCopyAssetsToSage300installationDirectory {
            get {
                return ResourceManager.GetString("Msg_DoNotCopyAssetsToSage300installationDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to End.
        /// </summary>
        internal static string Msg_End {
            get {
                return ResourceManager.GetString("Msg_End", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to files.Count() = {0}.
        /// </summary>
        internal static string Msg_FilesDotCount {
            get {
                return ResourceManager.GetString("Msg_FilesDotCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to files found.
        /// </summary>
        internal static string Msg_FilesFound {
            get {
                return ResourceManager.GetString("Msg_FilesFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Files have been deployed to local Sage 300 installation..
        /// </summary>
        internal static string Msg_FilesHaveBeenDeployedToLocalSage300Directory {
            get {
                return ResourceManager.GetString("Msg_FilesHaveBeenDeployedToLocalSage300Directory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to folder = &apos;{0}&apos;.
        /// </summary>
        internal static string Msg_FolderEquals {
            get {
                return ResourceManager.GetString("Msg_FolderEquals", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generate a log file in the current working folder.
        /// </summary>
        internal static string Msg_GenerateALogFileInTheCurrentWorkingFolder {
            get {
                return ResourceManager.GetString("Msg_GenerateALogFileInTheCurrentWorkingFolder", resourceCulture);
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
        ///   Looks up a localized string similar to Live Deployment. Files will actually be copied to live Sage 300 installion directory..
        /// </summary>
        internal static string Msg_LiveDeployment {
            get {
                return ResourceManager.GetString("Msg_LiveDeployment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Log File Location : {0}.
        /// </summary>
        internal static string Msg_LogFileLocation {
            get {
                return ResourceManager.GetString("Msg_LogFileLocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Logging Started....
        /// </summary>
        internal static string Msg_LoggingStarted {
            get {
                return ResourceManager.GetString("Msg_LoggingStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft Visual Studio Solution path.
        /// </summary>
        internal static string Msg_MicrosoftVisualStudioSolutionPath {
            get {
                return ResourceManager.GetString("Msg_MicrosoftVisualStudioSolutionPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft Visual Studio Solution Web project path.
        /// </summary>
        internal static string Msg_MicrosoftVisualStudioSolutionWebProjectPath {
            get {
                return ResourceManager.GetString("Msg_MicrosoftVisualStudioSolutionWebProjectPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Minification complete..
        /// </summary>
        internal static string Msg_MinificationComplete {
            get {
                return ResourceManager.GetString("Msg_MinificationComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Minification Successful!.
        /// </summary>
        internal static string Msg_MinificationSuccessful {
            get {
                return ResourceManager.GetString("Msg_MinificationSuccessful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Minify javascript files.
        /// </summary>
        internal static string Msg_MinifyJavascriptFiles {
            get {
                return ResourceManager.GetString("Msg_MinifyJavascriptFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .NET Framework path containing aspnet_compile.exe.
        /// </summary>
        internal static string Msg_NetFrameworkPathContainingAspnetCompileDotExe {
            get {
                return ResourceManager.GetString("Msg_NetFrameworkPathContainingAspnetCompileDotExe", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only.
        /// </summary>
        internal static string Msg_Only {
            get {
                return ResourceManager.GetString("Msg_Only", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; created..
        /// </summary>
        internal static string Msg_PathCreated {
            get {
                return ResourceManager.GetString("Msg_PathCreated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; deleted..
        /// </summary>
        internal static string Msg_PathDeleted {
            get {
                return ResourceManager.GetString("Msg_PathDeleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; exists..
        /// </summary>
        internal static string Msg_PathExists {
            get {
                return ResourceManager.GetString("Msg_PathExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Preparing {0} folders and files for Staging....
        /// </summary>
        internal static string Msg_PreparingDeployFoldersAndFilesForStaging {
            get {
                return ResourceManager.GetString("Msg_PreparingDeployFoldersAndFilesForStaging", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Prerequisites are valid..
        /// </summary>
        internal static string Msg_PrerequisitesAreValid {
            get {
                return ResourceManager.GetString("Msg_PrerequisitesAreValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Program Name:          {0}
        ///Version:               {1}
        ///
        ///Copyright:             (c) 1994-2018 The Sage Group plc or its licensors.  
        ///                       All rights reserved.
        ///License:               The MIT Licence (MIT)
        ///
        ///Required 3rd party
        ///programs/components:   {2}
        ///
        ///
        ///Required Parameter(s):
        ///
        ///{3}
        ///
        ///Optional Parameter(s):
        ///
        ///{4}.
        /// </summary>
        internal static string Msg_ProgramUsageMessage {
            get {
                return ResourceManager.GetString("Msg_ProgramUsageMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rename &apos;{0}&apos; to &apos;{1}&apos;.
        /// </summary>
        internal static string Msg_Rename1To2 {
            get {
                return ResourceManager.GetString("Msg_Rename1To2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Renaming complete!.
        /// </summary>
        internal static string Msg_RenamingComplete {
            get {
                return ResourceManager.GetString("Msg_RenamingComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Renaming javascript files back to usable state..
        /// </summary>
        internal static string Msg_RenamingJavascriptFilesBackToUsableState {
            get {
                return ResourceManager.GetString("Msg_RenamingJavascriptFilesBackToUsableState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to    Running command : {0}.
        /// </summary>
        internal static string Msg_RunningCommand {
            get {
                return ResourceManager.GetString("Msg_RunningCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sage 300 Menu definition file name (i.e. XXMenuDetails.xml).
        /// </summary>
        internal static string Msg_Sage300MenuDefinitionFileName {
            get {
                return ResourceManager.GetString("Msg_Sage300MenuDefinitionFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Simulate copying of assets to the local Sage 300 installation directory.
        /// </summary>
        internal static string Msg_SimulateCopyingOfAssetsTo {
            get {
                return ResourceManager.GetString("Msg_SimulateCopyingOfAssetsTo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Simulated Deployment Only. No files will actually be copied to live Sage 300 installion directory..
        /// </summary>
        internal static string Msg_SimulatedDeploymentOnly {
            get {
                return ResourceManager.GetString("Msg_SimulatedDeploymentOnly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Simulation.
        /// </summary>
        internal static string Msg_Simulation {
            get {
                return ResourceManager.GetString("Msg_Simulation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source folder.
        /// </summary>
        internal static string Msg_SourceFolder {
            get {
                return ResourceManager.GetString("Msg_SourceFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Visual Studio project build configuration (only release supported).
        /// </summary>
        internal static string Msg_VisualStudioProjectBuildConfiguration {
            get {
                return ResourceManager.GetString("Msg_VisualStudioProjectBuildConfiguration", resourceCulture);
            }
        }
    }
}
