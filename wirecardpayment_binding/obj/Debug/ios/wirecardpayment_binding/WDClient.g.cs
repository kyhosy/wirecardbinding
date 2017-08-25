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
	[Register("WDClient", true)]
	public unsafe partial class WDClient : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("WDClient");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected WDClient (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal WDClient (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithEnvironment:")]
		[CompilerGenerated]
		public WDClient (WDEnvironment environment)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("initWithEnvironment:"), (Int64)environment), "initWithEnvironment:");
				} else {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int (this.Handle, Selector.GetHandle ("initWithEnvironment:"), (int)environment), "initWithEnvironment:");
				}
			} else {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("initWithEnvironment:"), (Int64)environment), "initWithEnvironment:");
				} else {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("initWithEnvironment:"), (int)environment), "initWithEnvironment:");
				}
			}
		}
		
		[Export ("initWithEnvironment:error:")]
		[CompilerGenerated]
		public WDClient (WDEnvironment environment, out NSError error)
			: base (NSObjectFlag.Empty)
		{
			IntPtr errorValue = IntPtr.Zero;
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_Int64_ref_IntPtr (this.Handle, Selector.GetHandle ("initWithEnvironment:error:"), (Int64)environment, ref errorValue), "initWithEnvironment:error:");
				} else {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int_ref_IntPtr (this.Handle, Selector.GetHandle ("initWithEnvironment:error:"), (int)environment, ref errorValue), "initWithEnvironment:error:");
				}
			} else {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_Int64_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithEnvironment:error:"), (Int64)environment, ref errorValue), "initWithEnvironment:error:");
				} else {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_int_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithEnvironment:error:"), (int)environment, ref errorValue), "initWithEnvironment:error:");
				}
			}
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
		}
		
		[Export ("initWithHostname:error:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public WDClient (string hostname, out NSError error)
			: base (NSObjectFlag.Empty)
		{
			if (hostname == null)
				throw new ArgumentNullException ("hostname");
			IntPtr errorValue = IntPtr.Zero;
			
			var nshostname = NSString.CreateNative (hostname);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("initWithHostname:error:"), nshostname, ref errorValue), "initWithHostname:error:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithHostname:error:"), nshostname, ref errorValue), "initWithHostname:error:");
			}
			NSString.ReleaseNative (nshostname);
			
			
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
		}
		
		[Export ("checkPayment:withCompletion:")]
		[CompilerGenerated]
		public unsafe virtual void CheckPayment (WDPayment payment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWDCompletionBlock))]WDCompletionBlock completionBlock)
		{
			if (payment == null)
				throw new ArgumentNullException ("payment");
			if (completionBlock == null)
				throw new ArgumentNullException ("completionBlock");
			BlockLiteral *block_ptr_completionBlock;
			BlockLiteral block_completionBlock;
			block_completionBlock = new BlockLiteral ();
			block_ptr_completionBlock = &block_completionBlock;
			block_completionBlock.SetupBlock (Trampolines.SDWDCompletionBlock.Handler, completionBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("checkPayment:withCompletion:"), payment.Handle, (IntPtr) block_ptr_completionBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("checkPayment:withCompletion:"), payment.Handle, (IntPtr) block_ptr_completionBlock);
			}
			block_ptr_completionBlock->CleanupBlock ();
			
		}
		
		[Export ("makePayment:withCompletion:")]
		[CompilerGenerated]
		public unsafe virtual void MakePayment (WDPayment payment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWDCompletionBlock))]WDCompletionBlock completionBlock)
		{
			if (payment == null)
				throw new ArgumentNullException ("payment");
			if (completionBlock == null)
				throw new ArgumentNullException ("completionBlock");
			BlockLiteral *block_ptr_completionBlock;
			BlockLiteral block_completionBlock;
			block_completionBlock = new BlockLiteral ();
			block_ptr_completionBlock = &block_completionBlock;
			block_completionBlock.SetupBlock (Trampolines.SDWDCompletionBlock.Handler, completionBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("makePayment:withCompletion:"), payment.Handle, (IntPtr) block_ptr_completionBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("makePayment:withCompletion:"), payment.Handle, (IntPtr) block_ptr_completionBlock);
			}
			block_ptr_completionBlock->CleanupBlock ();
			
		}
		
		[Export ("makePayment:withStyle:withCompletion:")]
		[CompilerGenerated]
		public unsafe virtual void MakePayment (WDPayment payment, WDStyle style, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWDCompletionBlock))]WDCompletionBlock completionBlock)
		{
			if (payment == null)
				throw new ArgumentNullException ("payment");
			if (completionBlock == null)
				throw new ArgumentNullException ("completionBlock");
			BlockLiteral *block_ptr_completionBlock;
			BlockLiteral block_completionBlock;
			block_completionBlock = new BlockLiteral ();
			block_ptr_completionBlock = &block_completionBlock;
			block_completionBlock.SetupBlock (Trampolines.SDWDCompletionBlock.Handler, completionBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("makePayment:withStyle:withCompletion:"), payment.Handle, style == null ? IntPtr.Zero : style.Handle, (IntPtr) block_ptr_completionBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("makePayment:withStyle:withCompletion:"), payment.Handle, style == null ? IntPtr.Zero : style.Handle, (IntPtr) block_ptr_completionBlock);
			}
			block_ptr_completionBlock->CleanupBlock ();
			
		}
		
	} /* class WDClient */
}
