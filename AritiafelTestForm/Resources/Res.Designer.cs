﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AritiafelTestForm.Resources {
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
    public class Res {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Res() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AritiafelTestForm.Resources.Res", typeof(Res).Assembly);
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
        ///   Looks up a localized string similar to You are guiltless..
        /// </summary>
        public static string AnswerString {
            get {
                return ResourceManager.GetString("AnswerString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to What&apos;s your gender? Yes is {0} No is {1}.
        /// </summary>
        public static string QuestionString {
            get {
                return ResourceManager.GetString("QuestionString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to What&apos;s your age? Yes is under {0} No is above {1}.
        /// </summary>
        public static string QuestionString2 {
            get {
                return ResourceManager.GetString("QuestionString2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 1111, {0}.
        /// </summary>
        public static string TestString {
            get {
                return ResourceManager.GetString("TestString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 2222, {0}.
        /// </summary>
        public static string TestString2 {
            get {
                return ResourceManager.GetString("TestString2", resourceCulture);
            }
        }
    }
}