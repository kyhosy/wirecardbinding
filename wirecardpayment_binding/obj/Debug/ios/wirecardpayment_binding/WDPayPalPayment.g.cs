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
	[Register("WDPayPalPayment", true)]
	public unsafe partial class WDPayPalPayment : WDPayment {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("WDPayPalPayment");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected WDPayPalPayment (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal WDPayPalPayment (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithAmount:currency:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public WDPayPalPayment (NSDecimalNumber amount, WDCurrency currency)
			: base (NSObjectFlag.Empty)
		{
			if (amount == null)
				throw new ArgumentNullException ("amount");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_Int64 (this.Handle, Selector.GetHandle ("initWithAmount:currency:"), amount.Handle, (Int64)currency), "initWithAmount:currency:");
				} else {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_int (this.Handle, Selector.GetHandle ("initWithAmount:currency:"), amount.Handle, (int)currency), "initWithAmount:currency:");
				}
			} else {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_Int64 (this.SuperHandle, Selector.GetHandle ("initWithAmount:currency:"), amount.Handle, (Int64)currency), "initWithAmount:currency:");
				} else {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_int (this.SuperHandle, Selector.GetHandle ("initWithAmount:currency:"), amount.Handle, (int)currency), "initWithAmount:currency:");
				}
			}
		}
		
		[Export ("initWithAmount:currencyString:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public WDPayPalPayment (NSDecimalNumber amount, string currency)
			: base (NSObjectFlag.Empty)
		{
			if (amount == null)
				throw new ArgumentNullException ("amount");
			if (currency == null)
				throw new ArgumentNullException ("currency");
			var nscurrency = NSString.CreateNative (currency);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithAmount:currencyString:"), amount.Handle, nscurrency), "initWithAmount:currencyString:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithAmount:currencyString:"), amount.Handle, nscurrency), "initWithAmount:currencyString:");
			}
			NSString.ReleaseNative (nscurrency);
			
		}
		
		[CompilerGenerated]
		public virtual WDPeriodic Periodic {
			[Export ("periodic", ArgumentSemantic.Retain)]
			get {
				WDPeriodic ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<WDPeriodic> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("periodic")));
				} else {
					ret =  Runtime.GetNSObject<WDPeriodic> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("periodic")));
				}
				return ret;
			}
			
			[Export ("setPeriodic:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPeriodic:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPeriodic:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
	} /* class WDPayPalPayment */
}
