using System;
using System.Runtime.InteropServices;
using Foundation;

namespace MASShortcut
{
	public enum kMASShortcutGlyph : ushort
	{
		Eject = 9167,
		Clear = 10005,
		DeleteLeft = 9003,
		DeleteRight = 8998,
		LeftArrow = 8592,
		RightArrow = 8594,
		UpArrow = 8593,
		DownArrow = 8595,
		Escape = 9099,
		Help = 63,
		PageDown = 8671,
		PageUp = 8670,
		TabRight = 8677,
		Return = 8965,
		ReturnR2L = 8617,
		PadClear = 8999,
		NorthwestArrow = 8598,
		SoutheastArrow = 8600
	}

	//static class CFunctions
	//{
	//	// NSString * NSStringFromMASKeyCode (unsigned short ch) __attribute__((always_inline));
	//	[DllImport ("__Internal")]
	//	[Verify (PlatformInvoke)]
	//	static extern NSString NSStringFromMASKeyCode (ushort ch);

	//	// NSUInteger MASPickCocoaModifiers (NSUInteger flags) __attribute__((always_inline));
	//	[DllImport ("__Internal")]
	//	[Verify (PlatformInvoke)]
	//	static extern nuint MASPickCocoaModifiers (nuint flags);

	//	// UInt32 MASCarbonModifiersFromCocoaModifiers (NSUInteger cocoaFlags) __attribute__((always_inline));
	//	[DllImport ("__Internal")]
	//	[Verify (PlatformInvoke)]
	//	static extern uint MASCarbonModifiersFromCocoaModifiers (nuint cocoaFlags);
	//}
}
