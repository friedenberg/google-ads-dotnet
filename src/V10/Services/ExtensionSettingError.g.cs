// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/errors/extension_setting_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/errors/extension_setting_error.proto</summary>
  public static partial class ExtensionSettingErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/errors/extension_setting_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExtensionSettingErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZXJyb3JzL2V4dGVuc2lvbl9z",
            "ZXR0aW5nX2Vycm9yLnByb3RvEh9nb29nbGUuYWRzLmdvb2dsZWFkcy52MTAu",
            "ZXJyb3JzGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIq4UChlFeHRl",
            "bnNpb25TZXR0aW5nRXJyb3JFbnVtIpAUChVFeHRlbnNpb25TZXR0aW5nRXJy",
            "b3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESFwoTRVhURU5TSU9O",
            "U19SRVFVSVJFRBACEiUKIUZFRURfVFlQRV9FWFRFTlNJT05fVFlQRV9NSVNN",
            "QVRDSBADEhUKEUlOVkFMSURfRkVFRF9UWVBFEAQSNAowSU5WQUxJRF9GRUVE",
            "X1RZUEVfRk9SX0NVU1RPTUVSX0VYVEVOU0lPTl9TRVRUSU5HEAUSJQohQ0FO",
            "Tk9UX0NIQU5HRV9GRUVEX0lURU1fT05fQ1JFQVRFEAYSKQolQ0FOTk9UX1VQ",
            "REFURV9ORVdMWV9DUkVBVEVEX0VYVEVOU0lPThAHEjMKL05PX0VYSVNUSU5H",
            "X0FEX0dST1VQX0VYVEVOU0lPTl9TRVRUSU5HX0ZPUl9UWVBFEAgSMwovTk9f",
            "RVhJU1RJTkdfQ0FNUEFJR05fRVhURU5TSU9OX1NFVFRJTkdfRk9SX1RZUEUQ",
            "CRIzCi9OT19FWElTVElOR19DVVNUT01FUl9FWFRFTlNJT05fU0VUVElOR19G",
            "T1JfVFlQRRAKEi0KKUFEX0dST1VQX0VYVEVOU0lPTl9TRVRUSU5HX0FMUkVB",
            "RFlfRVhJU1RTEAsSLQopQ0FNUEFJR05fRVhURU5TSU9OX1NFVFRJTkdfQUxS",
            "RUFEWV9FWElTVFMQDBItCilDVVNUT01FUl9FWFRFTlNJT05fU0VUVElOR19B",
            "TFJFQURZX0VYSVNUUxANEjUKMUFEX0dST1VQX0ZFRURfQUxSRUFEWV9FWElT",
            "VFNfRk9SX1BMQUNFSE9MREVSX1RZUEUQDhI1CjFDQU1QQUlHTl9GRUVEX0FM",
            "UkVBRFlfRVhJU1RTX0ZPUl9QTEFDRUhPTERFUl9UWVBFEA8SNQoxQ1VTVE9N",
            "RVJfRkVFRF9BTFJFQURZX0VYSVNUU19GT1JfUExBQ0VIT0xERVJfVFlQRRAQ",
            "EhYKElZBTFVFX09VVF9PRl9SQU5HRRAREiQKIENBTk5PVF9TRVRfRklFTERf",
            "V0lUSF9GSU5BTF9VUkxTEBISFgoSRklOQUxfVVJMU19OT1RfU0VUEBMSGAoU",
            "SU5WQUxJRF9QSE9ORV9OVU1CRVIQFBIqCiZQSE9ORV9OVU1CRVJfTk9UX1NV",
            "UFBPUlRFRF9GT1JfQ09VTlRSWRAVEi0KKUNBUlJJRVJfU1BFQ0lGSUNfU0hP",
            "UlRfTlVNQkVSX05PVF9BTExPV0VEEBYSIwofUFJFTUlVTV9SQVRFX05VTUJF",
            "Ul9OT1RfQUxMT1dFRBAXEhoKFkRJU0FMTE9XRURfTlVNQkVSX1RZUEUQGBIo",
            "CiRJTlZBTElEX0RPTUVTVElDX1BIT05FX05VTUJFUl9GT1JNQVQQGRIjCh9W",
            "QU5JVFlfUEhPTkVfTlVNQkVSX05PVF9BTExPV0VEEBoSGAoUSU5WQUxJRF9D",
            "T1VOVFJZX0NPREUQGxIjCh9JTlZBTElEX0NBTExfQ09OVkVSU0lPTl9UWVBF",
            "X0lEEBwSLgoqQ1VTVE9NRVJfTk9UX0lOX0FMTE9XTElTVF9GT1JfQ0FMTFRS",
            "QUNLSU5HEEUSKgomQ0FMTFRSQUNLSU5HX05PVF9TVVBQT1JURURfRk9SX0NP",
            "VU5UUlkQHhISCg5JTlZBTElEX0FQUF9JRBAfEiYKIlFVT1RFU19JTl9SRVZJ",
            "RVdfRVhURU5TSU9OX1NOSVBQRVQQIBInCiNIWVBIRU5TX0lOX1JFVklFV19F",
            "WFRFTlNJT05fU05JUFBFVBAhEigKJFJFVklFV19FWFRFTlNJT05fU09VUkNF",
            "X05PVF9FTElHSUJMRRAiEigKJFNPVVJDRV9OQU1FX0lOX1JFVklFV19FWFRF",
            "TlNJT05fVEVYVBAjEhEKDU1JU1NJTkdfRklFTEQQJBIfChtJTkNPTlNJU1RF",
            "TlRfQ1VSUkVOQ1lfQ09ERVMQJRIqCiZQUklDRV9FWFRFTlNJT05fSEFTX0RV",
            "UExJQ0FURURfSEVBREVSUxAmEjQKMFBSSUNFX0lURU1fSEFTX0RVUExJQ0FU",
            "RURfSEVBREVSX0FORF9ERVNDUklQVElPThAnEiUKIVBSSUNFX0VYVEVOU0lP",
            "Tl9IQVNfVE9PX0ZFV19JVEVNUxAoEiYKIlBSSUNFX0VYVEVOU0lPTl9IQVNf",
            "VE9PX01BTllfSVRFTVMQKRIVChFVTlNVUFBPUlRFRF9WQUxVRRAqEh0KGUlO",
            "VkFMSURfREVWSUNFX1BSRUZFUkVOQ0UQKxIYChRJTlZBTElEX1NDSEVEVUxF",
            "X0VORBAtEioKJkRBVEVfVElNRV9NVVNUX0JFX0lOX0FDQ09VTlRfVElNRV9a",
            "T05FEC8SJQohT1ZFUkxBUFBJTkdfU0NIRURVTEVTX05PVF9BTExPV0VEEDAS",
            "IAocU0NIRURVTEVfRU5EX05PVF9BRlRFUl9TVEFSVBAxEh4KGlRPT19NQU5Z",
            "X1NDSEVEVUxFU19QRVJfREFZEDISJgoiRFVQTElDQVRFX0VYVEVOU0lPTl9G",
            "RUVEX0lURU1fRURJVBAzEhsKF0lOVkFMSURfU05JUFBFVFNfSEVBREVSEDQS",
            "PAo4UEhPTkVfTlVNQkVSX05PVF9TVVBQT1JURURfV0lUSF9DQUxMVFJBQ0tJ",
            "TkdfRk9SX0NPVU5UUlkQNRIfChtDQU1QQUlHTl9UQVJHRVRJTkdfTUlTTUFU",
            "Q0gQNhIiCh5DQU5OT1RfT1BFUkFURV9PTl9SRU1PVkVEX0ZFRUQQNxIbChdF",
            "WFRFTlNJT05fVFlQRV9SRVFVSVJFRBA4Ei0KKUlOQ09NUEFUSUJMRV9VTkRF",
            "UkxZSU5HX01BVENISU5HX0ZVTkNUSU9OEDkSHQoZU1RBUlRfREFURV9BRlRF",
            "Ul9FTkRfREFURRA6EhgKFElOVkFMSURfUFJJQ0VfRk9STUFUEDsSGgoWUFJP",
            "TU9USU9OX0lOVkFMSURfVElNRRA8EjwKOFBST01PVElPTl9DQU5OT1RfU0VU",
            "X1BFUkNFTlRfRElTQ09VTlRfQU5EX01PTkVZX0RJU0NPVU5UED0SPgo6UFJP",
            "TU9USU9OX0NBTk5PVF9TRVRfUFJPTU9USU9OX0NPREVfQU5EX09SREVSU19P",
            "VkVSX0FNT1VOVBA+EiUKIVRPT19NQU5ZX0RFQ0lNQUxfUExBQ0VTX1NQRUNJ",
            "RklFRBA/EhkKFUlOVkFMSURfTEFOR1VBR0VfQ09ERRBAEhgKFFVOU1VQUE9S",
            "VEVEX0xBTkdVQUdFEEESMAosQ1VTVE9NRVJfQ09OU0VOVF9GT1JfQ0FMTF9S",
            "RUNPUkRJTkdfUkVRVUlSRUQQQhImCiJFWFRFTlNJT05fU0VUVElOR19VUERB",
            "VEVfSVNfQV9OT09QEEMSEwoPRElTQUxMT1dFRF9URVhUEERC+gEKI2NvbS5n",
            "b29nbGUuYWRzLmdvb2dsZWFkcy52MTAuZXJyb3JzQhpFeHRlbnNpb25TZXR0",
            "aW5nRXJyb3JQcm90b1ABWkVnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9n",
            "b29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjEwL2Vycm9ycztlcnJvcnOiAgNH",
            "QUGqAh9Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMTAuRXJyb3JzygIfR29vZ2xl",
            "XEFkc1xHb29nbGVBZHNcVjEwXEVycm9yc+oCI0dvb2dsZTo6QWRzOjpHb29n",
            "bGVBZHM6OlYxMDo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Errors.ExtensionSettingErrorEnum), global::Google.Ads.GoogleAds.V10.Errors.ExtensionSettingErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V10.Errors.ExtensionSettingErrorEnum.Types.ExtensionSettingError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing validation errors of extension settings.
  /// </summary>
  public sealed partial class ExtensionSettingErrorEnum : pb::IMessage<ExtensionSettingErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ExtensionSettingErrorEnum> _parser = new pb::MessageParser<ExtensionSettingErrorEnum>(() => new ExtensionSettingErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ExtensionSettingErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Errors.ExtensionSettingErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExtensionSettingErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExtensionSettingErrorEnum(ExtensionSettingErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExtensionSettingErrorEnum Clone() {
      return new ExtensionSettingErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ExtensionSettingErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ExtensionSettingErrorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ExtensionSettingErrorEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ExtensionSettingErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible extension setting errors.
      /// </summary>
      public enum ExtensionSettingError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// A platform restriction was provided without input extensions or existing
        /// extensions.
        /// </summary>
        [pbr::OriginalName("EXTENSIONS_REQUIRED")] ExtensionsRequired = 2,
        /// <summary>
        /// The provided feed type does not correspond to the provided extensions.
        /// </summary>
        [pbr::OriginalName("FEED_TYPE_EXTENSION_TYPE_MISMATCH")] FeedTypeExtensionTypeMismatch = 3,
        /// <summary>
        /// The provided feed type cannot be used.
        /// </summary>
        [pbr::OriginalName("INVALID_FEED_TYPE")] InvalidFeedType = 4,
        /// <summary>
        /// The provided feed type cannot be used at the customer level.
        /// </summary>
        [pbr::OriginalName("INVALID_FEED_TYPE_FOR_CUSTOMER_EXTENSION_SETTING")] InvalidFeedTypeForCustomerExtensionSetting = 5,
        /// <summary>
        /// Cannot change a feed item field on a CREATE operation.
        /// </summary>
        [pbr::OriginalName("CANNOT_CHANGE_FEED_ITEM_ON_CREATE")] CannotChangeFeedItemOnCreate = 6,
        /// <summary>
        /// Cannot update an extension that is not already in this setting.
        /// </summary>
        [pbr::OriginalName("CANNOT_UPDATE_NEWLY_CREATED_EXTENSION")] CannotUpdateNewlyCreatedExtension = 7,
        /// <summary>
        /// There is no existing AdGroupExtensionSetting for this type.
        /// </summary>
        [pbr::OriginalName("NO_EXISTING_AD_GROUP_EXTENSION_SETTING_FOR_TYPE")] NoExistingAdGroupExtensionSettingForType = 8,
        /// <summary>
        /// There is no existing CampaignExtensionSetting for this type.
        /// </summary>
        [pbr::OriginalName("NO_EXISTING_CAMPAIGN_EXTENSION_SETTING_FOR_TYPE")] NoExistingCampaignExtensionSettingForType = 9,
        /// <summary>
        /// There is no existing CustomerExtensionSetting for this type.
        /// </summary>
        [pbr::OriginalName("NO_EXISTING_CUSTOMER_EXTENSION_SETTING_FOR_TYPE")] NoExistingCustomerExtensionSettingForType = 10,
        /// <summary>
        /// The AdGroupExtensionSetting already exists. UPDATE should be used to
        /// modify the existing AdGroupExtensionSetting.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_EXTENSION_SETTING_ALREADY_EXISTS")] AdGroupExtensionSettingAlreadyExists = 11,
        /// <summary>
        /// The CampaignExtensionSetting already exists. UPDATE should be used to
        /// modify the existing CampaignExtensionSetting.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_EXTENSION_SETTING_ALREADY_EXISTS")] CampaignExtensionSettingAlreadyExists = 12,
        /// <summary>
        /// The CustomerExtensionSetting already exists. UPDATE should be used to
        /// modify the existing CustomerExtensionSetting.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_EXTENSION_SETTING_ALREADY_EXISTS")] CustomerExtensionSettingAlreadyExists = 13,
        /// <summary>
        /// An active ad group feed already exists for this place holder type.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_FEED_ALREADY_EXISTS_FOR_PLACEHOLDER_TYPE")] AdGroupFeedAlreadyExistsForPlaceholderType = 14,
        /// <summary>
        /// An active campaign feed already exists for this place holder type.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_FEED_ALREADY_EXISTS_FOR_PLACEHOLDER_TYPE")] CampaignFeedAlreadyExistsForPlaceholderType = 15,
        /// <summary>
        /// An active customer feed already exists for this place holder type.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_FEED_ALREADY_EXISTS_FOR_PLACEHOLDER_TYPE")] CustomerFeedAlreadyExistsForPlaceholderType = 16,
        /// <summary>
        /// Value is not within the accepted range.
        /// </summary>
        [pbr::OriginalName("VALUE_OUT_OF_RANGE")] ValueOutOfRange = 17,
        /// <summary>
        /// Cannot simultaneously set specified field with final urls.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_FIELD_WITH_FINAL_URLS")] CannotSetFieldWithFinalUrls = 18,
        /// <summary>
        /// Must set field with final urls.
        /// </summary>
        [pbr::OriginalName("FINAL_URLS_NOT_SET")] FinalUrlsNotSet = 19,
        /// <summary>
        /// Phone number for a call extension is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_PHONE_NUMBER")] InvalidPhoneNumber = 20,
        /// <summary>
        /// Phone number for a call extension is not supported for the given country
        /// code.
        /// </summary>
        [pbr::OriginalName("PHONE_NUMBER_NOT_SUPPORTED_FOR_COUNTRY")] PhoneNumberNotSupportedForCountry = 21,
        /// <summary>
        /// A carrier specific number in short format is not allowed for call
        /// extensions.
        /// </summary>
        [pbr::OriginalName("CARRIER_SPECIFIC_SHORT_NUMBER_NOT_ALLOWED")] CarrierSpecificShortNumberNotAllowed = 22,
        /// <summary>
        /// Premium rate numbers are not allowed for call extensions.
        /// </summary>
        [pbr::OriginalName("PREMIUM_RATE_NUMBER_NOT_ALLOWED")] PremiumRateNumberNotAllowed = 23,
        /// <summary>
        /// Phone number type for a call extension is not allowed.
        /// </summary>
        [pbr::OriginalName("DISALLOWED_NUMBER_TYPE")] DisallowedNumberType = 24,
        /// <summary>
        /// Phone number for a call extension does not meet domestic format
        /// requirements.
        /// </summary>
        [pbr::OriginalName("INVALID_DOMESTIC_PHONE_NUMBER_FORMAT")] InvalidDomesticPhoneNumberFormat = 25,
        /// <summary>
        /// Vanity phone numbers (i.e. those including letters) are not allowed for
        /// call extensions.
        /// </summary>
        [pbr::OriginalName("VANITY_PHONE_NUMBER_NOT_ALLOWED")] VanityPhoneNumberNotAllowed = 26,
        /// <summary>
        /// Country code provided for a call extension is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_COUNTRY_CODE")] InvalidCountryCode = 27,
        /// <summary>
        /// Call conversion type id provided for a call extension is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_CALL_CONVERSION_TYPE_ID")] InvalidCallConversionTypeId = 28,
        /// <summary>
        /// For a call extension, the customer is not on the allow-list for call
        /// tracking.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_NOT_IN_ALLOWLIST_FOR_CALLTRACKING")] CustomerNotInAllowlistForCalltracking = 69,
        /// <summary>
        /// Call tracking is not supported for the given country for a call
        /// extension.
        /// </summary>
        [pbr::OriginalName("CALLTRACKING_NOT_SUPPORTED_FOR_COUNTRY")] CalltrackingNotSupportedForCountry = 30,
        /// <summary>
        /// App id provided for an app extension is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_APP_ID")] InvalidAppId = 31,
        /// <summary>
        /// Quotation marks present in the review text for a review extension.
        /// </summary>
        [pbr::OriginalName("QUOTES_IN_REVIEW_EXTENSION_SNIPPET")] QuotesInReviewExtensionSnippet = 32,
        /// <summary>
        /// Hyphen character present in the review text for a review extension.
        /// </summary>
        [pbr::OriginalName("HYPHENS_IN_REVIEW_EXTENSION_SNIPPET")] HyphensInReviewExtensionSnippet = 33,
        /// <summary>
        /// A blocked review source name or url was provided for a review
        /// extension.
        /// </summary>
        [pbr::OriginalName("REVIEW_EXTENSION_SOURCE_NOT_ELIGIBLE")] ReviewExtensionSourceNotEligible = 34,
        /// <summary>
        /// Review source name should not be found in the review text.
        /// </summary>
        [pbr::OriginalName("SOURCE_NAME_IN_REVIEW_EXTENSION_TEXT")] SourceNameInReviewExtensionText = 35,
        /// <summary>
        /// Field must be set.
        /// </summary>
        [pbr::OriginalName("MISSING_FIELD")] MissingField = 36,
        /// <summary>
        /// Inconsistent currency codes.
        /// </summary>
        [pbr::OriginalName("INCONSISTENT_CURRENCY_CODES")] InconsistentCurrencyCodes = 37,
        /// <summary>
        /// Price extension cannot have duplicated headers.
        /// </summary>
        [pbr::OriginalName("PRICE_EXTENSION_HAS_DUPLICATED_HEADERS")] PriceExtensionHasDuplicatedHeaders = 38,
        /// <summary>
        /// Price item cannot have duplicated header and description.
        /// </summary>
        [pbr::OriginalName("PRICE_ITEM_HAS_DUPLICATED_HEADER_AND_DESCRIPTION")] PriceItemHasDuplicatedHeaderAndDescription = 39,
        /// <summary>
        /// Price extension has too few items
        /// </summary>
        [pbr::OriginalName("PRICE_EXTENSION_HAS_TOO_FEW_ITEMS")] PriceExtensionHasTooFewItems = 40,
        /// <summary>
        /// Price extension has too many items
        /// </summary>
        [pbr::OriginalName("PRICE_EXTENSION_HAS_TOO_MANY_ITEMS")] PriceExtensionHasTooManyItems = 41,
        /// <summary>
        /// The input value is not currently supported.
        /// </summary>
        [pbr::OriginalName("UNSUPPORTED_VALUE")] UnsupportedValue = 42,
        /// <summary>
        /// Unknown or unsupported device preference.
        /// </summary>
        [pbr::OriginalName("INVALID_DEVICE_PREFERENCE")] InvalidDevicePreference = 43,
        /// <summary>
        /// Invalid feed item schedule end time (i.e., endHour = 24 and
        /// endMinute != 0).
        /// </summary>
        [pbr::OriginalName("INVALID_SCHEDULE_END")] InvalidScheduleEnd = 45,
        /// <summary>
        /// Date time zone does not match the account's time zone.
        /// </summary>
        [pbr::OriginalName("DATE_TIME_MUST_BE_IN_ACCOUNT_TIME_ZONE")] DateTimeMustBeInAccountTimeZone = 47,
        /// <summary>
        /// Overlapping feed item schedule times (e.g., 7-10AM and 8-11AM) are not
        /// allowed.
        /// </summary>
        [pbr::OriginalName("OVERLAPPING_SCHEDULES_NOT_ALLOWED")] OverlappingSchedulesNotAllowed = 48,
        /// <summary>
        /// Feed item schedule end time must be after start time.
        /// </summary>
        [pbr::OriginalName("SCHEDULE_END_NOT_AFTER_START")] ScheduleEndNotAfterStart = 49,
        /// <summary>
        /// There are too many feed item schedules per day.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_SCHEDULES_PER_DAY")] TooManySchedulesPerDay = 50,
        /// <summary>
        /// Cannot edit the same extension feed item more than once in the same
        /// request.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_EXTENSION_FEED_ITEM_EDIT")] DuplicateExtensionFeedItemEdit = 51,
        /// <summary>
        /// Invalid structured snippet header.
        /// </summary>
        [pbr::OriginalName("INVALID_SNIPPETS_HEADER")] InvalidSnippetsHeader = 52,
        /// <summary>
        /// Phone number with call tracking enabled is not supported for the
        /// specified country.
        /// </summary>
        [pbr::OriginalName("PHONE_NUMBER_NOT_SUPPORTED_WITH_CALLTRACKING_FOR_COUNTRY")] PhoneNumberNotSupportedWithCalltrackingForCountry = 53,
        /// <summary>
        /// The targeted adgroup must belong to the targeted campaign.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_TARGETING_MISMATCH")] CampaignTargetingMismatch = 54,
        /// <summary>
        /// The feed used by the ExtensionSetting is removed and cannot be operated
        /// on. Remove the ExtensionSetting to allow a new one to be created using
        /// an active feed.
        /// </summary>
        [pbr::OriginalName("CANNOT_OPERATE_ON_REMOVED_FEED")] CannotOperateOnRemovedFeed = 55,
        /// <summary>
        /// The ExtensionFeedItem type is required for this operation.
        /// </summary>
        [pbr::OriginalName("EXTENSION_TYPE_REQUIRED")] ExtensionTypeRequired = 56,
        /// <summary>
        /// The matching function that links the extension feed to the customer,
        /// campaign, or ad group is not compatible with the ExtensionSetting
        /// services.
        /// </summary>
        [pbr::OriginalName("INCOMPATIBLE_UNDERLYING_MATCHING_FUNCTION")] IncompatibleUnderlyingMatchingFunction = 57,
        /// <summary>
        /// Start date must be before end date.
        /// </summary>
        [pbr::OriginalName("START_DATE_AFTER_END_DATE")] StartDateAfterEndDate = 58,
        /// <summary>
        /// Input price is not in a valid format.
        /// </summary>
        [pbr::OriginalName("INVALID_PRICE_FORMAT")] InvalidPriceFormat = 59,
        /// <summary>
        /// The promotion time is invalid.
        /// </summary>
        [pbr::OriginalName("PROMOTION_INVALID_TIME")] PromotionInvalidTime = 60,
        /// <summary>
        /// Cannot set both percent discount and money discount fields.
        /// </summary>
        [pbr::OriginalName("PROMOTION_CANNOT_SET_PERCENT_DISCOUNT_AND_MONEY_DISCOUNT")] PromotionCannotSetPercentDiscountAndMoneyDiscount = 61,
        /// <summary>
        /// Cannot set both promotion code and orders over amount fields.
        /// </summary>
        [pbr::OriginalName("PROMOTION_CANNOT_SET_PROMOTION_CODE_AND_ORDERS_OVER_AMOUNT")] PromotionCannotSetPromotionCodeAndOrdersOverAmount = 62,
        /// <summary>
        /// This field has too many decimal places specified.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_DECIMAL_PLACES_SPECIFIED")] TooManyDecimalPlacesSpecified = 63,
        /// <summary>
        /// The language code is not valid.
        /// </summary>
        [pbr::OriginalName("INVALID_LANGUAGE_CODE")] InvalidLanguageCode = 64,
        /// <summary>
        /// The language is not supported.
        /// </summary>
        [pbr::OriginalName("UNSUPPORTED_LANGUAGE")] UnsupportedLanguage = 65,
        /// <summary>
        /// Customer hasn't consented for call recording, which is required for
        /// adding/updating call extensions. Please see
        /// https://support.google.com/google-ads/answer/7412639.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_CONSENT_FOR_CALL_RECORDING_REQUIRED")] CustomerConsentForCallRecordingRequired = 66,
        /// <summary>
        /// The UPDATE operation does not specify any fields other than the resource
        /// name in the update mask.
        /// </summary>
        [pbr::OriginalName("EXTENSION_SETTING_UPDATE_IS_A_NOOP")] ExtensionSettingUpdateIsANoop = 67,
        /// <summary>
        /// The extension contains text which has been prohibited on policy grounds.
        /// </summary>
        [pbr::OriginalName("DISALLOWED_TEXT")] DisallowedText = 68,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
