// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Chip8Mac
{
	[Register ("MainWindowController")]
	partial class MainWindowController
	{
		[Outlet]
		AppKit.NSView CustomVIew { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CustomVIew != null) {
				CustomVIew.Dispose ();
				CustomVIew = null;
			}
		}
	}
}
