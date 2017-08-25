using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;
using PassKit;

namespace wirecardpayment_binding
{
	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     CGPoint Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/
	//
	//[Static]
	//[Verify(ConstantsInterfaceAssociation)]
	//partial interface Constants
	//{
	//	// extern double PaymentSDKVersionNumber;
	//	[Field("PaymentSDKVersionNumber", "__Internal")]
	//	double PaymentSDKVersionNumber { get; }

	//	// extern const unsigned char [] PaymentSDKVersionString;
	//	[Field("PaymentSDKVersionString", "__Internal")]
	//	byte[] PaymentSDKVersionString { get; }

	//	// extern NSString *const PaymentSDKVersion;
	//	[Field("PaymentSDKVersion", "__Internal")]
	//	NSString PaymentSDKVersion { get; }

	//	// extern NSString *const PaymentSDKVersionCommit;
	//	[Field("PaymentSDKVersionCommit", "__Internal")]
	//	NSString PaymentSDKVersionCommit { get; }
	//}

	//[Static]
	//[Verify(ConstantsInterfaceAssociation)]
	//partial interface Constants
	//{
	//	// extern NSString *const _Nonnull WDPaymentSDKErrorDomain;
	//	[Field("WDPaymentSDKErrorDomain", "__Internal")]
	//	NSString WDPaymentSDKErrorDomain { get; }
	//}

	// @interface WDUtils (NSError)
	[Category]
	[BaseType(typeof(NSError))]
	interface NSError_WDUtils
	{
		// +(instancetype _Nullable)wd_errorWithCode:(WDErrorCode)code andLocale:(WDLocale)locale;
		[Static]
		[Export("wd_errorWithCode:andLocale:")]
		[return: NullAllowed]
		NSError Wd_errorWithCode(WDErrorCode code, WDLocale locale);

		// +(instancetype _Nullable)wd_errorWithCode:(WDErrorCode)code andLocalizedDescription:(NSString * _Nonnull)localizedDescription;
		[Static]
		[Export("wd_errorWithCode:andLocalizedDescription:")]
		[return: NullAllowed]
		NSError Wd_errorWithCode(WDErrorCode code, string localizedDescription);
	}

