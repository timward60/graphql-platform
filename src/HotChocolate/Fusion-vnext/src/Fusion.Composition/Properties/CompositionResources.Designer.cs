﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotChocolate.Fusion.Properties {
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
    internal class CompositionResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CompositionResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HotChocolate.Fusion.Properties.CompositionResources", typeof(CompositionResources).Assembly);
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
        ///   Looks up a localized string similar to Pre-merge validation failed. View the composition log for details..
        /// </summary>
        internal static string ErrorHelper_PreMergeValidationFailed {
            get {
                return ResourceManager.GetString("ErrorHelper_PreMergeValidationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The built-in scalar type &apos;{0}&apos; in schema &apos;{1}&apos; is not accessible..
        /// </summary>
        internal static string LogEntryHelper_DisallowedInaccessibleBuiltInScalar {
            get {
                return ResourceManager.GetString("LogEntryHelper_DisallowedInaccessibleBuiltInScalar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The built-in directive argument &apos;{0}&apos; in schema &apos;{1}&apos; is not accessible..
        /// </summary>
        internal static string LogEntryHelper_DisallowedInaccessibleDirectiveArgument {
            get {
                return ResourceManager.GetString("LogEntryHelper_DisallowedInaccessibleDirectiveArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The introspection argument &apos;{0}&apos; in schema &apos;{1}&apos; is not accessible..
        /// </summary>
        internal static string LogEntryHelper_DisallowedInaccessibleIntrospectionArgument {
            get {
                return ResourceManager.GetString("LogEntryHelper_DisallowedInaccessibleIntrospectionArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The introspection field &apos;{0}&apos; in schema &apos;{1}&apos; is not accessible..
        /// </summary>
        internal static string LogEntryHelper_DisallowedInaccessibleIntrospectionField {
            get {
                return ResourceManager.GetString("LogEntryHelper_DisallowedInaccessibleIntrospectionField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The introspection type &apos;{0}&apos; in schema &apos;{1}&apos; is not accessible..
        /// </summary>
        internal static string LogEntryHelper_DisallowedInaccessibleIntrospectionType {
            get {
                return ResourceManager.GetString("LogEntryHelper_DisallowedInaccessibleIntrospectionType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument with schema coordinate &apos;{0}&apos; has inconsistent default values..
        /// </summary>
        internal static string LogEntryHelper_ExternalArgumentDefaultMismatch {
            get {
                return ResourceManager.GetString("LogEntryHelper_ExternalArgumentDefaultMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to External field &apos;{0}&apos; in schema &apos;{1}&apos; is not defined (non-external) in any other schema..
        /// </summary>
        internal static string LogEntryHelper_ExternalMissingOnBase {
            get {
                return ResourceManager.GetString("LogEntryHelper_ExternalMissingOnBase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to External field &apos;{0}&apos; in schema &apos;{1}&apos; is not referenced by a @provides directive in the schema..
        /// </summary>
        internal static string LogEntryHelper_ExternalUnused {
            get {
                return ResourceManager.GetString("LogEntryHelper_ExternalUnused", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A @key directive on type &apos;{0}&apos; in schema &apos;{1}&apos; references field &apos;{2}&apos;, which must not include directive applications..
        /// </summary>
        internal static string LogEntryHelper_KeyDirectiveInFieldsArgument {
            get {
                return ResourceManager.GetString("LogEntryHelper_KeyDirectiveInFieldsArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A @key directive on type &apos;{0}&apos; in schema &apos;{1}&apos; references field &apos;{2}&apos;, which must not have arguments..
        /// </summary>
        internal static string LogEntryHelper_KeyFieldsHasArguments {
            get {
                return ResourceManager.GetString("LogEntryHelper_KeyFieldsHasArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A @key directive on type &apos;{0}&apos; in schema &apos;{1}&apos; references field &apos;{2}&apos;, which must not be a list, interface, or union type..
        /// </summary>
        internal static string LogEntryHelper_KeyFieldsSelectInvalidType {
            get {
                return ResourceManager.GetString("LogEntryHelper_KeyFieldsSelectInvalidType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A @key directive on type &apos;{0}&apos; in schema &apos;{1}&apos; references field &apos;{2}&apos;, which does not exist..
        /// </summary>
        internal static string LogEntryHelper_KeyInvalidFields {
            get {
                return ResourceManager.GetString("LogEntryHelper_KeyInvalidFields", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A @key directive on type &apos;{0}&apos; in schema &apos;{1}&apos; contains invalid syntax in the &apos;fields&apos; argument..
        /// </summary>
        internal static string LogEntryHelper_KeyInvalidSyntax {
            get {
                return ResourceManager.GetString("LogEntryHelper_KeyInvalidSyntax", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Field &apos;{0}&apos; has a different type shape in schema &apos;{1}&apos; than it does in schema &apos;{2}&apos;..
        /// </summary>
        internal static string LogEntryHelper_OutputFieldTypesNotMergeable {
            get {
                return ResourceManager.GetString("LogEntryHelper_OutputFieldTypesNotMergeable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The root mutation type in schema &apos;{0}&apos; must be named &apos;Mutation&apos;..
        /// </summary>
        internal static string LogEntryHelper_RootMutationUsed {
            get {
                return ResourceManager.GetString("LogEntryHelper_RootMutationUsed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The root query type in schema &apos;{0}&apos; must be named &apos;Query&apos;..
        /// </summary>
        internal static string LogEntryHelper_RootQueryUsed {
            get {
                return ResourceManager.GetString("LogEntryHelper_RootQueryUsed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The root subscription type in schema &apos;{0}&apos; must be named &apos;Subscription&apos;..
        /// </summary>
        internal static string LogEntryHelper_RootSubscriptionUsed {
            get {
                return ResourceManager.GetString("LogEntryHelper_RootSubscriptionUsed", resourceCulture);
            }
        }
    }
}