using System;
using AppKit;
using Foundation;
using MASShortcut;

namespace MASShortcut
{
	//// @interface MASShortcut : NSObject <NSSecureCoding, NSCopying>
	//[BaseType (typeof(NSObject))]
	//interface MASShortcut : INSSecureCoding, INSCopying
	//{
	//	// @property (readonly, nonatomic) NSInteger keyCode;
	//	[Export ("keyCode")]
	//	nint KeyCode { get; }

	//	// @property (readonly, nonatomic) NSEventModifierFlags modifierFlags;
	//	[Export ("modifierFlags")]
	//	NSEventModifierFlags ModifierFlags { get; }

	//	// @property (readonly, nonatomic) UInt32 carbonKeyCode;
	//	[Export ("carbonKeyCode")]
	//	uint CarbonKeyCode { get; }

	//	// @property (readonly, nonatomic) UInt32 carbonFlags;
	//	[Export ("carbonFlags")]
	//	uint CarbonFlags { get; }

	//	// @property (readonly, nonatomic) NSString * keyCodeString;
	//	[Export ("keyCodeString")]
	//	string KeyCodeString { get; }

	//	// @property (readonly, nonatomic) NSString * keyCodeStringForKeyEquivalent;
	//	[Export ("keyCodeStringForKeyEquivalent")]
	//	string KeyCodeStringForKeyEquivalent { get; }

	//	// @property (readonly, nonatomic) NSString * modifierFlagsString;
	//	[Export ("modifierFlagsString")]
	//	string ModifierFlagsString { get; }

	//	// -(instancetype)initWithKeyCode:(NSInteger)code modifierFlags:(NSEventModifierFlags)flags;
	//	[Export ("initWithKeyCode:modifierFlags:")]
	//	IntPtr Constructor (nint code, NSEventModifierFlags flags);

	//	// +(instancetype)shortcutWithKeyCode:(NSInteger)code modifierFlags:(NSEventModifierFlags)flags;
	//	[Static]
	//	[Export ("shortcutWithKeyCode:modifierFlags:")]
	//	MASShortcut ShortcutWithKeyCode (nint code, NSEventModifierFlags flags);

	//	// +(instancetype)shortcutWithEvent:(NSEvent *)anEvent;
	//	[Static]
	//	[Export ("shortcutWithEvent:")]
	//	MASShortcut ShortcutWithEvent (NSEvent anEvent);
	//}

	// @interface MASShortcutValidator : NSObject
	[BaseType (typeof(NSObject))]
	interface MASShortcutValidator
	{
		// @property (assign) BOOL allowAnyShortcutWithOptionModifier;
		[Export ("allowAnyShortcutWithOptionModifier")]
		bool AllowAnyShortcutWithOptionModifier { get; set; }

		// +(instancetype)sharedValidator;
		[Static]
		[Export ("sharedValidator")]
		MASShortcutValidator SharedValidator ();

		// -(BOOL)isShortcutValid:(MASShortcut *)shortcut;
		[Export ("isShortcutValid:")]
		bool IsShortcutValid (MASShortcut shortcut);

		// -(BOOL)isShortcut:(MASShortcut *)shortcut alreadyTakenInMenu:(NSMenu *)menu explanation:(NSString **)explanation;
		[Export ("isShortcut:alreadyTakenInMenu:explanation:")]
		bool IsShortcut (MASShortcut shortcut, NSMenu menu, out string explanation);

		// -(BOOL)isShortcutAlreadyTakenBySystem:(MASShortcut *)shortcut explanation:(NSString **)explanation;
		[Export ("isShortcutAlreadyTakenBySystem:explanation:")]
		bool IsShortcutAlreadyTakenBySystem (MASShortcut shortcut, out string explanation);
	}
}
