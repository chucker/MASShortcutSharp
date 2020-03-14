using System;
using AppKit;
using Foundation;
using MASShortcut;

namespace MASShortcut
{
	delegate void GlobalHotkeyMonitorHandler();

	// @interface MASShortcutMonitor : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MASShortcutMonitor
	{
		// +(instancetype)sharedMonitor;
		[Static]
		[Export ("sharedMonitor")]
		MASShortcutMonitor SharedMonitor ();

		// -(BOOL)registerShortcut:(MASShortcut *)shortcut withAction:(dispatch_block_t)action;
		[Export ("registerShortcut:withAction:")]
		bool RegisterShortcut (MASShortcut shortcut, GlobalHotkeyMonitorHandler action);

		// -(BOOL)isShortcutRegistered:(MASShortcut *)shortcut;
		[Export ("isShortcutRegistered:")]
		bool IsShortcutRegistered (MASShortcut shortcut);

		// -(void)unregisterShortcut:(MASShortcut *)shortcut;
		[Export ("unregisterShortcut:")]
		void UnregisterShortcut (MASShortcut shortcut);

		// -(void)unregisterAllShortcuts;
		[Export ("unregisterAllShortcuts")]
		void UnregisterAllShortcuts ();
	}
}
