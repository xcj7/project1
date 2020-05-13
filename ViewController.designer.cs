// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace any
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField labelinfo { get; set; }

		[Action ("hellowpressed:")]
		partial void hellowpressed (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (labelinfo != null) {
				labelinfo.Dispose ();
				labelinfo = null;
			}
		}
	}
}
