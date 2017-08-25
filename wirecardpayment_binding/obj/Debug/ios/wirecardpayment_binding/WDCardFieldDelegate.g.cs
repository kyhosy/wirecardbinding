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
	[Protocol (Name = "WDCardFieldDelegate", WrapperType = typeof (WDCardFieldDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidChangeState", Selector = "cardField:didChangeState:", ParameterType = new Type [] { typeof (wirecardpayment_binding.WDCardField), typeof (wirecardpayment_binding.WDCardFieldState) }, ParameterByRef = new bool [] { false, false })]
	public interface IWDCardFieldDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("cardField:didChangeState:")]
		[Preserve (Conditional = true)]
		void DidChangeState (WDCardField cardField, WDCardFieldState state);
		
	}
	
	internal sealed class WDCardFieldDelegateWrapper : BaseWrapper, IWDCardFieldDelegate {
		[Preserve (Conditional = true)]
		public WDCardFieldDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("cardField:didChangeState:")]
		[CompilerGenerated]
		public void DidChangeState (WDCardField cardField, WDCardFieldState state)
		{
			if (cardField == null)
				throw new ArgumentNullException ("cardField");
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_Int64 (this.Handle, Selector.GetHandle ("cardField:didChangeState:"), cardField.Handle, (Int64)state);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int (this.Handle, Selector.GetHandle ("cardField:didChangeState:"), cardField.Handle, (int)state);
			}
		}
		
	}
}
namespace wirecardpayment_binding {
	[Protocol]
	[Register("WDCardFieldDelegate", false)]
	[Model]
	public unsafe abstract partial class WDCardFieldDelegate : NSObject, IWDCardFieldDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected WDCardFieldDelegate () : base (NSObjectFlag.Empty)
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
		protected WDCardFieldDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal WDCardFieldDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("cardField:didChangeState:")]
		[CompilerGenerated]
		public abstract void DidChangeState (WDCardField cardField, WDCardFieldState state);
	} /* class WDCardFieldDelegate */
}
