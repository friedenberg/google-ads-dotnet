// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/errors/query_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/errors/query_error.proto</summary>
  public static partial class QueryErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/errors/query_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QueryErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZXJyb3JzL3F1ZXJ5X2Vycm9y",
            "LnByb3RvEh9nb29nbGUuYWRzLmdvb2dsZWFkcy52MTAuZXJyb3JzGhxnb29n",
            "bGUvYXBpL2Fubm90YXRpb25zLnByb3RvIpMOCg5RdWVyeUVycm9yRW51bSKA",
            "DgoKUXVlcnlFcnJvchIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIP",
            "CgtRVUVSWV9FUlJPUhAyEhUKEUJBRF9FTlVNX0NPTlNUQU5UEBISFwoTQkFE",
            "X0VTQ0FQRV9TRVFVRU5DRRAHEhIKDkJBRF9GSUVMRF9OQU1FEAwSEwoPQkFE",
            "X0xJTUlUX1ZBTFVFEA8SDgoKQkFEX05VTUJFUhAFEhAKDEJBRF9PUEVSQVRP",
            "UhADEhYKEkJBRF9QQVJBTUVURVJfTkFNRRA9EhcKE0JBRF9QQVJBTUVURVJf",
            "VkFMVUUQPhIkCiBCQURfUkVTT1VSQ0VfVFlQRV9JTl9GUk9NX0NMQVVTRRAt",
            "Eg4KCkJBRF9TWU1CT0wQAhINCglCQURfVkFMVUUQBBIXChNEQVRFX1JBTkdF",
            "X1RPT19XSURFECQSGQoVREFURV9SQU5HRV9UT09fTkFSUk9XEDwSEAoMRVhQ",
            "RUNURURfQU5EEB4SDwoLRVhQRUNURURfQlkQDhItCilFWFBFQ1RFRF9ESU1F",
            "TlNJT05fRklFTERfSU5fU0VMRUNUX0NMQVVTRRAlEiIKHkVYUEVDVEVEX0ZJ",
            "TFRFUlNfT05fREFURV9SQU5HRRA3EhEKDUVYUEVDVEVEX0ZST00QLBIRCg1F",
            "WFBFQ1RFRF9MSVNUECkSLgoqRVhQRUNURURfUkVGRVJFTkNFRF9GSUVMRF9J",
            "Tl9TRUxFQ1RfQ0xBVVNFEBASEwoPRVhQRUNURURfU0VMRUNUEA0SGQoVRVhQ",
            "RUNURURfU0lOR0xFX1ZBTFVFECoSKAokRVhQRUNURURfVkFMVUVfV0lUSF9C",
            "RVRXRUVOX09QRVJBVE9SEB0SFwoTSU5WQUxJRF9EQVRFX0ZPUk1BVBAmEh4K",
            "Gk1JU0FMSUdORURfREFURV9GT1JfRklMVEVSEEASGAoUSU5WQUxJRF9TVFJJ",
            "TkdfVkFMVUUQORInCiNJTlZBTElEX1ZBTFVFX1dJVEhfQkVUV0VFTl9PUEVS",
            "QVRPUhAaEiYKIklOVkFMSURfVkFMVUVfV0lUSF9EVVJJTkdfT1BFUkFUT1IQ",
            "FhIkCiBJTlZBTElEX1ZBTFVFX1dJVEhfTElLRV9PUEVSQVRPUhA4EhsKF09Q",
            "RVJBVE9SX0ZJRUxEX01JU01BVENIECMSJgoiUFJPSElCSVRFRF9FTVBUWV9M",
            "SVNUX0lOX0NPTkRJVElPThAcEhwKGFBST0hJQklURURfRU5VTV9DT05TVEFO",
            "VBA2EjEKLVBST0hJQklURURfRklFTERfQ09NQklOQVRJT05fSU5fU0VMRUNU",
            "X0NMQVVTRRAfEicKI1BST0hJQklURURfRklFTERfSU5fT1JERVJfQllfQ0xB",
            "VVNFECgSJQohUFJPSElCSVRFRF9GSUVMRF9JTl9TRUxFQ1RfQ0xBVVNFEBcS",
            "JAogUFJPSElCSVRFRF9GSUVMRF9JTl9XSEVSRV9DTEFVU0UQGBIrCidQUk9I",
            "SUJJVEVEX1JFU09VUkNFX1RZUEVfSU5fRlJPTV9DTEFVU0UQKxItCilQUk9I",
            "SUJJVEVEX1JFU09VUkNFX1RZUEVfSU5fU0VMRUNUX0NMQVVTRRAwEiwKKFBS",
            "T0hJQklURURfUkVTT1VSQ0VfVFlQRV9JTl9XSEVSRV9DTEFVU0UQOhIvCitQ",
            "Uk9ISUJJVEVEX01FVFJJQ19JTl9TRUxFQ1RfT1JfV0hFUkVfQ0xBVVNFEDES",
            "MAosUFJPSElCSVRFRF9TRUdNRU5UX0lOX1NFTEVDVF9PUl9XSEVSRV9DTEFV",
            "U0UQMxI8CjhQUk9ISUJJVEVEX1NFR01FTlRfV0lUSF9NRVRSSUNfSU5fU0VM",
            "RUNUX09SX1dIRVJFX0NMQVVTRRA1EhcKE0xJTUlUX1ZBTFVFX1RPT19MT1cQ",
            "GRIgChxQUk9ISUJJVEVEX05FV0xJTkVfSU5fU1RSSU5HEAgSKAokUFJPSElC",
            "SVRFRF9WQUxVRV9DT01CSU5BVElPTl9JTl9MSVNUEAoSNgoyUFJPSElCSVRF",
            "RF9WQUxVRV9DT01CSU5BVElPTl9XSVRIX0JFVFdFRU5fT1BFUkFUT1IQFRIZ",
            "ChVTVFJJTkdfTk9UX1RFUk1JTkFURUQQBhIVChFUT09fTUFOWV9TRUdNRU5U",
            "UxAiEhsKF1VORVhQRUNURURfRU5EX09GX1FVRVJZEAkSGgoWVU5FWFBFQ1RF",
            "RF9GUk9NX0NMQVVTRRAvEhYKElVOUkVDT0dOSVpFRF9GSUVMRBAgEhQKEFVO",
            "RVhQRUNURURfSU5QVVQQCxIhCh1SRVFVRVNURURfTUVUUklDU19GT1JfTUFO",
            "QUdFUhA7Eh4KGkZJTFRFUl9IQVNfVE9PX01BTllfVkFMVUVTED9C7wEKI2Nv",
            "bS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTAuZXJyb3JzQg9RdWVyeUVycm9y",
            "UHJvdG9QAVpFZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBp",
            "cy9hZHMvZ29vZ2xlYWRzL3YxMC9lcnJvcnM7ZXJyb3JzogIDR0FBqgIfR29v",
            "Z2xlLkFkcy5Hb29nbGVBZHMuVjEwLkVycm9yc8oCH0dvb2dsZVxBZHNcR29v",
            "Z2xlQWRzXFYxMFxFcnJvcnPqAiNHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpW",
            "MTA6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Errors.QueryErrorEnum), global::Google.Ads.GoogleAds.V10.Errors.QueryErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V10.Errors.QueryErrorEnum.Types.QueryError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible query errors.
  /// </summary>
  public sealed partial class QueryErrorEnum : pb::IMessage<QueryErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QueryErrorEnum> _parser = new pb::MessageParser<QueryErrorEnum>(() => new QueryErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<QueryErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Errors.QueryErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryErrorEnum(QueryErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryErrorEnum Clone() {
      return new QueryErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as QueryErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(QueryErrorEnum other) {
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
    public void MergeFrom(QueryErrorEnum other) {
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
    /// <summary>Container for nested types declared in the QueryErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible query errors.
      /// </summary>
      public enum QueryError {
        /// <summary>
        /// Name unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Returned if all other query error reasons are not applicable.
        /// </summary>
        [pbr::OriginalName("QUERY_ERROR")] QueryError = 50,
        /// <summary>
        /// A condition used in the query references an invalid enum constant.
        /// </summary>
        [pbr::OriginalName("BAD_ENUM_CONSTANT")] BadEnumConstant = 18,
        /// <summary>
        /// Query contains an invalid escape sequence.
        /// </summary>
        [pbr::OriginalName("BAD_ESCAPE_SEQUENCE")] BadEscapeSequence = 7,
        /// <summary>
        /// Field name is invalid.
        /// </summary>
        [pbr::OriginalName("BAD_FIELD_NAME")] BadFieldName = 12,
        /// <summary>
        /// Limit value is invalid (i.e. not a number)
        /// </summary>
        [pbr::OriginalName("BAD_LIMIT_VALUE")] BadLimitValue = 15,
        /// <summary>
        /// Encountered number can not be parsed.
        /// </summary>
        [pbr::OriginalName("BAD_NUMBER")] BadNumber = 5,
        /// <summary>
        /// Invalid operator encountered.
        /// </summary>
        [pbr::OriginalName("BAD_OPERATOR")] BadOperator = 3,
        /// <summary>
        /// Parameter unknown or not supported.
        /// </summary>
        [pbr::OriginalName("BAD_PARAMETER_NAME")] BadParameterName = 61,
        /// <summary>
        /// Parameter have invalid value.
        /// </summary>
        [pbr::OriginalName("BAD_PARAMETER_VALUE")] BadParameterValue = 62,
        /// <summary>
        /// Invalid resource type was specified in the FROM clause.
        /// </summary>
        [pbr::OriginalName("BAD_RESOURCE_TYPE_IN_FROM_CLAUSE")] BadResourceTypeInFromClause = 45,
        /// <summary>
        /// Non-ASCII symbol encountered outside of strings.
        /// </summary>
        [pbr::OriginalName("BAD_SYMBOL")] BadSymbol = 2,
        /// <summary>
        /// Value is invalid.
        /// </summary>
        [pbr::OriginalName("BAD_VALUE")] BadValue = 4,
        /// <summary>
        /// Date filters fail to restrict date to a range smaller than 31 days.
        /// Applicable if the query is segmented by date.
        /// </summary>
        [pbr::OriginalName("DATE_RANGE_TOO_WIDE")] DateRangeTooWide = 36,
        /// <summary>
        /// Filters on date/week/month/quarter have a start date after
        /// end date.
        /// </summary>
        [pbr::OriginalName("DATE_RANGE_TOO_NARROW")] DateRangeTooNarrow = 60,
        /// <summary>
        /// Expected AND between values with BETWEEN operator.
        /// </summary>
        [pbr::OriginalName("EXPECTED_AND")] ExpectedAnd = 30,
        /// <summary>
        /// Expecting ORDER BY to have BY.
        /// </summary>
        [pbr::OriginalName("EXPECTED_BY")] ExpectedBy = 14,
        /// <summary>
        /// There was no dimension field selected.
        /// </summary>
        [pbr::OriginalName("EXPECTED_DIMENSION_FIELD_IN_SELECT_CLAUSE")] ExpectedDimensionFieldInSelectClause = 37,
        /// <summary>
        /// Missing filters on date related fields.
        /// </summary>
        [pbr::OriginalName("EXPECTED_FILTERS_ON_DATE_RANGE")] ExpectedFiltersOnDateRange = 55,
        /// <summary>
        /// Missing FROM clause.
        /// </summary>
        [pbr::OriginalName("EXPECTED_FROM")] ExpectedFrom = 44,
        /// <summary>
        /// The operator used in the conditions requires the value to be a list.
        /// </summary>
        [pbr::OriginalName("EXPECTED_LIST")] ExpectedList = 41,
        /// <summary>
        /// Fields used in WHERE or ORDER BY clauses are missing from the SELECT
        /// clause.
        /// </summary>
        [pbr::OriginalName("EXPECTED_REFERENCED_FIELD_IN_SELECT_CLAUSE")] ExpectedReferencedFieldInSelectClause = 16,
        /// <summary>
        /// SELECT is missing at the beginning of query.
        /// </summary>
        [pbr::OriginalName("EXPECTED_SELECT")] ExpectedSelect = 13,
        /// <summary>
        /// A list was passed as a value to a condition whose operator expects a
        /// single value.
        /// </summary>
        [pbr::OriginalName("EXPECTED_SINGLE_VALUE")] ExpectedSingleValue = 42,
        /// <summary>
        /// Missing one or both values with BETWEEN operator.
        /// </summary>
        [pbr::OriginalName("EXPECTED_VALUE_WITH_BETWEEN_OPERATOR")] ExpectedValueWithBetweenOperator = 29,
        /// <summary>
        /// Invalid date format. Expected 'YYYY-MM-DD'.
        /// </summary>
        [pbr::OriginalName("INVALID_DATE_FORMAT")] InvalidDateFormat = 38,
        /// <summary>
        /// Misaligned date value for the filter. The date should be the start of a
        /// week/month/quarter if the filtered field is
        /// segments.week/segments.month/segments.quarter.
        /// </summary>
        [pbr::OriginalName("MISALIGNED_DATE_FOR_FILTER")] MisalignedDateForFilter = 64,
        /// <summary>
        /// Value passed was not a string when it should have been. I.e., it was a
        /// number or unquoted literal.
        /// </summary>
        [pbr::OriginalName("INVALID_STRING_VALUE")] InvalidStringValue = 57,
        /// <summary>
        /// A String value passed to the BETWEEN operator does not parse as a date.
        /// </summary>
        [pbr::OriginalName("INVALID_VALUE_WITH_BETWEEN_OPERATOR")] InvalidValueWithBetweenOperator = 26,
        /// <summary>
        /// The value passed to the DURING operator is not a Date range literal
        /// </summary>
        [pbr::OriginalName("INVALID_VALUE_WITH_DURING_OPERATOR")] InvalidValueWithDuringOperator = 22,
        /// <summary>
        /// An invalid value was passed to the LIKE operator.
        /// </summary>
        [pbr::OriginalName("INVALID_VALUE_WITH_LIKE_OPERATOR")] InvalidValueWithLikeOperator = 56,
        /// <summary>
        /// An operator was provided that is inapplicable to the field being
        /// filtered.
        /// </summary>
        [pbr::OriginalName("OPERATOR_FIELD_MISMATCH")] OperatorFieldMismatch = 35,
        /// <summary>
        /// A Condition was found with an empty list.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_EMPTY_LIST_IN_CONDITION")] ProhibitedEmptyListInCondition = 28,
        /// <summary>
        /// A condition used in the query references an unsupported enum constant.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_ENUM_CONSTANT")] ProhibitedEnumConstant = 54,
        /// <summary>
        /// Fields that are not allowed to be selected together were included in
        /// the SELECT clause.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_FIELD_COMBINATION_IN_SELECT_CLAUSE")] ProhibitedFieldCombinationInSelectClause = 31,
        /// <summary>
        /// A field that is not orderable was included in the ORDER BY clause.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_FIELD_IN_ORDER_BY_CLAUSE")] ProhibitedFieldInOrderByClause = 40,
        /// <summary>
        /// A field that is not selectable was included in the SELECT clause.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_FIELD_IN_SELECT_CLAUSE")] ProhibitedFieldInSelectClause = 23,
        /// <summary>
        /// A field that is not filterable was included in the WHERE clause.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_FIELD_IN_WHERE_CLAUSE")] ProhibitedFieldInWhereClause = 24,
        /// <summary>
        /// Resource type specified in the FROM clause is not supported by this
        /// service.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_RESOURCE_TYPE_IN_FROM_CLAUSE")] ProhibitedResourceTypeInFromClause = 43,
        /// <summary>
        /// A field that comes from an incompatible resource was included in the
        /// SELECT clause.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_RESOURCE_TYPE_IN_SELECT_CLAUSE")] ProhibitedResourceTypeInSelectClause = 48,
        /// <summary>
        /// A field that comes from an incompatible resource was included in the
        /// WHERE clause.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_RESOURCE_TYPE_IN_WHERE_CLAUSE")] ProhibitedResourceTypeInWhereClause = 58,
        /// <summary>
        /// A metric incompatible with the main resource or other selected
        /// segmenting resources was included in the SELECT or WHERE clause.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_METRIC_IN_SELECT_OR_WHERE_CLAUSE")] ProhibitedMetricInSelectOrWhereClause = 49,
        /// <summary>
        /// A segment incompatible with the main resource or other selected
        /// segmenting resources was included in the SELECT or WHERE clause.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_SEGMENT_IN_SELECT_OR_WHERE_CLAUSE")] ProhibitedSegmentInSelectOrWhereClause = 51,
        /// <summary>
        /// A segment in the SELECT clause is incompatible with a metric in the
        /// SELECT or WHERE clause.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_SEGMENT_WITH_METRIC_IN_SELECT_OR_WHERE_CLAUSE")] ProhibitedSegmentWithMetricInSelectOrWhereClause = 53,
        /// <summary>
        /// The value passed to the limit clause is too low.
        /// </summary>
        [pbr::OriginalName("LIMIT_VALUE_TOO_LOW")] LimitValueTooLow = 25,
        /// <summary>
        /// Query has a string containing a newline character.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_NEWLINE_IN_STRING")] ProhibitedNewlineInString = 8,
        /// <summary>
        /// List contains values of different types.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_VALUE_COMBINATION_IN_LIST")] ProhibitedValueCombinationInList = 10,
        /// <summary>
        /// The values passed to the BETWEEN operator are not of the same type.
        /// </summary>
        [pbr::OriginalName("PROHIBITED_VALUE_COMBINATION_WITH_BETWEEN_OPERATOR")] ProhibitedValueCombinationWithBetweenOperator = 21,
        /// <summary>
        /// Query contains unterminated string.
        /// </summary>
        [pbr::OriginalName("STRING_NOT_TERMINATED")] StringNotTerminated = 6,
        /// <summary>
        /// Too many segments are specified in SELECT clause.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_SEGMENTS")] TooManySegments = 34,
        /// <summary>
        /// Query is incomplete and cannot be parsed.
        /// </summary>
        [pbr::OriginalName("UNEXPECTED_END_OF_QUERY")] UnexpectedEndOfQuery = 9,
        /// <summary>
        /// FROM clause cannot be specified in this query.
        /// </summary>
        [pbr::OriginalName("UNEXPECTED_FROM_CLAUSE")] UnexpectedFromClause = 47,
        /// <summary>
        /// Query contains one or more unrecognized fields.
        /// </summary>
        [pbr::OriginalName("UNRECOGNIZED_FIELD")] UnrecognizedField = 32,
        /// <summary>
        /// Query has an unexpected extra part.
        /// </summary>
        [pbr::OriginalName("UNEXPECTED_INPUT")] UnexpectedInput = 11,
        /// <summary>
        /// Metrics cannot be requested for a manager account. To retrieve metrics,
        /// issue separate requests against each client account under the manager
        /// account.
        /// </summary>
        [pbr::OriginalName("REQUESTED_METRICS_FOR_MANAGER")] RequestedMetricsForManager = 59,
        /// <summary>
        /// The number of values (right-hand-side operands) in a filter exceeds the
        /// limit.
        /// </summary>
        [pbr::OriginalName("FILTER_HAS_TOO_MANY_VALUES")] FilterHasTooManyValues = 63,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
