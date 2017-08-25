//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace wirecardpayment_binding {
	public unsafe static partial class NSError_WDUtils  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("NSError");
		
		[Export ("wd_errorWithCode:andLocale:")]
		[CompilerGenerated]
		public static NSError Wd_errorWithCode (this NSError This, WDErrorCode code, WDLocale locale)
		{
			if (IntPtr.Size == 8) {
				return  Runtime.GetNSObject<NSError> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_Int64_Int64 (class_ptr, Selector.GetHandle ("wd_errorWithCode:andLocale:"), (Int64)code, (Int64)locale));
			} else {
				return  Runtime.GetNSObject<NSError> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int_int (class_ptr, Selector.GetHandle ("wd_errorWithCode:andLocale:"), (int)code, (int)locale));
			}
		}
		
		[Export ("wd_errorWithCode:andLocalizedDescription:")]
		[CompilerGenerated]
		public static NSError Wd_errorWithCode (this NSError This, WDErrorCode code, string localizedDescription)
		{
			if (localizedDescription == null)
				throw new ArgumentNullException ("localizedDescription");
			var nslocalizedDescription = NSString.CreateNative (localizedDescription);
			
			NSError ret;
			if (IntPtr.Size == 8) {
				ret =  Runtime.GetNSObject<NSError> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_Int64_IntPtr (class_ptr, Selector.GetHandle ("wd_errorWithCode:andLocalizedDescription:"), (Int64)code, nslocalizedDescription));
			} else {
				ret =  Runtime.GetNSObject<NSError> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int_IntPtr (class_ptr, Selector.GetHandle ("wd_errorWithCode:andLocalizedDescription:"), (int)code, nslocalizedDescription));
			}
			NSString.ReleaseNative (nslocalizedDescription);
			
			return ret;
		}
		
	} /* class NSError_WDUtils */
}
