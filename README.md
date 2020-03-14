# MASShortcutSharp

C# bindings for [MASShortcut](https://github.com/trustme/MASShortcut)

A sample C# Xamarin.Mac project to use MASShortcut bindings.

MASShortcut is a modern framework for managing global keyboard shortcuts compatible with Mac App Store. 

See the sample for how to add the binding to your Application.

To build open MASShortcut.sln and build or ```msbuild MASShortcut.sln```

## Build

###Upstream

First, build the upstream MASShortcut:

1. fetch it from https://github.com/shpakovski/MASShortcut
2. run `make release`

You'll end up with a `.framework`.

###Bind

Second, generate C# bindings:

1. fetch Objective Sharpie from http://aka.ms/objective-sharpie
2. run something like `sharpie bind --output=MASShortcut/MASShortcut --namespace=MASShortcut --sdk=macosx10.15 --scope=External/MASShortcut.framework/Versions/A/Headers/ External/MASShortcut.framework/Versions/A/Headers/MASShortcut.h`
3. …and `sharpie bind --output=MASShortcut/MASShortcutView --namespace=MASShortcut --sdk=macosx10.15 --scope=External/MASShortcut.framework/Versions/A/Headers/ External/MASShortcut.framework/Versions/A/Headers/MASShortcutView.h`

That last one seems to fail with the Objective Sharpie 3.5.22. Try adding this to the beginning of `MASShortcutView.h`:

	#import <AppKit/AppKit.h>


