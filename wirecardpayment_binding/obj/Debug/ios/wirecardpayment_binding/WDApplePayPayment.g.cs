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
	[Register("WDApplePayPayment", true)]
	public unsafe partial class WDApplePayPayment : WDPayment {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("WDApplePayPayment");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public WDApplePayPayment () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected WDApplePayPayment (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal WDApplePayPayment (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithPayment:summaryItems:currency:transactionType:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public WDApplePayPayment (global::PassKit.PKPayment payment, global::PassKit.PKPaymentSummaryItem[] summaryItems, WDCurrency currency, WDTransactionType transactionType)
			: base (NSObjectFlag.Empty)
		{
			if (payment == null)
				throw new ArgumentNullException ("payment");
			if (summaryItems == null)
				throw new ArgumentNullException ("summaryItems");
			var nsa_summaryItems = NSArray.FromNSObjects (summaryItems);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_Int64_Int64 (this.Handle, Selector.GetHandle ("initWithPayment:summaryItems:currency:transactionType:"), payment.Handle, nsa_summaryItems.Handle, (Int64)currency, (Int64)transactionType), "initWithPayment:summaryItems:currency:transactionType:");
				} else {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_int_int (this.Handle, Selector.GetHandle ("initWithPayment:summaryItems:currency:transactionType:"), payment.Handle, nsa_summaryItems.Handle, (int)currency, (int)transactionType), "initWithPayment:summaryItems:currency:transactionType:");
				}
			} else {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_Int64_Int64 (this.SuperHandle, Selector.GetHandle ("initWithPayment:summaryItems:currency:transactionType:"), payment.Handle, nsa_summaryItems.Handle, (Int64)currency, (Int64)transactionType), "initWithPayment:summaryItems:currency:transactionType:");
				} else {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_int_int (this.SuperHandle, Selector.GetHandle ("initWithPayment:summaryItems:currency:transactionType:"), payment.Handle, nsa_summaryItems.Handle, (int)currency, (int)transactionType), "initWithPayment:summaryItems:currency:transactionType:");
				}
			}
			nsa_summaryItems.Dispose ();
			
		}
		
		[Export ("initWithPayment:summaryItems:currencyString:transactionType:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public WDApplePayPayment (global::PassKit.PKPayment payment, global::PassKit.PKPaymentSummaryItem[] summaryItems, string currency, WDTransactionType transactionType)
			: base (NSObjectFlag.Empty)
		{
			if (payment == null)
				throw new ArgumentNullException ("payment");
			if (summaryItems == null)
				throw new ArgumentNullException ("summaryItems");
			if (currency == null)
				throw new ArgumentNullException ("currency");
			var nsa_summaryItems = NSArray.FromNSObjects (summaryItems);
			var nscurrency = NSString.CreateNative (currency);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_Int64 (this.Handle, Selector.GetHandle ("initWithPayment:summaryItems:currencyString:transactionType:"), payment.Handle, nsa_summaryItems.Handle, nscurrency, (Int64)transactionType), "initWithPayment:summaryItems:currencyString:transactionType:");
				} else {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_int (this.Handle, Selector.GetHandle ("initWithPayment:summaryItems:currencyString:transactionType:"), payment.Handle, nsa_summaryItems.Handle, nscurrency, (int)transactionType), "initWithPayment:summaryItems:currencyString:transactionType:");
				}
			} else {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_Int64 (this.SuperHandle, Selector.GetHandle ("initWithPayment:summaryItems:currencyString:transactionType:"), payment.Handle, nsa_summaryItems.Handle, nscurrency, (Int64)transactionType), "initWithPayment:summaryItems:currencyString:transactionType:");
				} else {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_int (this.SuperHandle, Selector.GetHandle ("initWithPayment:summaryItems:currencyString:transactionType:"), payment.Handle, nsa_summaryItems.Handle, nscurrency, (int)transactionType), "initWithPayment:summaryItems:currencyString:transactionType:");
				}
			}
			nsa_summaryItems.Dispose ();
			NSString.ReleaseNative (nscurrency);
			
		}
		
	} /* class WDApplePayPayment */
}
