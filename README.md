<img src="assets/ProjectBanner.png" alt="Legerity project banner" />

# Legerity

Legerity is a framework for speeding up the development of automated UI testing of Windows, Android, iOS, and Web apps with Appium/Selenium with .NET!

The aim of the framework is to provide easy to use components that allow you to quickly and easily get up and running in little to no time. 

With the help of out-of-the-box element wrappers for core platform controls, all the repetitive querying of your UI is alleviated! 

## Project status

| Source | Build |
| ------ | ------ |
| Azure Artifacts | [![Build Status](https://dev.azure.com/jamesmcroft/GitHub/_apis/build/status/MADE-Apps.legerity?branchName=main)](https://dev.azure.com/jamesmcroft/GitHub/_build/latest?definitionId=37&branchName=main) |

## Installation

Legerity is publicly available via NuGet. Each available package is detailed below. 

For non-core platform controls, for example WinUI or the Windows Community Toolkit, we're providing additional extension packages for you to take advantage of within your test projects.

| Package | Current | Preview |
| ------ | ------ | ------ |
| Legerity | [![Nuget](https://img.shields.io/nuget/v/Legerity.svg)](https://www.nuget.org/packages/Legerity/) | [![Nuget](https://img.shields.io/nuget/vpre/Legerity.svg)](https://www.nuget.org/packages/Legerity/) |
| Legerity.MADE | [![Nuget](https://img.shields.io/nuget/v/Legerity.MADE.svg)](https://www.nuget.org/packages/Legerity.MADE/) | [![Nuget](https://img.shields.io/nuget/vpre/Legerity.MADE.svg)](https://www.nuget.org/packages/Legerity.MADE/) |
| Legerity.Telerik.Uwp | [![Nuget](https://img.shields.io/nuget/v/Legerity.Telerik.Uwp.svg)](https://www.nuget.org/packages/Legerity.Telerik.Uwp/) | [![Nuget](https://img.shields.io/nuget/vpre/Legerity.Telerik.Uwp.svg)](https://www.nuget.org/packages/Legerity.Telerik.Uwp/) |
| Legerity.WCT | [![Nuget](https://img.shields.io/nuget/v/Legerity.WCT.svg)](https://www.nuget.org/packages/Legerity.WCT/) | [![Nuget](https://img.shields.io/nuget/vpre/Legerity.WCT.svg)](https://www.nuget.org/packages/Legerity.WCT/) |
| Legerity.WinUI | [![Nuget](https://img.shields.io/nuget/v/Legerity.WinUI.svg)](https://www.nuget.org/packages/Legerity.WinUI/) | [![Nuget](https://img.shields.io/nuget/vpre/Legerity.WinUI.svg)](https://www.nuget.org/packages/Legerity.WinUI/) |

## Tested with Legerity

Got an awesome project you've built and tested with Legerity? We'd love for you to share with the community!

[*Add your projects to the tested with Legerity collection!*](YOUR_PROJECTS.md)

## Documentation

If you want to deep dive into the Legerity framework with details on how to use the features, you can browse the [documentation](docs/README.md) for help getting up and running!

## Got controls?

Do you have a collection of custom controls that you'd like to see added to the Legerity framework? Feel free to drop a feature request into our [work tracker](https://github.com/MADE-Apps/legerity/issues)!

Even better, why not help build out your custom control wrapper elements within the framework and help out the community!

## Contributing 

Looking to help build Legerity? Take a look through our [contribution guidelines](CONTRIBUTING.md). We actively encourage you to jump in and help with any issues!

### UI Automation tooling

When contributing to new element wrappers, we recommended using the [Accessibility Insights tool](https://accessibilityinsights.io/en/). The tool is capable of inspecting and providing property values for Android, Web and Windows applications.

Alternatively, you can use the [Inspect.exe tool](https://docs.microsoft.com/en-us/windows/win32/winauto/inspect-objects) for Windows applications installed with the Windows SDKs. This is not recommended however as the tool is considered legacy and can often cause oddities in UI when using. 

## Building Legerity

Legeirty have been built using .NET Standard, taking advantage of the new SDK-style projects.

You can build the solution using Visual Studio with the following workloads installed:

- .NET desktop development
- .NET Core cross-platform development

## License

Legerity is made available under the terms and conditions of the [MIT license](LICENSE).
