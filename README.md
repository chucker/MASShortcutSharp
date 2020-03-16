# MASShortcutSharp

C# bindings for [MASShortcut](https://github.com/trustme/MASShortcut)

A sample C# Xamarin.Mac project to use MASShortcut bindings.

MASShortcut is a modern framework for managing global keyboard shortcuts compatible with Mac App Store. 

See the sample for how to add the binding to your Application.

## Build

### Upstream

First, build the upstream MASShortcut:

1. fetch it from https://github.com/shpakovski/MASShortcut
2. run `make release`

You'll end up with a `.framework`.

### Bind

Second, generate C# bindings:

1. fetch Objective Sharpie from http://aka.ms/objective-sharpie
2. edit `MASShortcutView.h` in your `.framework`, because Objective Sharpie (as of 3.5.22) gets confused. To the top, add:

```objectivec
#import <AppKit/AppKit.h>
```

3. inside the folder containing the `.sln`, run something like:  

```bash
for header in MASShortcut MASShortcutMonitor MASShortcutValidator MASShortcutView; \
sharpie bind --output=MASShortcut/$header --namespace=MASShortcut --sdk=macosx10.15 \
--scope=External/MASShortcut.framework/Versions/A/Headers/ \
External/MASShortcut.framework/Versions/A/Headers/$header.h`
```

	Adjust the macOS SDK to the one you actually have. You can run `sharpie xcode -sdks` to find out.

	The above will generate a bunch of C# files from Objective-C headers.

4. open the `.sln`. Some of the afore-generated code won't compile; much of it can just be commented out. Try looking at your favorite git client to see what has changed.

5. restore the `MASShortcutView.h` to how it was. Otherwise, you'll break code signing!

6. do a release build. Or, you can do a debug build and play around with the sample application.

## Use in Xamarin Forms

1. take a release build.
2. add it as a Reference (*not* Native!) to your Xamarin project.
3. in your XAML, add a namespace for the library:

```xml
xmlns:masshortcut="clr-namespace:MASShortcut;assembly=masshortcut;targetPlatform=macOS"
```

	Note the special `targetPlatform` sauce here. This lets you still use the XAML in a non-Mac-specific project.

4. you can just use this as a XAML control:

```xml
<masshortcut:MASShortcutView />
```

5. build and run — you should see a button labeled **Record Shortcut** now. Neat!

If you want use portions of that view on multiple platforms, you can do that too, like so:

```xml
<?xml version="1.0" encoding="UTF-8"?>
<ContentPage
    xmlns="http://xamarin.com/schemas/2014/forms"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"

    xmlns:masshortcut="clr-namespace:MASShortcut;assembly=masshortcut;targetPlatform=macOS">

    <ContentPage.Content>
        <StackLayout Orientation="Vertical" Margin="50">
            <ContentView>
                <OnPlatform x:TypeArguments="View">
                    <On Platform="macOS">
                        <masshortcut:MASShortcutView />
                    </On>
                </OnPlatform>
            </ContentView>
        </StackLayout>
    </ContentPage.Content>
</ContentPage>
```
