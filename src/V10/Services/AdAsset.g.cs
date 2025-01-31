// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/common/ad_asset.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/common/ad_asset.proto</summary>
  public static partial class AdAssetReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/common/ad_asset.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdAssetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5nb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvY29tbW9uL2FkX2Fzc2V0LnBy",
            "b3RvEh9nb29nbGUuYWRzLmdvb2dsZWFkcy52MTAuY29tbW9uGjJnb29nbGUv",
            "YWRzL2dvb2dsZWFkcy92MTAvY29tbW9uL2Fzc2V0X3BvbGljeS5wcm90bxo8",
            "Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjEwL2VudW1zL2Fzc2V0X3BlcmZvcm1h",
            "bmNlX2xhYmVsLnByb3RvGjxnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZW51",
            "bXMvc2VydmVkX2Fzc2V0X2ZpZWxkX3R5cGUucHJvdG8aHGdvb2dsZS9hcGkv",
            "YW5ub3RhdGlvbnMucHJvdG8i1AIKC0FkVGV4dEFzc2V0EhEKBHRleHQYBCAB",
            "KAlIAIgBARJjCgxwaW5uZWRfZmllbGQYAiABKA4yTS5nb29nbGUuYWRzLmdv",
            "b2dsZWFkcy52MTAuZW51bXMuU2VydmVkQXNzZXRGaWVsZFR5cGVFbnVtLlNl",
            "cnZlZEFzc2V0RmllbGRUeXBlEnAKF2Fzc2V0X3BlcmZvcm1hbmNlX2xhYmVs",
            "GAUgASgOMk8uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEwLmVudW1zLkFzc2V0",
            "UGVyZm9ybWFuY2VMYWJlbEVudW0uQXNzZXRQZXJmb3JtYW5jZUxhYmVsElIK",
            "E3BvbGljeV9zdW1tYXJ5X2luZm8YBiABKAsyNS5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52MTAuY29tbW9uLkFkQXNzZXRQb2xpY3lTdW1tYXJ5QgcKBV90ZXh0",
            "IiwKDEFkSW1hZ2VBc3NldBISCgVhc3NldBgCIAEoCUgAiAEBQggKBl9hc3Nl",
            "dCIsCgxBZFZpZGVvQXNzZXQSEgoFYXNzZXQYAiABKAlIAIgBAUIICgZfYXNz",
            "ZXQiMgoSQWRNZWRpYUJ1bmRsZUFzc2V0EhIKBWFzc2V0GAIgASgJSACIAQFC",
            "CAoGX2Fzc2V0QuwBCiNjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEwLmNv",
            "bW1vbkIMQWRBc3NldFByb3RvUAFaRWdvb2dsZS5nb2xhbmcub3JnL2dlbnBy",
            "b3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTAvY29tbW9uO2NvbW1v",
            "bqICA0dBQaoCH0dvb2dsZS5BZHMuR29vZ2xlQWRzLlYxMC5Db21tb27KAh9H",
            "b29nbGVcQWRzXEdvb2dsZUFkc1xWMTBcQ29tbW9u6gIjR29vZ2xlOjpBZHM6",
            "Okdvb2dsZUFkczo6VjEwOjpDb21tb25iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V10.Common.AssetPolicyReflection.Descriptor, global::Google.Ads.GoogleAds.V10.Enums.AssetPerformanceLabelReflection.Descriptor, global::Google.Ads.GoogleAds.V10.Enums.ServedAssetFieldTypeReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Common.AdTextAsset), global::Google.Ads.GoogleAds.V10.Common.AdTextAsset.Parser, new[]{ "Text", "PinnedField", "AssetPerformanceLabel", "PolicySummaryInfo" }, new[]{ "Text" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Common.AdImageAsset), global::Google.Ads.GoogleAds.V10.Common.AdImageAsset.Parser, new[]{ "Asset" }, new[]{ "Asset" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Common.AdVideoAsset), global::Google.Ads.GoogleAds.V10.Common.AdVideoAsset.Parser, new[]{ "Asset" }, new[]{ "Asset" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Common.AdMediaBundleAsset), global::Google.Ads.GoogleAds.V10.Common.AdMediaBundleAsset.Parser, new[]{ "Asset" }, new[]{ "Asset" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A text asset used inside an ad.
  /// </summary>
  public sealed partial class AdTextAsset : pb::IMessage<AdTextAsset>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdTextAsset> _parser = new pb::MessageParser<AdTextAsset>(() => new AdTextAsset());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdTextAsset> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Common.AdAssetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdTextAsset() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdTextAsset(AdTextAsset other) : this() {
      text_ = other.text_;
      pinnedField_ = other.pinnedField_;
      assetPerformanceLabel_ = other.assetPerformanceLabel_;
      policySummaryInfo_ = other.policySummaryInfo_ != null ? other.policySummaryInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdTextAsset Clone() {
      return new AdTextAsset(this);
    }

    /// <summary>Field number for the "text" field.</summary>
    public const int TextFieldNumber = 4;
    private string text_;
    /// <summary>
    /// Asset text.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Text {
      get { return text_ ?? ""; }
      set {
        text_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "text" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasText {
      get { return text_ != null; }
    }
    /// <summary>Clears the value of the "text" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearText() {
      text_ = null;
    }

    /// <summary>Field number for the "pinned_field" field.</summary>
    public const int PinnedFieldFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V10.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType pinnedField_ = global::Google.Ads.GoogleAds.V10.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType.Unspecified;
    /// <summary>
    /// The pinned field of the asset. This restricts the asset to only serve
    /// within this field. Multiple assets can be pinned to the same field. An
    /// asset that is unpinned or pinned to a different field will not serve in a
    /// field where some other asset has been pinned.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V10.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType PinnedField {
      get { return pinnedField_; }
      set {
        pinnedField_ = value;
      }
    }

    /// <summary>Field number for the "asset_performance_label" field.</summary>
    public const int AssetPerformanceLabelFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V10.Enums.AssetPerformanceLabelEnum.Types.AssetPerformanceLabel assetPerformanceLabel_ = global::Google.Ads.GoogleAds.V10.Enums.AssetPerformanceLabelEnum.Types.AssetPerformanceLabel.Unspecified;
    /// <summary>
    /// The performance label of this text asset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V10.Enums.AssetPerformanceLabelEnum.Types.AssetPerformanceLabel AssetPerformanceLabel {
      get { return assetPerformanceLabel_; }
      set {
        assetPerformanceLabel_ = value;
      }
    }

    /// <summary>Field number for the "policy_summary_info" field.</summary>
    public const int PolicySummaryInfoFieldNumber = 6;
    private global::Google.Ads.GoogleAds.V10.Common.AdAssetPolicySummary policySummaryInfo_;
    /// <summary>
    /// The policy summary of this text asset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V10.Common.AdAssetPolicySummary PolicySummaryInfo {
      get { return policySummaryInfo_; }
      set {
        policySummaryInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AdTextAsset);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AdTextAsset other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Text != other.Text) return false;
      if (PinnedField != other.PinnedField) return false;
      if (AssetPerformanceLabel != other.AssetPerformanceLabel) return false;
      if (!object.Equals(PolicySummaryInfo, other.PolicySummaryInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasText) hash ^= Text.GetHashCode();
      if (PinnedField != global::Google.Ads.GoogleAds.V10.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType.Unspecified) hash ^= PinnedField.GetHashCode();
      if (AssetPerformanceLabel != global::Google.Ads.GoogleAds.V10.Enums.AssetPerformanceLabelEnum.Types.AssetPerformanceLabel.Unspecified) hash ^= AssetPerformanceLabel.GetHashCode();
      if (policySummaryInfo_ != null) hash ^= PolicySummaryInfo.GetHashCode();
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
      if (PinnedField != global::Google.Ads.GoogleAds.V10.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) PinnedField);
      }
      if (HasText) {
        output.WriteRawTag(34);
        output.WriteString(Text);
      }
      if (AssetPerformanceLabel != global::Google.Ads.GoogleAds.V10.Enums.AssetPerformanceLabelEnum.Types.AssetPerformanceLabel.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) AssetPerformanceLabel);
      }
      if (policySummaryInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(PolicySummaryInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (PinnedField != global::Google.Ads.GoogleAds.V10.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) PinnedField);
      }
      if (HasText) {
        output.WriteRawTag(34);
        output.WriteString(Text);
      }
      if (AssetPerformanceLabel != global::Google.Ads.GoogleAds.V10.Enums.AssetPerformanceLabelEnum.Types.AssetPerformanceLabel.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) AssetPerformanceLabel);
      }
      if (policySummaryInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(PolicySummaryInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HasText) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Text);
      }
      if (PinnedField != global::Google.Ads.GoogleAds.V10.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PinnedField);
      }
      if (AssetPerformanceLabel != global::Google.Ads.GoogleAds.V10.Enums.AssetPerformanceLabelEnum.Types.AssetPerformanceLabel.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AssetPerformanceLabel);
      }
      if (policySummaryInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PolicySummaryInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AdTextAsset other) {
      if (other == null) {
        return;
      }
      if (other.HasText) {
        Text = other.Text;
      }
      if (other.PinnedField != global::Google.Ads.GoogleAds.V10.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType.Unspecified) {
        PinnedField = other.PinnedField;
      }
      if (other.AssetPerformanceLabel != global::Google.Ads.GoogleAds.V10.Enums.AssetPerformanceLabelEnum.Types.AssetPerformanceLabel.Unspecified) {
        AssetPerformanceLabel = other.AssetPerformanceLabel;
      }
      if (other.policySummaryInfo_ != null) {
        if (policySummaryInfo_ == null) {
          PolicySummaryInfo = new global::Google.Ads.GoogleAds.V10.Common.AdAssetPolicySummary();
        }
        PolicySummaryInfo.MergeFrom(other.PolicySummaryInfo);
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
          case 16: {
            PinnedField = (global::Google.Ads.GoogleAds.V10.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType) input.ReadEnum();
            break;
          }
          case 34: {
            Text = input.ReadString();
            break;
          }
          case 40: {
            AssetPerformanceLabel = (global::Google.Ads.GoogleAds.V10.Enums.AssetPerformanceLabelEnum.Types.AssetPerformanceLabel) input.ReadEnum();
            break;
          }
          case 50: {
            if (policySummaryInfo_ == null) {
              PolicySummaryInfo = new global::Google.Ads.GoogleAds.V10.Common.AdAssetPolicySummary();
            }
            input.ReadMessage(PolicySummaryInfo);
            break;
          }
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
          case 16: {
            PinnedField = (global::Google.Ads.GoogleAds.V10.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType) input.ReadEnum();
            break;
          }
          case 34: {
            Text = input.ReadString();
            break;
          }
          case 40: {
            AssetPerformanceLabel = (global::Google.Ads.GoogleAds.V10.Enums.AssetPerformanceLabelEnum.Types.AssetPerformanceLabel) input.ReadEnum();
            break;
          }
          case 50: {
            if (policySummaryInfo_ == null) {
              PolicySummaryInfo = new global::Google.Ads.GoogleAds.V10.Common.AdAssetPolicySummary();
            }
            input.ReadMessage(PolicySummaryInfo);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// An image asset used inside an ad.
  /// </summary>
  public sealed partial class AdImageAsset : pb::IMessage<AdImageAsset>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdImageAsset> _parser = new pb::MessageParser<AdImageAsset>(() => new AdImageAsset());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdImageAsset> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Common.AdAssetReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdImageAsset() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdImageAsset(AdImageAsset other) : this() {
      asset_ = other.asset_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdImageAsset Clone() {
      return new AdImageAsset(this);
    }

    /// <summary>Field number for the "asset" field.</summary>
    public const int AssetFieldNumber = 2;
    private string asset_;
    /// <summary>
    /// The Asset resource name of this image.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Asset {
      get { return asset_ ?? ""; }
      set {
        asset_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "asset" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasAsset {
      get { return asset_ != null; }
    }
    /// <summary>Clears the value of the "asset" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearAsset() {
      asset_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AdImageAsset);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AdImageAsset other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Asset != other.Asset) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasAsset) hash ^= Asset.GetHashCode();
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
      if (HasAsset) {
        output.WriteRawTag(18);
        output.WriteString(Asset);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasAsset) {
        output.WriteRawTag(18);
        output.WriteString(Asset);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HasAsset) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Asset);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AdImageAsset other) {
      if (other == null) {
        return;
      }
      if (other.HasAsset) {
        Asset = other.Asset;
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
          case 18: {
            Asset = input.ReadString();
            break;
          }
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
          case 18: {
            Asset = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// A video asset used inside an ad.
  /// </summary>
  public sealed partial class AdVideoAsset : pb::IMessage<AdVideoAsset>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdVideoAsset> _parser = new pb::MessageParser<AdVideoAsset>(() => new AdVideoAsset());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdVideoAsset> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Common.AdAssetReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdVideoAsset() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdVideoAsset(AdVideoAsset other) : this() {
      asset_ = other.asset_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdVideoAsset Clone() {
      return new AdVideoAsset(this);
    }

    /// <summary>Field number for the "asset" field.</summary>
    public const int AssetFieldNumber = 2;
    private string asset_;
    /// <summary>
    /// The Asset resource name of this video.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Asset {
      get { return asset_ ?? ""; }
      set {
        asset_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "asset" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasAsset {
      get { return asset_ != null; }
    }
    /// <summary>Clears the value of the "asset" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearAsset() {
      asset_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AdVideoAsset);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AdVideoAsset other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Asset != other.Asset) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasAsset) hash ^= Asset.GetHashCode();
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
      if (HasAsset) {
        output.WriteRawTag(18);
        output.WriteString(Asset);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasAsset) {
        output.WriteRawTag(18);
        output.WriteString(Asset);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HasAsset) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Asset);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AdVideoAsset other) {
      if (other == null) {
        return;
      }
      if (other.HasAsset) {
        Asset = other.Asset;
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
          case 18: {
            Asset = input.ReadString();
            break;
          }
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
          case 18: {
            Asset = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// A media bundle asset used inside an ad.
  /// </summary>
  public sealed partial class AdMediaBundleAsset : pb::IMessage<AdMediaBundleAsset>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdMediaBundleAsset> _parser = new pb::MessageParser<AdMediaBundleAsset>(() => new AdMediaBundleAsset());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdMediaBundleAsset> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Common.AdAssetReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdMediaBundleAsset() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdMediaBundleAsset(AdMediaBundleAsset other) : this() {
      asset_ = other.asset_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdMediaBundleAsset Clone() {
      return new AdMediaBundleAsset(this);
    }

    /// <summary>Field number for the "asset" field.</summary>
    public const int AssetFieldNumber = 2;
    private string asset_;
    /// <summary>
    /// The Asset resource name of this media bundle.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Asset {
      get { return asset_ ?? ""; }
      set {
        asset_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "asset" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasAsset {
      get { return asset_ != null; }
    }
    /// <summary>Clears the value of the "asset" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearAsset() {
      asset_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AdMediaBundleAsset);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AdMediaBundleAsset other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Asset != other.Asset) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasAsset) hash ^= Asset.GetHashCode();
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
      if (HasAsset) {
        output.WriteRawTag(18);
        output.WriteString(Asset);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasAsset) {
        output.WriteRawTag(18);
        output.WriteString(Asset);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HasAsset) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Asset);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AdMediaBundleAsset other) {
      if (other == null) {
        return;
      }
      if (other.HasAsset) {
        Asset = other.Asset;
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
          case 18: {
            Asset = input.ReadString();
            break;
          }
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
          case 18: {
            Asset = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
