﻿using System.Reflection;

namespace AeroGear.Mobile.Core
{
    public sealed class MobileCoreIOS
    {
        /// <summary>
        /// Initializes Mobile core for iOS.
        /// </summary>
        public static void Init()
        {
            Init(null, new Options());
        }

        /// <summary>
        /// Initializes Mobile core for iOS.
        /// </summary>
        /// <param name="options">additional initialization options</param>
        public static void Init(Options options)
        {
            Init(null, options);
        }

        /// <summary>
        /// Initializes Mobile core for iOS using custom assembly for storing resources. Best to be used with Xamarin.Forms.
        /// Resources needs to be stored in ./Resources directory of Xamarin.Forms platform-independent project.
        /// </summary>
        /// <param name="assembly">Assembly of the platform-independent project</param>
        public static void Init(Assembly assembly)
        {
            Init(assembly, new Options());
        }

        /// <summary>
        /// Initializes Mobile core for iOS using custom assembly for storing resources. Best to be used with Xamarin.Forms.
        /// Resources needs to be stored in ./Resources directory of Xamarin.Forms platform-independent project.
        /// </summary>
        /// <param name="assembly">Assembly of the platform-independent project</param>
        /// <param name="options">additional initialization options</param>
        public static void Init(Assembly assembly, Options options)
        {
            IPlatformInjector platformInjector = new IOSPlatformInjector();
            platformInjector.ExecutingAssembly = assembly;
            MobileCore.Init(platformInjector, options);
        }
    }
}