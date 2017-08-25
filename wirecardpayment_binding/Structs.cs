using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace wirecardpayment_binding
{
    [Native]
public enum WDLocale : long
{
    Undefined = 0,
    af,
    ar,
    az,
    be,
    bg,
    bn,
    ca,
    cs,
    cy,
    da,
    de,
    el,
    en,
    eo,
    es,
    et,
    eu,
    fa,
    fi,
    fr,
    ga,
    gl,
    gu,
    hi,
    hr,
    ht,
    hu,
    hy,
    id,
    @is,
    it,
    iw,
    ja,
    ka,
    kn,
    ko,
    la,
    lt,
    lv,
    mk,
    ms,
    mt,
    nl,
    no,
    pl,
    pt,
    ro,
    ru,
    sk,
    sl,
    sq,
    sr,
    sv,
    sw,
    ta,
    te,
    th,
    tl,
    tr,
    uk,
    ur,
    vi,
    yi,
    zh_CN,
    zh_TW,
    TotalNumber
}

[Native]
public enum WDErrorCode : long
{
    Ok = 0,
    General = -1,
    NetworkIssue = -2,
    TransactionFailure = -3,
    UnsupportedPaymentMethod = -4,
    InvalidPaymentData = -5,
    UserCanceled = -6,
    PaymentInProgress = -7,
    JailbrokenDevice = -8,
    UnsupportedGateway = -9
}

[Native]
public enum WDEnvironment : long
{
    Undefined = 0,
    Prod,
    SingaporePROD,
    TorontoPROD,
    Test = 100,
    SingaporeTEST,
    TorontoTEST,
    TotalNumber
}

[Native]
public enum WDCurrency : long
{
    Undefined = 0,
    Adp,
    Aed,
    Afn,
    All,
    Amd,
    Ang,
    Aoa,
    Ars,
    Aud,
    Awg,
    Azn,
    Bam,
    Bbd,
    Bdt,
    Bgn,
    Bhd,
    Bif,
    Bmd,
    Bnd,
    Bob,
    Brl,
    Bsd,
    Btn,
    Bwp,
    Byr,
    Bzd,
    Cad,
    Cdf,
    Chf,
    Clf,
    Clp,
    Cny,
    Cop,
    Crc,
    Cup,
    Cve,
    Cyp,
    Czk,
    Def,
    Djf,
    Dkk,
    Dop,
    Dzd,
    Eek,
    Egp,
    Ern,
    Etb,
    Eur,
    Fjd,
    Fkp,
    Gbp,
    Gel,
    Ggp,
    Ghs,
    Gip,
    Gmd,
    Gnf,
    Gtq,
    Gyd,
    Hkd,
    Hnl,
    Hrk,
    Htg,
    Huf,
    Idr,
    Ils,
    Imp,
    Inr,
    Iqd,
    Irr,
    Isk,
    Jep,
    Jmd,
    Jod,
    Jpy,
    Kes,
    Kgs,
    Khr,
    Kmf,
    Kpw,
    Krw,
    Kwd,
    Kyd,
    Kzt,
    Lak,
    Lbp,
    Lkr,
    Lrd,
    Lsl,
    Ltl,
    Lvl,
    Lyd,
    MM,
    Mad,
    Mdl,
    Mga,
    Mkd,
    Mmk,
    Mnt,
    Mop,
    Mro,
    Mtl,
    Mur,
    Mvr,
    Mwk,
    Mxn,
    Myr,
    Mzn,
    Nad,
    Ngn,
    Nio,
    Nok,
    Npr,
    Nzd,
    Omr,
    Pab,
    Pen,
    Pgk,
    Php,
    Pkr,
    Pln,
    Pyg,
    Qar,
    Ron,
    Rsd,
    Rub,
    Rwf,
    Sar,
    Sbd,
    Scr,
    Sdg,
    Sek,
    Sgd,
    Shp,
    Sll,
    Sos,
    Spl,
    Srd,
    Std,
    Svc,
    Syp,
    Szl,
    Thb,
    Tjs,
    Tmm,
    Tnd,
    Top,
    Try,
    Ttd,
    Tvd,
    Twd,
    Tzs,
    Uah,
    Ugx,
    Unk,
    Usd,
    Uyu,
    Uzs,
    Veb,
    Vef,
    Vnd,
    Vuv,
    Wst,
    Xaf,
    Xag,
    Xau,
    Xcd,
    Xdr,
    Xof,
    Xpd,
    Xpf,
    Xpt,
    Yer,
    Zar,
    Zmk,
    Zwd,
    TotalNumber
}

//static class CFunctions
//{
//    // extern NSString * WDCurrencyGetISOCode (WDCurrency currency);
//    [DllImport ("__Internal")]
//    //[Verify (PlatformInvoke)]
//    static extern NSString WDCurrencyGetISOCode (WDCurrency currency);

//    // extern WDCurrency WDCurrencyFromISOCode (NSString *code);
//    [DllImport ("__Internal")]
//    //[Verify (PlatformInvoke)]
//    static extern WDCurrency WDCurrencyFromISOCode (NSString code);

//    // extern NSString * WDCountryGetISOCode (WDCountry country);
//    [DllImport ("__Internal")]
//    //[Verify (PlatformInvoke)]
//    static extern NSString WDCountryGetISOCode (WDCountry country);

//    // extern WDCountry WDCountryFromISOCode (NSString *code);
//    [DllImport ("__Internal")]
//    //[Verify (PlatformInvoke)]
//    static extern WDCountry WDCountryFromISOCode (NSString code);

//    // extern WDTransactionType WDTransactionTypeFromCode (NSString *code);
//    [DllImport ("__Internal")]
//    //[Verify (PlatformInvoke)]
//    static extern WDTransactionType WDTransactionTypeFromCode (NSString code);

//    // extern NSString * WDTransactionTypeGetCode (WDTransactionType transactionType);
//    [DllImport ("__Internal")]
//    //[Verify (PlatformInvoke)]
//    static extern NSString WDTransactionTypeGetCode (WDTransactionType transactionType);

//    // extern WDCardBrand WDCardBrandFromCode (NSString *code);
//    [DllImport ("__Internal")]
//    //[Verify (PlatformInvoke)]
//    static extern WDCardBrand WDCardBrandFromCode (NSString code);

//    // extern NSString * WDCardBrandGetCode (WDCardBrand cardBrand);
//    [DllImport ("__Internal")]
//    //[Verify (PlatformInvoke)]
//    static extern NSString WDCardBrandGetCode (WDCardBrand cardBrand);

//    // extern WDAttempt WDAttemptThreeDFromCode (NSString *code);
//    [DllImport ("__Internal")]
//    //[Verify (PlatformInvoke)]
//    static extern WDAttempt WDAttemptThreeDFromCode (NSString code);

//    // extern NSString * WDAttemptThreeDGetCode (WDAttempt attempt);
//    [DllImport ("__Internal")]
//    //[Verify (PlatformInvoke)]
//    static extern NSString WDAttemptThreeDGetCode (WDAttempt attempt);
//}

[Native]
public enum WDCountry : long
{
    Undefined = 0,
    Ad,
    Ae,
    Af,
    Ag,
    Ai,
    Al,
    Am,
    An,
    Ao,
    Aq,
    Ar,
    As,
    At,
    Au,
    Aw,
    Ax,
    Az,
    Ba,
    Bb,
    Bd,
    Be,
    Bf,
    Bg,
    Bh,
    Bi,
    Bj,
    Bl,
    Bm,
    Bn,
    Bo,
    Bq,
    Br,
    Bs,
    Bt,
    Bv,
    Bw,
    By,
    Bz,
    Ca,
    Cc,
    Cd,
    Cf,
    Cg,
    Ch,
    Ci,
    Ck,
    Cl,
    Cm,
    Cn,
    Co,
    Cr,
    Cu,
    Cv,
    Cw,
    Cx,
    Cy,
    Cz,
    De,
    Dj,
    Dk,
    Dm,
    Do,
    Dz,
    Ec,
    Ee,
    Eg,
    Eh,
    Er,
    Es,
    Et,
    Fi,
    Fj,
    Fk,
    Fm,
    Fo,
    Fr,
    Ga,
    Gb,
    Gd,
    Ge,
    Gf,
    Gg,
    Gh,
    Gi,
    Gl,
    Gm,
    Gn,
    Gp,
    Gq,
    Gr,
    Gs,
    Gt,
    Gu,
    Gw,
    Gy,
    Hk,
    Hm,
    Hn,
    Hr,
    Hs,
    Ht,
    Hu,
    Id,
    Ie,
    Il,
    Im,
    In,
    Io,
    Iq,
    Ir,
    Is,
    It,
    Je,
    Jm,
    Jo,
    Jp,
    Ke,
    Kg,
    Kh,
    Ki,
    Km,
    Kn,
    Kp,
    Kr,
    Kw,
    Ky,
    Kz,
    La,
    Lb,
    Lc,
    Li,
    Lk,
    Lr,
    Ls,
    Lt,
    Lu,
    Lv,
    Ly,
    Ma,
    Mc,
    Md,
    Me,
    Mf,
    Mg,
    Mh,
    Mk,
    Ml,
    Mm,
    Mn,
    Mo,
    Mp,
    Mq,
    Mr,
    Ms,
    Mt,
    Mu,
    Mv,
    Mw,
    Mx,
    My,
    Mz,
    Na,
    Nc,
    Ne,
    Nf,
    Ng,
    Ni,
    Nl,
    No,
    Np,
    Nr,
    Nu,
    Nz,
    Om,
    Pa,
    Pe,
    Pf,
    Pg,
    Ph,
    Pk,
    Pl,
    Pm,
    Pn,
    Pr,
    Ps,
    Pt,
    Pw,
    Py,
    Qa,
    Re,
    Ro,
    Rs,
    Ru,
    Rw,
    Sa,
    Sb,
    Sc,
    Sd,
    Se,
    Sg,
    Sh,
    Si,
    Sj,
    Sk,
    Sl,
    Sm,
    Sn,
    So,
    Sr,
    Ss,
    St,
    Sv,
    Sx,
    Sy,
    Sz,
    Tc,
    Td,
    Tf,
    Tg,
    Th,
    Tj,
    Tk,
    Tl,
    Tm,
    Tn,
    To,
    Tr,
    Tt,
    Tv,
    Tw,
    Tz,
    Ua,
    Ug,
    Um,
    Us,
    Uy,
    Uz,
    Va,
    Vc,
    Ve,
    Vg,
    Vi,
    Vn,
    Vu,
    Wf,
    Ws,
    Xx,
    Ye,
    Yt,
    Za,
    Zm,
    Zw,
    TotalNumber
}

[Native]
public enum WDGender : long
{
    Undefined = 0,
    Male,
    Female,
    TotalNumber
}

[Native]
public enum WDTransactionState : long
{
    Undefined = 0,
    Success,
    Failed,
    InProgress,
    Repeated,
    TotalNumber
}

[Native]
public enum WDTransactionType : long
{
    Undefined = 0,
    Authorization,
    AuthorizationOnly,
    CaptureAuthorization,
    Debit,
    PendingDebit,
    Purchase,
    ReferencedAuthorization,
    ReferencedPurchase,
    RefundCapture,
    RefundDebit,
    RefundPurchase,
    Tokenize,
    VoidAuthorization,
    TotalNumber
}

[Native]
public enum WDCardBrand : long
{
    Undefined = 0,
    Amex,
    Cup,
    Diners,
    Discover,
    Jcb,
    Maestro,
    MasterCard,
    Mir,
    Uatp,
    UzCard,
    Visa,
    TotalNumber
}

[Native]
public enum WDCardFieldState : long
{
    CardInitial = 0,
    JailbrokenDevice,
    CardValid,
    CardUnsupported,
    NumberEditting,
    NumberIncomplete,
    NumberInvalid,
    NumberValid,
    MonthEditting,
    YearEditting,
    ExpirationDateIncomplete,
    ExpirationDateInvalid,
    ExpirationDateValid,
    SecurityCodeEditting,
    SecurityCodeIncomplete,
    SecurityCodeInvalid,
    SecurityCodeValid
}

[Native]
public enum WDPeriodicType : long
{
    Undefined = 0,
    Installment,
    Recurring,
    TotalNumber
}

[Native]
public enum WDSequenceType : long
{
    Undefined = 0,
    First,
    Recurring,
    Final,
    TotalNumber
}

[Native]
public enum WDAttempt : long
{
    Undefined = 0,
    Yes,
    No,
    TotalNumber
}

[Native]
public enum WDCardStyleLayout : long
{
    Default = 0,
    Animated
}

[Native]
public enum WDBool : long
{
    Undefined = 0,
    Yes,
    No,
    TotalNumber
}

}
