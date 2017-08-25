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
	[Register("WDCardPayment", true)]
	public unsafe partial class WDCardPayment : WDPayment {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("WDCardPayment");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected WDCardPayment (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal WDCardPayment (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithAmount:amountCurrency:transactionType:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public WDCardPayment (NSDecimalNumber amount, WDCurrency amountCurrency, WDTransactionType transactionType)
			: base (NSObjectFlag.Empty)
		{
			if (amount == null)
				throw new ArgumentNullException ("amount");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_Int64_Int64 (this.Handle, Selector.GetHandle ("initWithAmount:amountCurrency:transactionType:"), amount.Handle, (Int64)amountCurrency, (Int64)transactionType), "initWithAmount:amountCurrency:transactionType:");
				} else {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_int_int (this.Handle, Selector.GetHandle ("initWithAmount:amountCurrency:transactionType:"), amount.Handle, (int)amountCurrency, (int)transactionType), "initWithAmount:amountCurrency:transactionType:");
				}
			} else {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_Int64_Int64 (this.SuperHandle, Selector.GetHandle ("initWithAmount:amountCurrency:transactionType:"), amount.Handle, (Int64)amountCurrency, (Int64)transactionType), "initWithAmount:amountCurrency:transactionType:");
				} else {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_int_int (this.SuperHandle, Selector.GetHandle ("initWithAmount:amountCurrency:transactionType:"), amount.Handle, (int)amountCurrency, (int)transactionType), "initWithAmount:amountCurrency:transactionType:");
				}
			}
		}
		
		[Export ("initWithAmount:currencyString:transactionType:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public WDCardPayment (NSDecimalNumber amount, string currency, WDTransactionType transactionType)
			: base (NSObjectFlag.Empty)
		{
			if (amount == null)
				throw new ArgumentNullException ("amount");
			if (currency == null)
				throw new ArgumentNullException ("currency");
			var nscurrency = NSString.CreateNative (currency);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_Int64 (this.Handle, Selector.GetHandle ("initWithAmount:currencyString:transactionType:"), amount.Handle, nscurrency, (Int64)transactionType), "initWithAmount:currencyString:transactionType:");
				} else {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_int (this.Handle, Selector.GetHandle ("initWithAmount:currencyString:transactionType:"), amount.Handle, nscurrency, (int)transactionType), "initWithAmount:currencyString:transactionType:");
				}
			} else {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_Int64 (this.SuperHandle, Selector.GetHandle ("initWithAmount:currencyString:transactionType:"), amount.Handle, nscurrency, (Int64)transactionType), "initWithAmount:currencyString:transactionType:");
				} else {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_int (this.SuperHandle, Selector.GetHandle ("initWithAmount:currencyString:transactionType:"), amount.Handle, nscurrency, (int)transactionType), "initWithAmount:currencyString:transactionType:");
				}
			}
			NSString.ReleaseNative (nscurrency);
			
		}
		
		[CompilerGenerated]
		public virtual WDAttempt AttemptThreeD {
			[Export ("attemptThreeD", ArgumentSemantic.UnsafeUnretained)]
			get {
				WDAttempt ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (WDAttempt) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("attemptThreeD"));
					} else {
						ret = (WDAttempt) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("attemptThreeD"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (WDAttempt) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("attemptThreeD"));
					} else {
						ret = (WDAttempt) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("attemptThreeD"));
					}
				}
				return ret;
			}
			
			[Export ("setAttemptThreeD:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setAttemptThreeD:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setAttemptThreeD:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setAttemptThreeD:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setAttemptThreeD:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Recurring {
			[Export ("isRecurring")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRecurring"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isRecurring"));
				}
			}
			
			[Export ("setRecurring:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRecurring:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setRecurring:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool RequireSecurityCode {
			[Export ("isSecurityCodeRequired")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSecurityCodeRequired"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isSecurityCodeRequired"));
				}
			}
			
			[Export ("setRequireSecurityCode:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRequireSecurityCode:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setRequireSecurityCode:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual WDSubMerchantInfo SubMerchantInfo {
			[Export ("subMerchantInfo", ArgumentSemantic.Retain)]
			get {
				WDSubMerchantInfo ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<WDSubMerchantInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("subMerchantInfo")));
				} else {
					ret =  Runtime.GetNSObject<WDSubMerchantInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("subMerchantInfo")));
				}
				return ret;
			}
			
			[Export ("setSubMerchantInfo:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSubMerchantInfo:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSubMerchantInfo:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual WDCardToken Token {
			[Export ("token", ArgumentSemantic.Retain)]
			get {
				WDCardToken ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<WDCardToken> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("token")));
				} else {
					ret =  Runtime.GetNSObject<WDCardToken> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("token")));
				}
				return ret;
			}
			
			[Export ("setToken:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setToken:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setToken:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
	} /* class WDCardPayment */
}