	// @interface WDAddress : NSObject
	[BaseType(typeof(NSObject))]
	interface WDAddress
	{
		// @property (nonatomic, strong) NSString * _Nonnull street1;
		[Export("street1", ArgumentSemantic.Strong)]
		string Street1 { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable street2;
		[NullAllowed, Export("street2", ArgumentSemantic.Strong)]
		string Street2 { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull city;
		[Export("city", ArgumentSemantic.Strong)]
		string City { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable state;
		[NullAllowed, Export("state", ArgumentSemantic.Strong)]
		string State { get; set; }

		// @property (assign, nonatomic) WDCountry country;
		[Export("country", ArgumentSemantic.Assign)]
		WDCountry Country { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable postalCode;
		[NullAllowed, Export("postalCode", ArgumentSemantic.Strong)]
		string PostalCode { get; set; }
	}

	// @interface WDCustomerData : NSObject
	[BaseType(typeof(NSObject))]
	interface WDCustomerData
	{
		// @property (nonatomic, strong) NSString * _Nullable firstName;
		[NullAllowed, Export("firstName", ArgumentSemantic.Strong)]
		string FirstName { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull lastName;
		[Export("lastName", ArgumentSemantic.Strong)]
		string LastName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable email;
		[NullAllowed, Export("email", ArgumentSemantic.Strong)]
		string Email { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable phone;
		[NullAllowed, Export("phone", ArgumentSemantic.Strong)]
		string Phone { get; set; }

		// @property (assign, nonatomic) WDGender gender;
		[Export("gender", ArgumentSemantic.Assign)]
		WDGender Gender { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable dateOfBirth;
		[NullAllowed, Export("dateOfBirth", ArgumentSemantic.Strong)]
		NSDate DateOfBirth { get; set; }

		// @property (nonatomic, strong) WDAddress * _Nullable address;
		[NullAllowed, Export("address", ArgumentSemantic.Strong)]
		WDAddress Address { get; set; }
	}

	// @interface WDNotification : NSObject
	[BaseType(typeof(NSObject))]
	interface WDNotification
	{
		// @property (assign, nonatomic) WDTransactionState transactionState;
		[Export("transactionState", ArgumentSemantic.Assign)]
		WDTransactionState TransactionState { get; set; }

		// @property (nonatomic, strong) NSURL * _Nonnull URL;
		[Export("URL", ArgumentSemantic.Strong)]
		NSUrl URL { get; set; }
	}

	// @interface WDOrderItem : NSObject
	[BaseType(typeof(NSObject))]
	interface WDOrderItem
	{
		// @property (nonatomic, strong) NSString * name;
		[Export("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) NSString * itemDescription;
		[Export("itemDescription", ArgumentSemantic.Strong)]
		string ItemDescription { get; set; }

		// @property (nonatomic, strong) NSString * articleNumber;
		[Export("articleNumber", ArgumentSemantic.Strong)]
		string ArticleNumber { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * amount;
		[Export("amount", ArgumentSemantic.Strong)]
		NSDecimalNumber Amount { get; set; }

		// @property (assign, nonatomic) WDCurrency amountCurrency;
		[Export("amountCurrency", ArgumentSemantic.Assign)]
		WDCurrency AmountCurrency { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * taxAmount;
		[Export("taxAmount", ArgumentSemantic.Strong)]
		NSDecimalNumber TaxAmount { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * quantity;
		[Export("quantity", ArgumentSemantic.Strong)]
		NSDecimalNumber Quantity { get; set; }
	}

	// @interface WDOrder : NSObject
	[BaseType(typeof(NSObject))]
	interface WDOrder
	{
		// @property (nonatomic, strong) NSString * _Nullable descriptor;
		[NullAllowed, Export("descriptor", ArgumentSemantic.Strong)]
		string Descriptor { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable number;
		[NullAllowed, Export("number", ArgumentSemantic.Strong)]
		string Number { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSArray<WDOrderItem *> * _Nullable items;
		[NullAllowed, Export("items", ArgumentSemantic.Strong)]
		WDOrderItem[] Items { get; set; }
	}

	// @interface WDPayment : NSObject
	[BaseType(typeof(NSObject))]
	interface WDPayment
	{
		// @property (nonatomic, strong) NSString * _Nonnull requestSignature;
		[Export("requestSignature", ArgumentSemantic.Strong)]
		string RequestSignature { get; set; }

		// @property (nonatomic, strong) NSDate * _Nonnull requestTimestamp;
		[Export("requestTimestamp", ArgumentSemantic.Strong)]
		NSDate RequestTimestamp { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull signature;
		[Export("signature")]
		string Signature { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull merchantAccountID;
		[Export("merchantAccountID", ArgumentSemantic.Strong)]
		string MerchantAccountID { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable merchantAccountResolverCategory;
		[NullAllowed, Export("merchantAccountResolverCategory", ArgumentSemantic.Strong)]
		string MerchantAccountResolverCategory { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull requestID;
		[Export("requestID", ArgumentSemantic.Strong)]
		string RequestID { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * _Nullable amount;
		[NullAllowed, Export("amount", ArgumentSemantic.Strong)]
		NSDecimalNumber Amount { get; set; }

		// @property (assign, nonatomic) WDCurrency amountCurrency __attribute__((deprecated("")));
		[Export("amountCurrency", ArgumentSemantic.Assign)]
		WDCurrency AmountCurrency { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull currency;
		[Export("currency", ArgumentSemantic.Strong)]
		string Currency { get; set; }

		// @property (assign, nonatomic) WDTransactionType transactionType;
		[Export("transactionType", ArgumentSemantic.Assign)]
		WDTransactionType TransactionType { get; set; }

		// @property (nonatomic, strong) WDCustomerData * _Nullable accountHolder;
		[NullAllowed, Export("accountHolder", ArgumentSemantic.Strong)]
		WDCustomerData AccountHolder { get; set; }

		// @property (nonatomic, strong) WDCustomerData * _Nullable shipping;
		[NullAllowed, Export("shipping", ArgumentSemantic.Strong)]
		WDCustomerData Shipping { get; set; }

		// @property (nonatomic, strong) WDOrder * _Nullable order;
		[NullAllowed, Export("order", ArgumentSemantic.Strong)]
		WDOrder Order { get; set; }

		// @property (nonatomic, strong) NSArray<WDNotification *> * _Nullable notifications;
		[NullAllowed, Export("notifications", ArgumentSemantic.Strong)]
		WDNotification[] Notifications { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable IPAddress;
		[NullAllowed, Export("IPAddress", ArgumentSemantic.Strong)]
		string IPAddress { get; set; }

		// @property (assign, nonatomic) WDLocale locale;
		[Export("locale", ArgumentSemantic.Assign)]
		WDLocale Locale { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable parentTransactionID;
		[NullAllowed, Export("parentTransactionID", ArgumentSemantic.Strong)]
		string ParentTransactionID { get; set; }

		// -(WDNotification * _Nullable)notificationForState:(WDTransactionState)state;
		[Export("notificationForState:")]
		[return: NullAllowed]
		WDNotification NotificationForState(WDTransactionState state);
	}

	// @interface WDCard : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface WDCard : INSCopying
	{
		// @property (copy, nonatomic) NSDate * _Nullable expiryDate;
		[NullAllowed, Export("expiryDate", ArgumentSemantic.Copy)]
		NSDate ExpiryDate { get; set; }

		// @property (assign, nonatomic) WDCardBrand brand;
		[Export("brand", ArgumentSemantic.Assign)]
		WDCardBrand Brand { get; set; }
	}

	// @interface WDCardToken : NSObject
	[BaseType(typeof(NSObject))]
	interface WDCardToken
	{
		// @property (nonatomic, strong) NSString * _Nullable tokenID;
		[NullAllowed, Export("tokenID", ArgumentSemantic.Strong)]
		string TokenID { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable maskedAccountNumber;
		[NullAllowed, Export("maskedAccountNumber", ArgumentSemantic.Strong)]
		string MaskedAccountNumber { get; set; }
	}

	// @interface WDPaymentResponse : WDPayment
	[BaseType(typeof(WDPayment))]
	interface WDPaymentResponse
	{
		// @property (assign, nonatomic) WDTransactionState transactionState;
		[Export("transactionState", ArgumentSemantic.Assign)]
		WDTransactionState TransactionState { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable transactionIdentifier;
		[NullAllowed, Export("transactionIdentifier", ArgumentSemantic.Strong)]
		string TransactionIdentifier { get; set; }

		// @property (nonatomic, strong) WDCard * _Nullable card;
		[NullAllowed, Export("card", ArgumentSemantic.Strong)]
		WDCard Card { get; set; }

		// @property (nonatomic, strong) WDCardToken * _Nullable cardToken;
		[NullAllowed, Export("cardToken", ArgumentSemantic.Strong)]
		WDCardToken CardToken { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable statusMessage;
		[NullAllowed, Export("statusMessage", ArgumentSemantic.Strong)]
		string StatusMessage { get; set; }
	}

	// typedef void (^WDCompletionBlock)(WDPaymentResponse * _Nullable, NSError * _Nullable);
	delegate void WDCompletionBlock([NullAllowed] WDPaymentResponse arg0, [NullAllowed] NSError arg1);

	// @interface WDClient : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface WDClient
	{
		// -(instancetype _Nullable)initWithEnvironment:(WDEnvironment)environment;
		[Export("initWithEnvironment:")]
		IntPtr Constructor(WDEnvironment environment);

		// -(instancetype _Nullable)initWithEnvironment:(WDEnvironment)environment error:(NSError * _Nullable * _Nullable)error;
		[Export("initWithEnvironment:error:")]
		IntPtr Constructor(WDEnvironment environment, [NullAllowed] out NSError error);

		// -(instancetype _Nullable)initWithHostname:(NSString * _Nonnull)hostname error:(NSError * _Nullable * _Nullable)error __attribute__((objc_designated_initializer));
		[Export("initWithHostname:error:")]
		[DesignatedInitializer]
		IntPtr Constructor(string hostname, [NullAllowed] out NSError error);

		// -(void)makePayment:(WDPayment * _Nonnull)payment withCompletion:(WDCompletionBlock _Nonnull)completionBlock;
		[Export("makePayment:withCompletion:")]
		void MakePayment(WDPayment payment, WDCompletionBlock completionBlock);

		// -(void)makePayment:(WDPayment * _Nonnull)payment withStyle:(WDStyle * _Nullable)style withCompletion:(WDCompletionBlock _Nonnull)completionBlock;
		[Export("makePayment:withStyle:withCompletion:")]
		void MakePayment(WDPayment payment, [NullAllowed] WDStyle style, WDCompletionBlock completionBlock);

		// -(void)checkPayment:(WDPayment * _Nonnull)payment withCompletion:(WDCompletionBlock _Nonnull)completionBlock;
		[Export("checkPayment:withCompletion:")]
		void CheckPayment(WDPayment payment, WDCompletionBlock completionBlock);
	}

	// @interface WDAlipayPayment : WDPayment
	[BaseType(typeof(WDPayment))]
	[DisableDefaultCtor]
	interface WDAlipayPayment
	{
		// -(instancetype _Nullable)initWithAmount:(NSDecimalNumber * _Nonnull)amount currency:(WDCurrency)currency __attribute__((objc_designated_initializer));
		[Export("initWithAmount:currency:")]
		[DesignatedInitializer]
		IntPtr Constructor(NSDecimalNumber amount, WDCurrency currency);

		// -(instancetype _Nullable)initWithAmount:(NSDecimalNumber * _Nonnull)amount currencyString:(NSString * _Nonnull)currency __attribute__((objc_designated_initializer));
		[Export("initWithAmount:currencyString:")]
		[DesignatedInitializer]
		IntPtr Constructor(NSDecimalNumber amount, string currency);
	}

	// @interface WDApplePayPayment : WDPayment
	[BaseType(typeof(WDPayment))]
	interface WDApplePayPayment
	{
		// -(instancetype _Nullable)initWithPayment:(PKPayment * _Nonnull)payment summaryItems:(NSArray<PKPaymentSummaryItem *> * _Nonnull)summaryItems currency:(WDCurrency)currency transactionType:(WDTransactionType)transactionType __attribute__((objc_designated_initializer));
		[Export("initWithPayment:summaryItems:currency:transactionType:")]
		[DesignatedInitializer]
		IntPtr Constructor(PKPayment payment, PKPaymentSummaryItem[] summaryItems, WDCurrency currency, WDTransactionType transactionType);

		// -(instancetype _Nullable)initWithPayment:(PKPayment * _Nonnull)payment summaryItems:(NSArray<PKPaymentSummaryItem *> * _Nonnull)summaryItems currencyString:(NSString * _Nonnull)currency transactionType:(WDTransactionType)transactionType __attribute__((objc_designated_initializer));
		[Export("initWithPayment:summaryItems:currencyString:transactionType:")]
		[DesignatedInitializer]
		IntPtr Constructor(PKPayment payment, PKPaymentSummaryItem[] summaryItems, string currency, WDTransactionType transactionType);
	}

	// @interface WDApplePayManagedPayment : WDApplePayPayment
	[BaseType(typeof(WDApplePayPayment))]
	[DisableDefaultCtor]
	interface WDApplePayManagedPayment
	{
		// @property (copy, nonatomic) NSString * _Nonnull appleMerchantID;
		[Export("appleMerchantID")]
		string AppleMerchantID { get; set; }

		// @property (assign, nonatomic) WDCountry merchantCountry;
		[Export("merchantCountry", ArgumentSemantic.Assign)]
		WDCountry MerchantCountry { get; set; }

		// @property (assign, nonatomic) BOOL requiredBillingAddress;
		[Export("requiredBillingAddress")]
		bool RequiredBillingAddress { get; set; }

		// @property (assign, nonatomic) BOOL requiredShippingAddress;
		[Export("requiredShippingAddress")]
		bool RequiredShippingAddress { get; set; }

		// @property (copy, nonatomic) NSSet<NSNumber *> * _Nullable supportedCardBrands;
		[NullAllowed, Export("supportedCardBrands", ArgumentSemantic.Copy)]
		NSSet<NSNumber> SupportedCardBrands { get; set; }

		// -(instancetype _Nullable)initWithMerchant:(NSString * _Nonnull)appleMerchantID andCountry:(WDCountry)merchantCountry __attribute__((objc_designated_initializer));
		[Export("initWithMerchant:andCountry:")]
		[DesignatedInitializer]
		IntPtr Constructor(string appleMerchantID, WDCountry merchantCountry);
	}

	// @protocol WDCardFieldDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface WDCardFieldDelegate
	{
		// @required -(void)cardField:(WDCardField * _Nonnull)cardField didChangeState:(WDCardFieldState)state;
		[Abstract]
		[Export("cardField:didChangeState:")]
		void DidChangeState(WDCardField cardField, WDCardFieldState state);
	}

	// @interface WDCardField : UIControl
	[BaseType(typeof(UIControl))]
	interface WDCardField
	{
		[Wrap("WeakDelegate")]
		[NullAllowed]
		WDCardFieldDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<WDCardFieldDelegate> _Nullable delegate __attribute__((iboutlet));
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (copy, nonatomic) WDCard * _Null_unspecified card;
		[Export("card", ArgumentSemantic.Copy)]
		WDCard Card { get; set; }

		// @property (getter = isCardBrandHidden, nonatomic) BOOL cardBrandHidden;
		[Export("cardBrandHidden")]
		bool CardBrandHidden { [Bind("isCardBrandHidden")] get; set; }

		// @property (nonatomic) BOOL scanButtonHidden;
		[Export("scanButtonHidden")]
		bool ScanButtonHidden { get; set; }

		// @property (nonatomic, strong) WDCardPayment * _Nonnull cardPayment;
		[Export("cardPayment", ArgumentSemantic.Strong)]
		WDCardPayment CardPayment { get; set; }

		// @property (copy, nonatomic) UIColor * _Null_unspecified cursorColor __attribute__((annotate("ui_appearance_selector")));
		[Export("cursorColor", ArgumentSemantic.Copy)]
		UIColor CursorColor { get; set; }

		// @property (copy, nonatomic) UIFont * _Null_unspecified font;
		[Export("font", ArgumentSemantic.Copy)]
		UIFont Font { get; set; }

		// @property (assign, nonatomic) UIKeyboardAppearance keyboardAppearance __attribute__((annotate("ui_appearance_selector")));
		[Export("keyboardAppearance", ArgumentSemantic.Assign)]
		UIKeyboardAppearance KeyboardAppearance { get; set; }

		// @property (nonatomic) WDLocale locale;
		[Export("locale", ArgumentSemantic.Assign)]
		WDLocale Locale { get; set; }

		// @property (copy, nonatomic) UIColor * _Null_unspecified placeholderColor;
		[Export("placeholderColor", ArgumentSemantic.Copy)]
		UIColor PlaceholderColor { get; set; }

		// @property (copy, nonatomic) UIColor * _Null_unspecified textColor;
		[Export("textColor", ArgumentSemantic.Copy)]
		UIColor TextColor { get; set; }

		// @property (copy, nonatomic) UIColor * _Null_unspecified textErrorColor;
		[Export("textErrorColor", ArgumentSemantic.Copy)]
		UIColor TextErrorColor { get; set; }

		// @property (copy, nonatomic) NSString * _Null_unspecified numberPlaceholder;
		[Export("numberPlaceholder")]
		string NumberPlaceholder { get; set; }

		// @property (copy, nonatomic) NSString * _Null_unspecified expirationMonthPlaceholder;
		[Export("expirationMonthPlaceholder")]
		string ExpirationMonthPlaceholder { get; set; }

		// @property (copy, nonatomic) NSString * _Null_unspecified expirationYearPlaceholder;
		[Export("expirationYearPlaceholder")]
		string ExpirationYearPlaceholder { get; set; }

		// @property (copy, nonatomic) NSString * _Null_unspecified securityCodePlaceholder;
		[Export("securityCodePlaceholder")]
		string SecurityCodePlaceholder { get; set; }

		// @property (copy, nonatomic) NSSet<NSNumber *> * _Nullable supportedCardBrands;
		[NullAllowed, Export("supportedCardBrands", ArgumentSemantic.Copy)]
		NSSet<NSNumber> SupportedCardBrands { get; set; }

		// @property (readonly, getter = isValid, nonatomic) BOOL valid;
		[Export("valid")]
		bool Valid { [Bind("isValid")] get; }

		// -(void)clear;
		[Export("clear")]
		void Clear();
	}

	// @interface WDPeriodic : NSObject
	[BaseType(typeof(NSObject))]
	interface WDPeriodic
	{
		// @property (assign, nonatomic) WDPeriodicType periodicType;
		[Export("periodicType", ArgumentSemantic.Assign)]
		WDPeriodicType PeriodicType { get; set; }

		// @property (assign, nonatomic) WDSequenceType sequenceType;
		[Export("sequenceType", ArgumentSemantic.Assign)]
		WDSequenceType SequenceType { get; set; }
	}

	// @interface WDSubMerchantInfo : NSObject
	[BaseType(typeof(NSObject))]
	interface WDSubMerchantInfo
	{
		// @property (nonatomic, strong) NSString * city;
		[Export("city", ArgumentSemantic.Strong)]
		string City { get; set; }

		// @property (assign, nonatomic) WDCountry country;
		[Export("country", ArgumentSemantic.Assign)]
		WDCountry Country { get; set; }

		// @property (nonatomic, strong) NSString * identifier;
		[Export("identifier", ArgumentSemantic.Strong)]
		string Identifier { get; set; }

		// @property (nonatomic, strong) NSString * name;
		[Export("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) NSString * postalCode;
		[Export("postalCode", ArgumentSemantic.Strong)]
		string PostalCode { get; set; }

		// @property (nonatomic, strong) NSString * state;
		[Export("state", ArgumentSemantic.Strong)]
		string State { get; set; }

		// @property (nonatomic, strong) NSString * street;
		[Export("street", ArgumentSemantic.Strong)]
		string Street { get; set; }
	}

	// @interface WDCardPayment : WDPayment
	[BaseType(typeof(WDPayment))]
	[DisableDefaultCtor]
	interface WDCardPayment
	{
		// @property (assign, nonatomic) WDAttempt attemptThreeD;
		[Export("attemptThreeD", ArgumentSemantic.Assign)]
		WDAttempt AttemptThreeD { get; set; }

		// @property (getter = isRecurring, assign, nonatomic) BOOL recurring;
		[Export("recurring")]
		bool Recurring { [Bind("isRecurring")] get; set; }

		// @property (getter = isSecurityCodeRequired, assign, nonatomic) BOOL requireSecurityCode;
		[Export("requireSecurityCode")]
		bool RequireSecurityCode { [Bind("isSecurityCodeRequired")] get; set; }

		// @property (nonatomic, strong) WDCardToken * _Nullable token;
		[NullAllowed, Export("token", ArgumentSemantic.Strong)]
		WDCardToken Token { get; set; }

		// @property (nonatomic, strong) WDSubMerchantInfo * _Nullable subMerchantInfo;
		[NullAllowed, Export("subMerchantInfo", ArgumentSemantic.Strong)]
		WDSubMerchantInfo SubMerchantInfo { get; set; }

		// -(instancetype _Nullable)initWithAmount:(NSDecimalNumber * _Nonnull)amount amountCurrency:(WDCurrency)amountCurrency transactionType:(WDTransactionType)transactionType __attribute__((objc_designated_initializer));
		[Export("initWithAmount:amountCurrency:transactionType:")]
		[DesignatedInitializer]
		IntPtr Constructor(NSDecimalNumber amount, WDCurrency amountCurrency, WDTransactionType transactionType);

		// -(instancetype _Nullable)initWithAmount:(NSDecimalNumber * _Nonnull)amount currencyString:(NSString * _Nonnull)currency transactionType:(WDTransactionType)transactionType __attribute__((objc_designated_initializer));
		[Export("initWithAmount:currencyString:transactionType:")]
		[DesignatedInitializer]
		IntPtr Constructor(NSDecimalNumber amount, string currency, WDTransactionType transactionType);
	}

	// @interface WDStyle : NSObject
	[BaseType(typeof(NSObject))]
	interface WDStyle
	{
		// @property (assign, nonatomic) WDLocale locale;
		[Export("locale", ArgumentSemantic.Assign)]
		WDLocale Locale { get; set; }
	}

	// @interface WDBaseStyle : WDStyle
	[BaseType(typeof(WDStyle))]
	interface WDBaseStyle
	{
		// @property (nonatomic, strong) UIView * mainViewStyled;
		[Export("mainViewStyled", ArgumentSemantic.Strong)]
		UIView MainViewStyled { get; set; }

		// @property (nonatomic, strong) UIView * headerViewStyled;
		[Export("headerViewStyled", ArgumentSemantic.Strong)]
		UIView HeaderViewStyled { get; set; }

		// @property (nonatomic, strong) UILabel * headerLabelStyled;
		[Export("headerLabelStyled", ArgumentSemantic.Strong)]
		UILabel HeaderLabelStyled { get; set; }

		// @property (nonatomic, strong) NSString * headerLabelText;
		[Export("headerLabelText", ArgumentSemantic.Strong)]
		string HeaderLabelText { get; set; }

		// @property (nonatomic, strong) UIButton * cancelButtonStyled;
		[Export("cancelButtonStyled", ArgumentSemantic.Strong)]
		UIButton CancelButtonStyled { get; set; }

		// @property (copy, nonatomic) NSString * cancelButtonTitle;
		[Export("cancelButtonTitle")]
		string CancelButtonTitle { get; set; }
	}

	// @interface WDNativeStyle : WDBaseStyle
	[BaseType(typeof(WDBaseStyle))]
	interface WDNativeStyle
	{
		// @property (nonatomic, strong) UILabel * orderLabelStyled;
		[Export("orderLabelStyled", ArgumentSemantic.Strong)]
		UILabel OrderLabelStyled { get; set; }

		// @property (copy, nonatomic) NSString * orderLabelText;
		[Export("orderLabelText")]
		string OrderLabelText { get; set; }

		// @property (nonatomic, strong) UILabel * labelStyled;
		[Export("labelStyled", ArgumentSemantic.Strong)]
		UILabel LabelStyled { get; set; }

		// @property (nonatomic, strong) UITextField * textFieldStyled;
		[Export("textFieldStyled", ArgumentSemantic.Strong)]
		UITextField TextFieldStyled { get; set; }

		// @property (nonatomic, strong) UITextView * textViewStyled;
		[Export("textViewStyled", ArgumentSemantic.Strong)]
		UITextView TextViewStyled { get; set; }

		// @property (nonatomic, strong) UIButton * submitButtonStyled;
		[Export("submitButtonStyled", ArgumentSemantic.Strong)]
		UIButton SubmitButtonStyled { get; set; }

		// @property (copy, nonatomic) NSString * submitButtonTitle;
		[Export("submitButtonTitle")]
		string SubmitButtonTitle { get; set; }

		// @property (nonatomic, strong) UIView * underlineViewStyled;
		[Export("underlineViewStyled", ArgumentSemantic.Strong)]
		UIView UnderlineViewStyled { get; set; }
	}

	// @interface WDCardStyle : WDNativeStyle
	[BaseType(typeof(WDNativeStyle))]
	interface WDCardStyle
	{
		// @property (nonatomic, strong) NSString * cardholderPlaceholder;
		[Export("cardholderPlaceholder", ArgumentSemantic.Strong)]
		string CardholderPlaceholder { get; set; }

		// @property (nonatomic, strong) NSString * cardNumberPlaceholder;
		[Export("cardNumberPlaceholder", ArgumentSemantic.Strong)]
		string CardNumberPlaceholder { get; set; }

		// @property (nonatomic, strong) NSString * expiryDatePlaceholder;
		[Export("expiryDatePlaceholder", ArgumentSemantic.Strong)]
		string ExpiryDatePlaceholder { get; set; }

		// @property (nonatomic, strong) NSString * securityCodePlaceholder;
		[Export("securityCodePlaceholder", ArgumentSemantic.Strong)]
		string SecurityCodePlaceholder { get; set; }

		// @property (nonatomic, strong) NSString * scanTitle;
		[Export("scanTitle", ArgumentSemantic.Strong)]
		string ScanTitle { get; set; }

		// @property (nonatomic) BOOL scanButtonHidden;
		[Export("scanButtonHidden")]
		bool ScanButtonHidden { get; set; }

		// @property (assign, nonatomic) WDCardStyleLayout layout;
		[Export("layout", ArgumentSemantic.Assign)]
		WDCardStyleLayout Layout { get; set; }

		// @property (nonatomic, strong) NSSet<NSNumber *> * supportedCardBrands;
		[Export("supportedCardBrands", ArgumentSemantic.Strong)]
		NSSet<NSNumber> SupportedCardBrands { get; set; }
	}

	// @interface WDPayPalPayment : WDPayment
	[BaseType(typeof(WDPayment))]
	[DisableDefaultCtor]
	interface WDPayPalPayment
	{
		// @property (nonatomic, strong) WDPeriodic * _Nullable periodic;
		[NullAllowed, Export("periodic", ArgumentSemantic.Strong)]
		WDPeriodic Periodic { get; set; }

		// -(instancetype _Nullable)initWithAmount:(NSDecimalNumber * _Nonnull)amount currency:(WDCurrency)currency __attribute__((objc_designated_initializer));
		[Export("initWithAmount:currency:")]
		[DesignatedInitializer]
		IntPtr Constructor(NSDecimalNumber amount, WDCurrency currency);

		// -(instancetype _Nullable)initWithAmount:(NSDecimalNumber * _Nonnull)amount currencyString:(NSString * _Nonnull)currency __attribute__((objc_designated_initializer));
		[Export("initWithAmount:currencyString:")]
		[DesignatedInitializer]
		IntPtr Constructor(NSDecimalNumber amount, string currency);
	}

	// @interface WDSEPAPayment : WDPayment
	[BaseType(typeof(WDPayment))]
	[DisableDefaultCtor]
	interface WDSEPAPayment
	{
		// @property (assign, nonatomic) WDBool B2B;
		[Export("B2B", ArgumentSemantic.Assign)]
		WDBool B2B { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull creditorID;
		[Export("creditorID", ArgumentSemantic.Strong)]
		string CreditorID { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull mandateID;
		[Export("mandateID", ArgumentSemantic.Strong)]
		string MandateID { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable mandateSignedDate;
		[NullAllowed, Export("mandateSignedDate", ArgumentSemantic.Strong)]
		NSDate MandateSignedDate { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable dueDate;
		[NullAllowed, Export("dueDate", ArgumentSemantic.Strong)]
		NSDate DueDate { get; set; }

		// @property (nonatomic, strong) WDPeriodic * _Nullable periodic;
		[NullAllowed, Export("periodic", ArgumentSemantic.Strong)]
		WDPeriodic Periodic { get; set; }

		// -(instancetype _Nullable)initWithCreditor:(NSString * _Nonnull)creditorID andMandate:(NSString * _Nonnull)mandateID __attribute__((objc_designated_initializer));
		[Export("initWithCreditor:andMandate:")]
		[DesignatedInitializer]
		IntPtr Constructor(string creditorID, string mandateID);
	}

	// @interface WDSEPAStyle : WDNativeStyle
	[BaseType(typeof(WDNativeStyle))]
	interface WDSEPAStyle
	{
		// @property (nonatomic, strong) NSString * firstNamePlaceholder;
		[Export("firstNamePlaceholder", ArgumentSemantic.Strong)]
		string FirstNamePlaceholder { get; set; }

		// @property (nonatomic, strong) NSString * lastNamePlaceholder;
		[Export("lastNamePlaceholder", ArgumentSemantic.Strong)]
		string LastNamePlaceholder { get; set; }

		// @property (nonatomic, strong) NSString * IBANPlaceholder;
		[Export("IBANPlaceholder", ArgumentSemantic.Strong)]
		string IBANPlaceholder { get; set; }

		// @property (nonatomic, strong) NSString * merchantName;
		[Export("merchantName", ArgumentSemantic.Strong)]
		string MerchantName { get; set; }

		// @property (nonatomic, strong) UISwitch * switchStyled;
		[Export("switchStyled", ArgumentSemantic.Strong)]
		UISwitch SwitchStyled { get; set; }
	}
}
