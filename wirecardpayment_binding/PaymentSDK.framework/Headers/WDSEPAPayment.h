//
//  WDSEPAPayment.h
//  PaymentSDK
//
//  Created by Sedlak, Stefan on 10/12/15.
//  Copyright © 2016 Wirecard Technologies GmbH. All rights reserved.
//

#import "WDPayment.h"
#import "WDPeriodic.h"
#import "WDBool.h"

/** @addtogroup ios_sdk
 *  @{
 */

/**
 * @brief Defines SEPA payment method.
 */
@interface WDSEPAPayment : WDPayment

/**
 @brief Setting this value to WDBoolYes means services and products are only available to businesses, the payer cannot be a private individual.
 */
@property (assign, nonatomic) WDBool B2B;

/**
 @brief The Creditor Id for the Merchant Account SEPA.
 @details It is mandatory.
 */
@property (strong, nonatomic, nonnull ) NSString *creditorID;

/**
 @brief The Mandate Id for the Mandate Transaction, generated by merchant.
 */
@property (strong, nonatomic, nonnull ) NSString *mandateID;
/**
 @brief The date that the Mandate was signed.
 @details If value is nil, current date will be used. It is optional.
 */
@property (strong, nonatomic, nullable) NSDate *mandateSignedDate;

/**
 @brief The date that the Mandate Transaction is due
 */
@property (strong, nonatomic, nullable) NSDate *dueDate;

/**
 @brief It describes recurring transactions.
 */
@property (strong, nonatomic, nullable) WDPeriodic *periodic;


- (nullable instancetype)initWithCreditor:(nonnull NSString *)creditorID
                               andMandate:(nonnull NSString *)mandateID NS_DESIGNATED_INITIALIZER;
- (nullable instancetype)init NS_UNAVAILABLE;

@end

/** @} */