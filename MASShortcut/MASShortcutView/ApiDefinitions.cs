using System;
using AppKit;
using Foundation;
using MASShortcut;
using ObjCRuntime;

namespace MASShortcut
{
	//[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	//partial interface Constants
	//{
	//	// extern NSString *const MASShortcutBinding;
	//	[Field ("MASShortcutBinding")]
	//	NSString MASShortcutBinding { get; }
	//}

	// @interface MASShortcutView : NSView
	[BaseType (typeof(NSView))]
	interface MASShortcutView
	{
		// @property (nonatomic, strong) MASShortcut * shortcutValue;
		[Export ("shortcutValue", ArgumentSemantic.Strong)]
		MASShortcut ShortcutValue { get; set; }

		// @property (nonatomic, strong) MASShortcutValidator * shortcutValidator;
		[Export ("shortcutValidator", ArgumentSemantic.Strong)]
		MASShortcutValidator ShortcutValidator { get; set; }

		// @property (getter = isRecording, nonatomic) BOOL recording;
		[Export ("recording")]
		bool Recording { [Bind ("isRecording")] get; set; }

		// @property (getter = isEnabled, nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		// @property (copy, nonatomic) void (^shortcutValueChange)(MASShortcutView *);
		[Export ("shortcutValueChange", ArgumentSemantic.Copy)]
		Action<MASShortcutView> ShortcutValueChange { get; set; }

        //// @property (assign, nonatomic) MASShortcutViewStyle style;
        //[Export("style", ArgumentSemantic.Assign)]
        //MASShortcutViewStyle Style { get; set; }

        // +(Class)shortcutCellClass;
        [Static]
		[Export ("shortcutCellClass")]
		//[Verify (MethodToProperty)]
		Class ShortcutCellClass { get; }

		// -(void)setAcceptsFirstResponder:(BOOL)value;
		[Export ("setAcceptsFirstResponder:")]
		void SetAcceptsFirstResponder (bool value);
	}
}
