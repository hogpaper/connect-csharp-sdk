/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Square.Connect.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class V1Money :  IEquatable<V1Money>, IValidatableObject
    {
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CurrencyCodeEnum
        {
            
            /// <summary>
            /// Enum AED for "AED"
            /// </summary>
            [EnumMember(Value = "AED")]
            AED,
            
            /// <summary>
            /// Enum AFN for "AFN"
            /// </summary>
            [EnumMember(Value = "AFN")]
            AFN,
            
            /// <summary>
            /// Enum ALL for "ALL"
            /// </summary>
            [EnumMember(Value = "ALL")]
            ALL,
            
            /// <summary>
            /// Enum AMD for "AMD"
            /// </summary>
            [EnumMember(Value = "AMD")]
            AMD,
            
            /// <summary>
            /// Enum ANG for "ANG"
            /// </summary>
            [EnumMember(Value = "ANG")]
            ANG,
            
            /// <summary>
            /// Enum AOA for "AOA"
            /// </summary>
            [EnumMember(Value = "AOA")]
            AOA,
            
            /// <summary>
            /// Enum ARS for "ARS"
            /// </summary>
            [EnumMember(Value = "ARS")]
            ARS,
            
            /// <summary>
            /// Enum AUD for "AUD"
            /// </summary>
            [EnumMember(Value = "AUD")]
            AUD,
            
            /// <summary>
            /// Enum AWG for "AWG"
            /// </summary>
            [EnumMember(Value = "AWG")]
            AWG,
            
            /// <summary>
            /// Enum AZN for "AZN"
            /// </summary>
            [EnumMember(Value = "AZN")]
            AZN,
            
            /// <summary>
            /// Enum BAM for "BAM"
            /// </summary>
            [EnumMember(Value = "BAM")]
            BAM,
            
            /// <summary>
            /// Enum BBD for "BBD"
            /// </summary>
            [EnumMember(Value = "BBD")]
            BBD,
            
            /// <summary>
            /// Enum BDT for "BDT"
            /// </summary>
            [EnumMember(Value = "BDT")]
            BDT,
            
            /// <summary>
            /// Enum BGN for "BGN"
            /// </summary>
            [EnumMember(Value = "BGN")]
            BGN,
            
            /// <summary>
            /// Enum BHD for "BHD"
            /// </summary>
            [EnumMember(Value = "BHD")]
            BHD,
            
            /// <summary>
            /// Enum BIF for "BIF"
            /// </summary>
            [EnumMember(Value = "BIF")]
            BIF,
            
            /// <summary>
            /// Enum BMD for "BMD"
            /// </summary>
            [EnumMember(Value = "BMD")]
            BMD,
            
            /// <summary>
            /// Enum BND for "BND"
            /// </summary>
            [EnumMember(Value = "BND")]
            BND,
            
            /// <summary>
            /// Enum BOB for "BOB"
            /// </summary>
            [EnumMember(Value = "BOB")]
            BOB,
            
            /// <summary>
            /// Enum BOV for "BOV"
            /// </summary>
            [EnumMember(Value = "BOV")]
            BOV,
            
            /// <summary>
            /// Enum BRL for "BRL"
            /// </summary>
            [EnumMember(Value = "BRL")]
            BRL,
            
            /// <summary>
            /// Enum BSD for "BSD"
            /// </summary>
            [EnumMember(Value = "BSD")]
            BSD,
            
            /// <summary>
            /// Enum BTN for "BTN"
            /// </summary>
            [EnumMember(Value = "BTN")]
            BTN,
            
            /// <summary>
            /// Enum BWP for "BWP"
            /// </summary>
            [EnumMember(Value = "BWP")]
            BWP,
            
            /// <summary>
            /// Enum BYR for "BYR"
            /// </summary>
            [EnumMember(Value = "BYR")]
            BYR,
            
            /// <summary>
            /// Enum BZD for "BZD"
            /// </summary>
            [EnumMember(Value = "BZD")]
            BZD,
            
            /// <summary>
            /// Enum CAD for "CAD"
            /// </summary>
            [EnumMember(Value = "CAD")]
            CAD,
            
            /// <summary>
            /// Enum CDF for "CDF"
            /// </summary>
            [EnumMember(Value = "CDF")]
            CDF,
            
            /// <summary>
            /// Enum CHE for "CHE"
            /// </summary>
            [EnumMember(Value = "CHE")]
            CHE,
            
            /// <summary>
            /// Enum CHF for "CHF"
            /// </summary>
            [EnumMember(Value = "CHF")]
            CHF,
            
            /// <summary>
            /// Enum CHW for "CHW"
            /// </summary>
            [EnumMember(Value = "CHW")]
            CHW,
            
            /// <summary>
            /// Enum CLF for "CLF"
            /// </summary>
            [EnumMember(Value = "CLF")]
            CLF,
            
            /// <summary>
            /// Enum CLP for "CLP"
            /// </summary>
            [EnumMember(Value = "CLP")]
            CLP,
            
            /// <summary>
            /// Enum CNY for "CNY"
            /// </summary>
            [EnumMember(Value = "CNY")]
            CNY,
            
            /// <summary>
            /// Enum COP for "COP"
            /// </summary>
            [EnumMember(Value = "COP")]
            COP,
            
            /// <summary>
            /// Enum COU for "COU"
            /// </summary>
            [EnumMember(Value = "COU")]
            COU,
            
            /// <summary>
            /// Enum CRC for "CRC"
            /// </summary>
            [EnumMember(Value = "CRC")]
            CRC,
            
            /// <summary>
            /// Enum CUC for "CUC"
            /// </summary>
            [EnumMember(Value = "CUC")]
            CUC,
            
            /// <summary>
            /// Enum CUP for "CUP"
            /// </summary>
            [EnumMember(Value = "CUP")]
            CUP,
            
            /// <summary>
            /// Enum CVE for "CVE"
            /// </summary>
            [EnumMember(Value = "CVE")]
            CVE,
            
            /// <summary>
            /// Enum CZK for "CZK"
            /// </summary>
            [EnumMember(Value = "CZK")]
            CZK,
            
            /// <summary>
            /// Enum DJF for "DJF"
            /// </summary>
            [EnumMember(Value = "DJF")]
            DJF,
            
            /// <summary>
            /// Enum DKK for "DKK"
            /// </summary>
            [EnumMember(Value = "DKK")]
            DKK,
            
            /// <summary>
            /// Enum DOP for "DOP"
            /// </summary>
            [EnumMember(Value = "DOP")]
            DOP,
            
            /// <summary>
            /// Enum DZD for "DZD"
            /// </summary>
            [EnumMember(Value = "DZD")]
            DZD,
            
            /// <summary>
            /// Enum EGP for "EGP"
            /// </summary>
            [EnumMember(Value = "EGP")]
            EGP,
            
            /// <summary>
            /// Enum ERN for "ERN"
            /// </summary>
            [EnumMember(Value = "ERN")]
            ERN,
            
            /// <summary>
            /// Enum ETB for "ETB"
            /// </summary>
            [EnumMember(Value = "ETB")]
            ETB,
            
            /// <summary>
            /// Enum EUR for "EUR"
            /// </summary>
            [EnumMember(Value = "EUR")]
            EUR,
            
            /// <summary>
            /// Enum FJD for "FJD"
            /// </summary>
            [EnumMember(Value = "FJD")]
            FJD,
            
            /// <summary>
            /// Enum FKP for "FKP"
            /// </summary>
            [EnumMember(Value = "FKP")]
            FKP,
            
            /// <summary>
            /// Enum GBP for "GBP"
            /// </summary>
            [EnumMember(Value = "GBP")]
            GBP,
            
            /// <summary>
            /// Enum GEL for "GEL"
            /// </summary>
            [EnumMember(Value = "GEL")]
            GEL,
            
            /// <summary>
            /// Enum GHS for "GHS"
            /// </summary>
            [EnumMember(Value = "GHS")]
            GHS,
            
            /// <summary>
            /// Enum GIP for "GIP"
            /// </summary>
            [EnumMember(Value = "GIP")]
            GIP,
            
            /// <summary>
            /// Enum GMD for "GMD"
            /// </summary>
            [EnumMember(Value = "GMD")]
            GMD,
            
            /// <summary>
            /// Enum GNF for "GNF"
            /// </summary>
            [EnumMember(Value = "GNF")]
            GNF,
            
            /// <summary>
            /// Enum GTQ for "GTQ"
            /// </summary>
            [EnumMember(Value = "GTQ")]
            GTQ,
            
            /// <summary>
            /// Enum GYD for "GYD"
            /// </summary>
            [EnumMember(Value = "GYD")]
            GYD,
            
            /// <summary>
            /// Enum HKD for "HKD"
            /// </summary>
            [EnumMember(Value = "HKD")]
            HKD,
            
            /// <summary>
            /// Enum HNL for "HNL"
            /// </summary>
            [EnumMember(Value = "HNL")]
            HNL,
            
            /// <summary>
            /// Enum HRK for "HRK"
            /// </summary>
            [EnumMember(Value = "HRK")]
            HRK,
            
            /// <summary>
            /// Enum HTG for "HTG"
            /// </summary>
            [EnumMember(Value = "HTG")]
            HTG,
            
            /// <summary>
            /// Enum HUF for "HUF"
            /// </summary>
            [EnumMember(Value = "HUF")]
            HUF,
            
            /// <summary>
            /// Enum IDR for "IDR"
            /// </summary>
            [EnumMember(Value = "IDR")]
            IDR,
            
            /// <summary>
            /// Enum ILS for "ILS"
            /// </summary>
            [EnumMember(Value = "ILS")]
            ILS,
            
            /// <summary>
            /// Enum INR for "INR"
            /// </summary>
            [EnumMember(Value = "INR")]
            INR,
            
            /// <summary>
            /// Enum IQD for "IQD"
            /// </summary>
            [EnumMember(Value = "IQD")]
            IQD,
            
            /// <summary>
            /// Enum IRR for "IRR"
            /// </summary>
            [EnumMember(Value = "IRR")]
            IRR,
            
            /// <summary>
            /// Enum ISK for "ISK"
            /// </summary>
            [EnumMember(Value = "ISK")]
            ISK,
            
            /// <summary>
            /// Enum JMD for "JMD"
            /// </summary>
            [EnumMember(Value = "JMD")]
            JMD,
            
            /// <summary>
            /// Enum JOD for "JOD"
            /// </summary>
            [EnumMember(Value = "JOD")]
            JOD,
            
            /// <summary>
            /// Enum JPY for "JPY"
            /// </summary>
            [EnumMember(Value = "JPY")]
            JPY,
            
            /// <summary>
            /// Enum KES for "KES"
            /// </summary>
            [EnumMember(Value = "KES")]
            KES,
            
            /// <summary>
            /// Enum KGS for "KGS"
            /// </summary>
            [EnumMember(Value = "KGS")]
            KGS,
            
            /// <summary>
            /// Enum KHR for "KHR"
            /// </summary>
            [EnumMember(Value = "KHR")]
            KHR,
            
            /// <summary>
            /// Enum KMF for "KMF"
            /// </summary>
            [EnumMember(Value = "KMF")]
            KMF,
            
            /// <summary>
            /// Enum KPW for "KPW"
            /// </summary>
            [EnumMember(Value = "KPW")]
            KPW,
            
            /// <summary>
            /// Enum KRW for "KRW"
            /// </summary>
            [EnumMember(Value = "KRW")]
            KRW,
            
            /// <summary>
            /// Enum KWD for "KWD"
            /// </summary>
            [EnumMember(Value = "KWD")]
            KWD,
            
            /// <summary>
            /// Enum KYD for "KYD"
            /// </summary>
            [EnumMember(Value = "KYD")]
            KYD,
            
            /// <summary>
            /// Enum KZT for "KZT"
            /// </summary>
            [EnumMember(Value = "KZT")]
            KZT,
            
            /// <summary>
            /// Enum LAK for "LAK"
            /// </summary>
            [EnumMember(Value = "LAK")]
            LAK,
            
            /// <summary>
            /// Enum LBP for "LBP"
            /// </summary>
            [EnumMember(Value = "LBP")]
            LBP,
            
            /// <summary>
            /// Enum LKR for "LKR"
            /// </summary>
            [EnumMember(Value = "LKR")]
            LKR,
            
            /// <summary>
            /// Enum LRD for "LRD"
            /// </summary>
            [EnumMember(Value = "LRD")]
            LRD,
            
            /// <summary>
            /// Enum LSL for "LSL"
            /// </summary>
            [EnumMember(Value = "LSL")]
            LSL,
            
            /// <summary>
            /// Enum LTL for "LTL"
            /// </summary>
            [EnumMember(Value = "LTL")]
            LTL,
            
            /// <summary>
            /// Enum LVL for "LVL"
            /// </summary>
            [EnumMember(Value = "LVL")]
            LVL,
            
            /// <summary>
            /// Enum LYD for "LYD"
            /// </summary>
            [EnumMember(Value = "LYD")]
            LYD,
            
            /// <summary>
            /// Enum MAD for "MAD"
            /// </summary>
            [EnumMember(Value = "MAD")]
            MAD,
            
            /// <summary>
            /// Enum MDL for "MDL"
            /// </summary>
            [EnumMember(Value = "MDL")]
            MDL,
            
            /// <summary>
            /// Enum MGA for "MGA"
            /// </summary>
            [EnumMember(Value = "MGA")]
            MGA,
            
            /// <summary>
            /// Enum MKD for "MKD"
            /// </summary>
            [EnumMember(Value = "MKD")]
            MKD,
            
            /// <summary>
            /// Enum MMK for "MMK"
            /// </summary>
            [EnumMember(Value = "MMK")]
            MMK,
            
            /// <summary>
            /// Enum MNT for "MNT"
            /// </summary>
            [EnumMember(Value = "MNT")]
            MNT,
            
            /// <summary>
            /// Enum MOP for "MOP"
            /// </summary>
            [EnumMember(Value = "MOP")]
            MOP,
            
            /// <summary>
            /// Enum MRO for "MRO"
            /// </summary>
            [EnumMember(Value = "MRO")]
            MRO,
            
            /// <summary>
            /// Enum MUR for "MUR"
            /// </summary>
            [EnumMember(Value = "MUR")]
            MUR,
            
            /// <summary>
            /// Enum MVR for "MVR"
            /// </summary>
            [EnumMember(Value = "MVR")]
            MVR,
            
            /// <summary>
            /// Enum MWK for "MWK"
            /// </summary>
            [EnumMember(Value = "MWK")]
            MWK,
            
            /// <summary>
            /// Enum MXN for "MXN"
            /// </summary>
            [EnumMember(Value = "MXN")]
            MXN,
            
            /// <summary>
            /// Enum MXV for "MXV"
            /// </summary>
            [EnumMember(Value = "MXV")]
            MXV,
            
            /// <summary>
            /// Enum MYR for "MYR"
            /// </summary>
            [EnumMember(Value = "MYR")]
            MYR,
            
            /// <summary>
            /// Enum MZN for "MZN"
            /// </summary>
            [EnumMember(Value = "MZN")]
            MZN,
            
            /// <summary>
            /// Enum NAD for "NAD"
            /// </summary>
            [EnumMember(Value = "NAD")]
            NAD,
            
            /// <summary>
            /// Enum NGN for "NGN"
            /// </summary>
            [EnumMember(Value = "NGN")]
            NGN,
            
            /// <summary>
            /// Enum NIO for "NIO"
            /// </summary>
            [EnumMember(Value = "NIO")]
            NIO,
            
            /// <summary>
            /// Enum NOK for "NOK"
            /// </summary>
            [EnumMember(Value = "NOK")]
            NOK,
            
            /// <summary>
            /// Enum NPR for "NPR"
            /// </summary>
            [EnumMember(Value = "NPR")]
            NPR,
            
            /// <summary>
            /// Enum NZD for "NZD"
            /// </summary>
            [EnumMember(Value = "NZD")]
            NZD,
            
            /// <summary>
            /// Enum OMR for "OMR"
            /// </summary>
            [EnumMember(Value = "OMR")]
            OMR,
            
            /// <summary>
            /// Enum PAB for "PAB"
            /// </summary>
            [EnumMember(Value = "PAB")]
            PAB,
            
            /// <summary>
            /// Enum PEN for "PEN"
            /// </summary>
            [EnumMember(Value = "PEN")]
            PEN,
            
            /// <summary>
            /// Enum PGK for "PGK"
            /// </summary>
            [EnumMember(Value = "PGK")]
            PGK,
            
            /// <summary>
            /// Enum PHP for "PHP"
            /// </summary>
            [EnumMember(Value = "PHP")]
            PHP,
            
            /// <summary>
            /// Enum PKR for "PKR"
            /// </summary>
            [EnumMember(Value = "PKR")]
            PKR,
            
            /// <summary>
            /// Enum PLN for "PLN"
            /// </summary>
            [EnumMember(Value = "PLN")]
            PLN,
            
            /// <summary>
            /// Enum PYG for "PYG"
            /// </summary>
            [EnumMember(Value = "PYG")]
            PYG,
            
            /// <summary>
            /// Enum QAR for "QAR"
            /// </summary>
            [EnumMember(Value = "QAR")]
            QAR,
            
            /// <summary>
            /// Enum RON for "RON"
            /// </summary>
            [EnumMember(Value = "RON")]
            RON,
            
            /// <summary>
            /// Enum RSD for "RSD"
            /// </summary>
            [EnumMember(Value = "RSD")]
            RSD,
            
            /// <summary>
            /// Enum RUB for "RUB"
            /// </summary>
            [EnumMember(Value = "RUB")]
            RUB,
            
            /// <summary>
            /// Enum RWF for "RWF"
            /// </summary>
            [EnumMember(Value = "RWF")]
            RWF,
            
            /// <summary>
            /// Enum SAR for "SAR"
            /// </summary>
            [EnumMember(Value = "SAR")]
            SAR,
            
            /// <summary>
            /// Enum SBD for "SBD"
            /// </summary>
            [EnumMember(Value = "SBD")]
            SBD,
            
            /// <summary>
            /// Enum SCR for "SCR"
            /// </summary>
            [EnumMember(Value = "SCR")]
            SCR,
            
            /// <summary>
            /// Enum SDG for "SDG"
            /// </summary>
            [EnumMember(Value = "SDG")]
            SDG,
            
            /// <summary>
            /// Enum SEK for "SEK"
            /// </summary>
            [EnumMember(Value = "SEK")]
            SEK,
            
            /// <summary>
            /// Enum SGD for "SGD"
            /// </summary>
            [EnumMember(Value = "SGD")]
            SGD,
            
            /// <summary>
            /// Enum SHP for "SHP"
            /// </summary>
            [EnumMember(Value = "SHP")]
            SHP,
            
            /// <summary>
            /// Enum SLL for "SLL"
            /// </summary>
            [EnumMember(Value = "SLL")]
            SLL,
            
            /// <summary>
            /// Enum SOS for "SOS"
            /// </summary>
            [EnumMember(Value = "SOS")]
            SOS,
            
            /// <summary>
            /// Enum SRD for "SRD"
            /// </summary>
            [EnumMember(Value = "SRD")]
            SRD,
            
            /// <summary>
            /// Enum SSP for "SSP"
            /// </summary>
            [EnumMember(Value = "SSP")]
            SSP,
            
            /// <summary>
            /// Enum STD for "STD"
            /// </summary>
            [EnumMember(Value = "STD")]
            STD,
            
            /// <summary>
            /// Enum SVC for "SVC"
            /// </summary>
            [EnumMember(Value = "SVC")]
            SVC,
            
            /// <summary>
            /// Enum SYP for "SYP"
            /// </summary>
            [EnumMember(Value = "SYP")]
            SYP,
            
            /// <summary>
            /// Enum SZL for "SZL"
            /// </summary>
            [EnumMember(Value = "SZL")]
            SZL,
            
            /// <summary>
            /// Enum THB for "THB"
            /// </summary>
            [EnumMember(Value = "THB")]
            THB,
            
            /// <summary>
            /// Enum TJS for "TJS"
            /// </summary>
            [EnumMember(Value = "TJS")]
            TJS,
            
            /// <summary>
            /// Enum TMT for "TMT"
            /// </summary>
            [EnumMember(Value = "TMT")]
            TMT,
            
            /// <summary>
            /// Enum TND for "TND"
            /// </summary>
            [EnumMember(Value = "TND")]
            TND,
            
            /// <summary>
            /// Enum TOP for "TOP"
            /// </summary>
            [EnumMember(Value = "TOP")]
            TOP,
            
            /// <summary>
            /// Enum TRY for "TRY"
            /// </summary>
            [EnumMember(Value = "TRY")]
            TRY,
            
            /// <summary>
            /// Enum TTD for "TTD"
            /// </summary>
            [EnumMember(Value = "TTD")]
            TTD,
            
            /// <summary>
            /// Enum TWD for "TWD"
            /// </summary>
            [EnumMember(Value = "TWD")]
            TWD,
            
            /// <summary>
            /// Enum TZS for "TZS"
            /// </summary>
            [EnumMember(Value = "TZS")]
            TZS,
            
            /// <summary>
            /// Enum UAH for "UAH"
            /// </summary>
            [EnumMember(Value = "UAH")]
            UAH,
            
            /// <summary>
            /// Enum UGX for "UGX"
            /// </summary>
            [EnumMember(Value = "UGX")]
            UGX,
            
            /// <summary>
            /// Enum USD for "USD"
            /// </summary>
            [EnumMember(Value = "USD")]
            USD,
            
            /// <summary>
            /// Enum USN for "USN"
            /// </summary>
            [EnumMember(Value = "USN")]
            USN,
            
            /// <summary>
            /// Enum USS for "USS"
            /// </summary>
            [EnumMember(Value = "USS")]
            USS,
            
            /// <summary>
            /// Enum UYI for "UYI"
            /// </summary>
            [EnumMember(Value = "UYI")]
            UYI,
            
            /// <summary>
            /// Enum UYU for "UYU"
            /// </summary>
            [EnumMember(Value = "UYU")]
            UYU,
            
            /// <summary>
            /// Enum UZS for "UZS"
            /// </summary>
            [EnumMember(Value = "UZS")]
            UZS,
            
            /// <summary>
            /// Enum VEF for "VEF"
            /// </summary>
            [EnumMember(Value = "VEF")]
            VEF,
            
            /// <summary>
            /// Enum VND for "VND"
            /// </summary>
            [EnumMember(Value = "VND")]
            VND,
            
            /// <summary>
            /// Enum VUV for "VUV"
            /// </summary>
            [EnumMember(Value = "VUV")]
            VUV,
            
            /// <summary>
            /// Enum WST for "WST"
            /// </summary>
            [EnumMember(Value = "WST")]
            WST,
            
            /// <summary>
            /// Enum XAF for "XAF"
            /// </summary>
            [EnumMember(Value = "XAF")]
            XAF,
            
            /// <summary>
            /// Enum XAG for "XAG"
            /// </summary>
            [EnumMember(Value = "XAG")]
            XAG,
            
            /// <summary>
            /// Enum XAU for "XAU"
            /// </summary>
            [EnumMember(Value = "XAU")]
            XAU,
            
            /// <summary>
            /// Enum XBA for "XBA"
            /// </summary>
            [EnumMember(Value = "XBA")]
            XBA,
            
            /// <summary>
            /// Enum XBB for "XBB"
            /// </summary>
            [EnumMember(Value = "XBB")]
            XBB,
            
            /// <summary>
            /// Enum XBC for "XBC"
            /// </summary>
            [EnumMember(Value = "XBC")]
            XBC,
            
            /// <summary>
            /// Enum XBD for "XBD"
            /// </summary>
            [EnumMember(Value = "XBD")]
            XBD,
            
            /// <summary>
            /// Enum XCD for "XCD"
            /// </summary>
            [EnumMember(Value = "XCD")]
            XCD,
            
            /// <summary>
            /// Enum XDR for "XDR"
            /// </summary>
            [EnumMember(Value = "XDR")]
            XDR,
            
            /// <summary>
            /// Enum XOF for "XOF"
            /// </summary>
            [EnumMember(Value = "XOF")]
            XOF,
            
            /// <summary>
            /// Enum XPD for "XPD"
            /// </summary>
            [EnumMember(Value = "XPD")]
            XPD,
            
            /// <summary>
            /// Enum XPF for "XPF"
            /// </summary>
            [EnumMember(Value = "XPF")]
            XPF,
            
            /// <summary>
            /// Enum XPT for "XPT"
            /// </summary>
            [EnumMember(Value = "XPT")]
            XPT,
            
            /// <summary>
            /// Enum XTS for "XTS"
            /// </summary>
            [EnumMember(Value = "XTS")]
            XTS,
            
            /// <summary>
            /// Enum XXX for "XXX"
            /// </summary>
            [EnumMember(Value = "XXX")]
            XXX,
            
            /// <summary>
            /// Enum YER for "YER"
            /// </summary>
            [EnumMember(Value = "YER")]
            YER,
            
            /// <summary>
            /// Enum ZAR for "ZAR"
            /// </summary>
            [EnumMember(Value = "ZAR")]
            ZAR,
            
            /// <summary>
            /// Enum ZMK for "ZMK"
            /// </summary>
            [EnumMember(Value = "ZMK")]
            ZMK,
            
            /// <summary>
            /// Enum ZMW for "ZMW"
            /// </summary>
            [EnumMember(Value = "ZMW")]
            ZMW,
            
            /// <summary>
            /// Enum BTC for "BTC"
            /// </summary>
            [EnumMember(Value = "BTC")]
            BTC
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public CurrencyCodeEnum? CurrencyCode { get; set; }

        public V1Money()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1Money" /> class.
        /// </summary>
        /// <param name="Amount">Amount in the lowest denominated value of this Currency. E.g. in USD these are cents, in JPY they are Yen (which do not have a &#39;cent&#39; concept)..</param>
        /// <param name="CurrencyCode">.</param>
        public V1Money(int? Amount = default(int?), CurrencyCodeEnum? CurrencyCode = default(CurrencyCodeEnum?))
        {
            this.Amount = Amount;
            this.CurrencyCode = CurrencyCode;
        }
        
        /// <summary>
        /// Amount in the lowest denominated value of this Currency. E.g. in USD these are cents, in JPY they are Yen (which do not have a &#39;cent&#39; concept).
        /// </summary>
        /// <value>Amount in the lowest denominated value of this Currency. E.g. in USD these are cents, in JPY they are Yen (which do not have a &#39;cent&#39; concept).</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public int? Amount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1Money {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as V1Money);
        }

        /// <summary>
        /// Returns true if V1Money instances are equal
        /// </summary>
        /// <param name="other">Instance of V1Money to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1Money other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
