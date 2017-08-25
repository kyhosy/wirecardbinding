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
	[Register("WDApplePayManagedPayment", true)]
	public unsafe partial class WDApplePayManagedPayment : WDApplePayPayment {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("WDApplePayManagedPayment");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected WDApplePayManagedPayment (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal WDApplePayManagedPayment (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithMerchant:andCountry:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public WDApplePayManagedPayment (string appleMerchantID, WDCountry merchantCountry)
			: base (NSObjectFlag.Empty)
		{
			if (appleMerchantID == null)
				throw new ArgumentNullException ("appleMerchantID");
			var nsappleMerchantID = NSString.CreateNative (appleMerchantID);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_Int64 (this.Handle, Selector.GetHandle ("initWithMerchant:andCountry:"), nsappleMerchantID, (Int64)merchantCountry), "initWithMerchant:andCountry:");
				} else {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_int (this.Handle, Selector.GetHandle ("initWithMerchant:andCountry:"), nsappleMerchantID, (int)merchantCountry), "initWithMerchant:andCountry:");
				}
			} else {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_Int64 (this.SuperHandle, Selector.GetHandle ("initWithMerchant:andCountry:"), nsappleMerchantID, (Int64)merchantCountry), "initWithMerchant:andCountry:");
				} else {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_int (this.SuperHandle, Selector.GetHandle ("initWithMerchant:andCountry:"), nsappleMerchantID, (int)merchantCountry), "initWithMerchant:andCountry:");
				}
			}
			NSString.ReleaseNative (nsappleMerchantID);
			
		}
		
		[CompilerGenerated]
		public virtual string AppleMerchantID {
			[Export ("appleMerchantID")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("appleMerchantID")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("appleMerchantID")));
				}
			}
			
			[Export ("setAppleMerchantID:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAppleMerchantID:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAppleMerchantID:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual WDCountry MerchantCountry {
			[Export ("merchantCountry", ArgumentSemantic.UnsafeUnretained)]
			get {
				WDCountry ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (WDCountry) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("merchantCountry"));
					} else {
						ret = (WDCountry) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("merchantCountry"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (WDCountry) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("merchantCountry"));
					} else {
						ret = (WDCountry) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("merchantCountry"));
					}
				}
				return ret;
			}
			
			[Export ("setMerchantCountry:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setMerchantCountry:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setMerchantCountry:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setMerchantCountry:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setMerchantCountry:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool RequiredBillingAddress {
			[Export ("requiredBillingAddress")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("requiredBillingAddress"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("requiredBillingAddress"));
				}
			}
			
			[Export ("setRequiredBillingAddress:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRequiredBillingAddress:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setRequiredBillingAddress:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool RequiredShippingAddress {
			[Export ("requiredShippingAddress")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("requiredShippingAddress"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("requiredShippingAddress"));
				}
			}
			
			[Export ("setRequiredShippingAddress:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRequiredShippingAddress:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setRequiredShippingAddress:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSSet<NSNumber> SupportedCardBrands {
			[Export ("supportedCardBrands", ArgumentSemantic.Copy)]
			get {
				NSSet<NSNumber> ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet<NSNumber>> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("supportedCardBrands")));
				} else {
					ret =  Runtime.GetNSObject<NSSet<NSNumber>> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("supportedCardBrands")));
				}
				return ret;
			}
			
			[Export ("setSupportedCardBrands:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSupportedCardBrands:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSupportedCardBrands:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
	} /* class WDApplePayManagedPayment */
}
