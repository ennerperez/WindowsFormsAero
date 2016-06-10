![logo](https://raw.githubusercontent.com/ennerperez/WindowsFormsAero/master/.editoricon.png)

# WindowsFormsAero

This project aims to create a Windows Control Library that provides controls reproducing the appearance of Microsoft Aero graphic objects, like buttons and links with shield icon, textboxes with cue banner, etc.

Original article can be found at [http://windowsformsaero.codeplex.com/](http://windowsformsaero.codeplex.com/)

All credits are for [Marco Minerva](http://www.codeplex.com/site/users/view/marcom), I decided to place it in GitHub to make a NuGet package, because is the third most useful controls in Windows Forms to me.

// Marco Minerva thanks so much. Since 2007.

[![Build status](https://ci.appveyor.com/api/projects/status/192can949c1pqs9y?svg=true)](https://ci.appveyor.com/project/ennerperez/windowsformsaero)
[![NuGet](http://img.shields.io/nuget/v/WindowsFormsAero.svg)](https://www.nuget.org/packages/WindowsFormsAero/)

---------------------------------------

See the [changelog](CHANGELOG.md) for changes.

## Table of contents

* [Implementing](#implementing)
* [Introduction](#introduction)
* [Features](#Features)
* [License](#license)

### Implementing

**Add the library to your project**

Add the [NuGet Package](https://www.nuget.org/packages/WindowsFormsAero/). Right click on your project and click 'Manage NuGet Packages...'. Search for 'WindowsFormsAero' and click on install. Once installed the library will be included in your project references. (Or install it through the package manager console: PM> Install-Package WindowsFormsAero).

### Introduction
The current version contains several native Vista controls (such as Buttons, Combo boxes with cue banner, Command links, native List views, Progress bars, explorer-like TreeView...) and some modules that empower the user to exploit some of Vista's advanced GUI features (Glass sheet effect, text on glass, live thumbnails and the new Task dialogs).

### Features 
- Controls
    - ShieldButton
    - ComboBox with cue banner
    - CommandLink
    - ListView
    - ProgressBar
    - TextBox with cue banner
    - TreeView
    - ThemedText label (Text on glass effect)
    - SplitButton
    - VerticalPanel
    - HorizontalPanel
    - LabeledDivider
    - SearchTextBox
- Modules
    - DWM module (Live thumbnails and glass sheet effect)
    - ThemedText module
    - Task Dialog module (alternative to classic Message boxes)
- Support
    - OS support (checks if Vista libraries are supported)
    - Glass sheet helpers

### License
This article, along with any associated source code and files, is licensed under [Microsoft Reciprocal License (Ms-RL)](LICENSE)