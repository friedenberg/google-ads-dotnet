// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/errors/ad_group_ad_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/errors/ad_group_ad_error.proto</summary>
  public static partial class AdGroupAdErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/errors/ad_group_ad_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupAdErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZXJyb3JzL2FkX2dyb3VwX2Fk",
            "X2Vycm9yLnByb3RvEh9nb29nbGUuYWRzLmdvb2dsZWFkcy52MTAuZXJyb3Jz",
            "Ghxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIqsDChJBZEdyb3VwQWRF",
            "cnJvckVudW0ilAMKDkFkR3JvdXBBZEVycm9yEg8KC1VOU1BFQ0lGSUVEEAAS",
            "CwoHVU5LTk9XThABEiQKIEFEX0dST1VQX0FEX0xBQkVMX0RPRVNfTk9UX0VY",
            "SVNUEAISJAogQURfR1JPVVBfQURfTEFCRUxfQUxSRUFEWV9FWElTVFMQAxIY",
            "ChRBRF9OT1RfVU5ERVJfQURHUk9VUBAEEicKI0NBTk5PVF9PUEVSQVRFX09O",
            "X1JFTU9WRURfQURHUk9VUEFEEAUSIAocQ0FOTk9UX0NSRUFURV9ERVBSRUNB",
            "VEVEX0FEUxAGEhoKFkNBTk5PVF9DUkVBVEVfVEVYVF9BRFMQBxIPCgtFTVBU",
            "WV9GSUVMRBAIEicKI1JFU09VUkNFX1JFRkVSRU5DRURfSU5fTVVMVElQTEVf",
            "T1BTEAkSHAoYQURfVFlQRV9DQU5OT1RfQkVfUEFVU0VEEAoSHQoZQURfVFlQ",
            "RV9DQU5OT1RfQkVfUkVNT1ZFRBALEiAKHENBTk5PVF9VUERBVEVfREVQUkVD",
            "QVRFRF9BRFMQDELzAQojY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMC5l",
            "cnJvcnNCE0FkR3JvdXBBZEVycm9yUHJvdG9QAVpFZ29vZ2xlLmdvbGFuZy5v",
            "cmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YxMC9lcnJv",
            "cnM7ZXJyb3JzogIDR0FBqgIfR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjEwLkVy",
            "cm9yc8oCH0dvb2dsZVxBZHNcR29vZ2xlQWRzXFYxMFxFcnJvcnPqAiNHb29n",
            "bGU6OkFkczo6R29vZ2xlQWRzOjpWMTA6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Errors.AdGroupAdErrorEnum), global::Google.Ads.GoogleAds.V10.Errors.AdGroupAdErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V10.Errors.AdGroupAdErrorEnum.Types.AdGroupAdError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible ad group ad errors.
  /// </summary>
  public sealed partial class AdGroupAdErrorEnum : pb::IMessage<AdGroupAdErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdGroupAdErrorEnum> _parser = new pb::MessageParser<AdGroupAdErrorEnum>(() => new AdGroupAdErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdGroupAdErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Errors.AdGroupAdErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupAdErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupAdErrorEnum(AdGroupAdErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupAdErrorEnum Clone() {
      return new AdGroupAdErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AdGroupAdErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AdGroupAdErrorEnum other) {
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
    public void MergeFrom(AdGroupAdErrorEnum other) {
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
    /// <summary>Container for nested types declared in the AdGroupAdErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible ad group ad errors.
      /// </summary>
      public enum AdGroupAdError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// No link found between the adgroup ad and the label.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_AD_LABEL_DOES_NOT_EXIST")] AdGroupAdLabelDoesNotExist = 2,
        /// <summary>
        /// The label has already been attached to the adgroup ad.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_AD_LABEL_ALREADY_EXISTS")] AdGroupAdLabelAlreadyExists = 3,
        /// <summary>
        /// The specified ad was not found in the adgroup
        /// </summary>
        [pbr::OriginalName("AD_NOT_UNDER_ADGROUP")] AdNotUnderAdgroup = 4,
        /// <summary>
        /// Removed ads may not be modified
        /// </summary>
        [pbr::OriginalName("CANNOT_OPERATE_ON_REMOVED_ADGROUPAD")] CannotOperateOnRemovedAdgroupad = 5,
        /// <summary>
        /// An ad of this type is deprecated and cannot be created. Only deletions
        /// are permitted.
        /// </summary>
        [pbr::OriginalName("CANNOT_CREATE_DEPRECATED_ADS")] CannotCreateDeprecatedAds = 6,
        /// <summary>
        /// Text ads are deprecated and cannot be created. Use expanded text ads
        /// instead.
        /// </summary>
        [pbr::OriginalName("CANNOT_CREATE_TEXT_ADS")] CannotCreateTextAds = 7,
        /// <summary>
        /// A required field was not specified or is an empty string.
        /// </summary>
        [pbr::OriginalName("EMPTY_FIELD")] EmptyField = 8,
        /// <summary>
        /// An ad may only be modified once per call
        /// </summary>
        [pbr::OriginalName("RESOURCE_REFERENCED_IN_MULTIPLE_OPS")] ResourceReferencedInMultipleOps = 9,
        /// <summary>
        /// AdGroupAds with the given ad type cannot be paused.
        /// </summary>
        [pbr::OriginalName("AD_TYPE_CANNOT_BE_PAUSED")] AdTypeCannotBePaused = 10,
        /// <summary>
        /// AdGroupAds with the given ad type cannot be removed.
        /// </summary>
        [pbr::OriginalName("AD_TYPE_CANNOT_BE_REMOVED")] AdTypeCannotBeRemoved = 11,
        /// <summary>
        /// An ad of this type is deprecated and cannot be updated. Only removals
        /// are permitted.
        /// </summary>
        [pbr::OriginalName("CANNOT_UPDATE_DEPRECATED_ADS")] CannotUpdateDeprecatedAds = 12,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
