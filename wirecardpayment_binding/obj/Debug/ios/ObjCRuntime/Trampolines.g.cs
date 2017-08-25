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

namespace ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::wirecardpayment_binding.WDCompletionBlock))]
		internal delegate void DWDCompletionBlock (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDWDCompletionBlock {
			static internal readonly DWDCompletionBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DWDCompletionBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::wirecardpayment_binding.WDCompletionBlock) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<wirecardpayment_binding.WDPaymentResponse> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDWDCompletionBlock */
		
		internal class NIDWDCompletionBlock {
			IntPtr blockPtr;
			DWDCompletionBlock invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDWDCompletionBlock (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DWDCompletionBlock> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDWDCompletionBlock ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::wirecardpayment_binding.WDCompletionBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::wirecardpayment_binding.WDCompletionBlock;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDWDCompletionBlock ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::wirecardpayment_binding.WDPaymentResponse arg0, NSError arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDWDCompletionBlock */
	}
}
