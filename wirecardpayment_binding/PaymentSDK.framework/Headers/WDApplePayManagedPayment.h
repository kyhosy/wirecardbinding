//
//  WDApplePayManagedPayment.h
//  PaymentSDK
//
//  Created by Sedlak, Stefan on 10/31/15.
//  Copyright © 2016 Wirecard Technologies GmbH. All rights reserved.
//

#import "WDApplePayPayment.h"

/** @addtogroup ios_sdk
 *  @{
 */

/**
 @brief Defines ApplePay payment method.
 @details WDClient handles PKPaymentAuthorizationViewController. As it does not support complex use cases (shipping address selection, ...) it is intended for simple payments.I case of complex use cases handle PKPaymentAuthorizationViewController by your own and use WDApplePayPayment
 */
@interface WDApplePayManagedPayment : WDApplePayPayment

/**
 @brief Apple Merchant ID
 */
@property (copy, nonatomic, nonnull) NSString *appleMerchantID;
/**
 @brief Merchant's Country
 */
@property (assign, nonatomic) WDCountry merchantCountry;

/**
 @brief prompt user for billing address
 */
@property (assign, nonatomic) BOOL requiredBillingAddress;
/**
 @brief prompt user for shipping address
 */
@property (assign, nonatomic) BOOL requiredShippingAddress;

/**
 *  @brief Set of supported card brands.
 *  @details If supportedCardBrands is set SDK call canMakePayment and returns error WDErrorCodeUnsupportedPaymentMethod if card is unavailable. Set can contain NSNumbers with ::WDCardBrand values. Example:
 
 payment.supportedCardBrands = [NSSet setWithObjects:@(WDCardBrandAmex), @(WDCardBrandMasterCard), @(WDCardBrandVisa), nil];
 
 */
@property (copy, nonatomic, nullable) NSSet<NSNumber *> *supportedCardBrands;

/**
 @brief initialize object
 
 @param appleMerchantID Apple Merchant ID
 @param merchantCountry merchant's country
 
 @return initialized object
 */
- (nullable instancetype)initWithMerchant:(nonnull NSString *)appleMerchantID
                               andCountry:(WDCountry)merchantCountry NS_DESIGNATED_INITIALIZER;

- (nullable instancetype)initWithPayment:(nonnull PKPayment *)payment
                            summaryItems:(nonnull NSArray<PKPaymentSummaryItem *> *)summaryItems
                                currency:(WDCurrency)currency
                         transactionType:(WDTransactionType)transactionType NS_UNAVAILABLE;

- (nullable instancetype)initWithPayment:(nonnull PKPayment *)payment
                   summaryItems:(nonnull NSArray<PKPaymentSummaryItem *> *)summaryItems
                 currencyString:(nonnull NSString *)currency
                transactionType:(WDTransactionType)transactionType NS_UNAVAILABLE;

- (nullable instancetype)init NS_UNAVAILABLE;

@end

/** @} */
