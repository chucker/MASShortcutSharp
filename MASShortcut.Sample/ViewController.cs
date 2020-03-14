using System;

using AppKit;
using Foundation;

namespace MASShortcut.Sample
{
	public partial class ViewController : NSViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			EnableF1.Activated += (o, e) => OnEnableF1 ();
			EnableF2.Activated += (o, e) => OnEnableF2 ();
		}

        MASShortcut f1Shortcut;
		MASShortcut f2Shortcut;

		void OnEnableF1()
		{
			var shortcutMonitor = MASShortcutMonitor.SharedMonitor();

			if (f1Shortcut == null)
			{
				EnableF1.Title = "Disable Cmd-F1";
				Label.StringValue = "Cmd-F1 is enabled";
				var shortcut1 = new MASShortcut((uint)NSKey.F1, NSEventModifierFlags.Command);
				if (shortcutMonitor.RegisterShortcut(shortcut1, () =>
				{
					Label.StringValue = "Cmd-F1 pressed";
				}))
				{
					f1Shortcut = shortcut1;
				}
			}
			else
			{
				EnableF1.Title = "Enable Cmd-F1";
				Label.StringValue = "Cmd-F1 is disabled";
				shortcutMonitor.UnregisterShortcut(f1Shortcut);
				f1Shortcut = null;
			}
		}

		void OnEnableF2 ()
		{
			var shortcutMonitor = MASShortcutMonitor.SharedMonitor();

			if (f2Shortcut == null)
			{
				EnableF2.Title = "Disable Cmd-F2";
				Label.StringValue = "Cmd-F2 is enabled";
				var shortcut2 = new MASShortcut((uint)NSKey.F2, NSEventModifierFlags.Command);
				if (shortcutMonitor.RegisterShortcut(shortcut2, () =>
				{
					Label.StringValue = "Cmd-F2 pressed";
				}))
				{
					f2Shortcut = shortcut2;
				};
			}
			else
			{
				EnableF2.Title = "Enable Cmd-F2";
				Label.StringValue = "Cmd-F2 is disabled";
				shortcutMonitor.UnregisterShortcut(f2Shortcut);
				f2Shortcut = null;
			}
		}
	}
}
