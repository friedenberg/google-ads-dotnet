// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/enums/product_type_level.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/enums/product_type_level.proto</summary>
  public static partial class ProductTypeLevelReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/enums/product_type_level.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProductTypeLevelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy9wcm9kdWN0X3R5cGVf",
            "bGV2ZWwucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLmVudW1zGhxn",
            "b29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIoQBChRQcm9kdWN0VHlwZUxl",
            "dmVsRW51bSJsChBQcm9kdWN0VHlwZUxldmVsEg8KC1VOU1BFQ0lGSUVEEAAS",
            "CwoHVU5LTk9XThABEgoKBkxFVkVMMRAHEgoKBkxFVkVMMhAIEgoKBkxFVkVM",
            "MxAJEgoKBkxFVkVMNBAKEgoKBkxFVkVMNRALQuoBCiFjb20uZ29vZ2xlLmFk",
            "cy5nb29nbGVhZHMudjIuZW51bXNCFVByb2R1Y3RUeXBlTGV2ZWxQcm90b1AB",
            "WkJnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9n",
            "b29nbGVhZHMvdjIvZW51bXM7ZW51bXOiAgNHQUGqAh1Hb29nbGUuQWRzLkdv",
            "b2dsZUFkcy5WMi5FbnVtc8oCHUdvb2dsZVxBZHNcR29vZ2xlQWRzXFYyXEVu",
            "dW1z6gIhR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjI6OkVudW1zYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Enums.ProductTypeLevelEnum), global::Google.Ads.GoogleAds.V2.Enums.ProductTypeLevelEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Enums.ProductTypeLevelEnum.Types.ProductTypeLevel) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Level of the type of a product offer.
  /// </summary>
  public sealed partial class ProductTypeLevelEnum : pb::IMessage<ProductTypeLevelEnum> {
    private static readonly pb::MessageParser<ProductTypeLevelEnum> _parser = new pb::MessageParser<ProductTypeLevelEnum>(() => new ProductTypeLevelEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProductTypeLevelEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Enums.ProductTypeLevelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductTypeLevelEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductTypeLevelEnum(ProductTypeLevelEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductTypeLevelEnum Clone() {
      return new ProductTypeLevelEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProductTypeLevelEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProductTypeLevelEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProductTypeLevelEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ProductTypeLevelEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing the level of the type of a product offer.
      /// </summary>
      public enum ProductTypeLevel {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Level 1.
        /// </summary>
        [pbr::OriginalName("LEVEL1")] Level1 = 7,
        /// <summary>
        /// Level 2.
        /// </summary>
        [pbr::OriginalName("LEVEL2")] Level2 = 8,
        /// <summary>
        /// Level 3.
        /// </summary>
        [pbr::OriginalName("LEVEL3")] Level3 = 9,
        /// <summary>
        /// Level 4.
        /// </summary>
        [pbr::OriginalName("LEVEL4")] Level4 = 10,
        /// <summary>
        /// Level 5.
        /// </summary>
        [pbr::OriginalName("LEVEL5")] Level5 = 11,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code