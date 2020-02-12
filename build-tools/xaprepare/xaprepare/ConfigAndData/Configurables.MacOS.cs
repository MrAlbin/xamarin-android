using System;

namespace Xamarin.Android.Prepare
{
	partial class Configurables
	{
		partial class Urls
		{
			public static readonly Uri Corretto = new Uri ($"{Corretto_BaseUri}{CorrettoUrlPathVersion}/amazon-corretto-{CorrettoDistVersion}-macosx-x64.tar.gz");
			public static readonly Uri MonoPackage = new Uri ("https://xamjenkinsartifact.azureedge.net/build-package-osx-mono/2020-02/9/879f6699bb5e8bd684bcd0f0acc55401ad64991c/MonoFramework-MDK-6.12.0.7.macos10.xamarin.universal.pkg");
		}

		partial class Defaults
		{
			public const string MacOSDeploymentTarget = "10.11";
			public const string NativeLibraryExtension = ".dylib";
		}

		partial class Paths
		{
			const string LibMonoSgenBaseName = "libmonosgen-2.0";

			public const string MonoCrossRuntimeInstallPath = "Darwin";
			public const string NdkToolchainOSTag = "darwin-x86_64";
			public static readonly string UnstrippedLibMonoSgenName = $"{LibMonoSgenBaseName}.d{Defaults.NativeLibraryExtension}";
			public static readonly string StrippedLibMonoSgenName = $"{LibMonoSgenBaseName}{Defaults.NativeLibraryExtension}";
		}
	}
}
