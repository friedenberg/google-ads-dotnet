// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/enums/click_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/enums/click_type.proto</summary>
  public static partial class ClickTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/enums/click_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClickTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9nb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZW51bXMvY2xpY2tfdHlwZS5w",
            "cm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEwLmVudW1zGhxnb29nbGUv",
            "YXBpL2Fubm90YXRpb25zLnByb3RvIqYMCg1DbGlja1R5cGVFbnVtIpQMCglD",
            "bGlja1R5cGUSDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESEAoMQVBQ",
            "X0RFRVBMSU5LEAISDwoLQlJFQURDUlVNQlMQAxISCg5CUk9BREJBTkRfUExB",
            "ThAEEhEKDUNBTExfVFJBQ0tJTkcQBRIJCgVDQUxMUxAGEhoKFkNMSUNLX09O",
            "X0VOR0FHRU1FTlRfQUQQBxISCg5HRVRfRElSRUNUSU9OUxAIEhYKEkxPQ0FU",
            "SU9OX0VYUEFOU0lPThAJEhgKFExPQ0FUSU9OX0ZPUk1BVF9DQUxMEAoSHgoa",
            "TE9DQVRJT05fRk9STUFUX0RJUkVDVElPTlMQCxIZChVMT0NBVElPTl9GT1JN",
            "QVRfSU1BR0UQDBIgChxMT0NBVElPTl9GT1JNQVRfTEFORElOR19QQUdFEA0S",
            "FwoTTE9DQVRJT05fRk9STUFUX01BUBAOEh4KGkxPQ0FUSU9OX0ZPUk1BVF9T",
            "VE9SRV9JTkZPEA8SGAoUTE9DQVRJT05fRk9STUFUX1RFWFQQEBIYChRNT0JJ",
            "TEVfQ0FMTF9UUkFDS0lORxAREhAKDE9GRkVSX1BSSU5UUxASEgkKBU9USEVS",
            "EBMSHAoYUFJPRFVDVF9FWFRFTlNJT05fQ0xJQ0tTEBQSHQoZUFJPRFVDVF9M",
            "SVNUSU5HX0FEX0NMSUNLUxAVEg0KCVNJVEVMSU5LUxAWEhEKDVNUT1JFX0xP",
            "Q0FUT1IQFxIOCgpVUkxfQ0xJQ0tTEBkSGgoWVklERU9fQVBQX1NUT1JFX0NM",
            "SUNLUxAaEh8KG1ZJREVPX0NBTExfVE9fQUNUSU9OX0NMSUNLUxAbEiUKIVZJ",
            "REVPX0NBUkRfQUNUSU9OX0hFQURMSU5FX0NMSUNLUxAcEhgKFFZJREVPX0VO",
            "RF9DQVBfQ0xJQ0tTEB0SGAoUVklERU9fV0VCU0lURV9DTElDS1MQHhIUChBW",
            "SVNVQUxfU0lURUxJTktTEB8SEQoNV0lSRUxFU1NfUExBThAgEhwKGFBST0RV",
            "Q1RfTElTVElOR19BRF9MT0NBTBAhEikKJVBST0RVQ1RfTElTVElOR19BRF9N",
            "VUxUSUNIQU5ORUxfTE9DQUwQIhIqCiZQUk9EVUNUX0xJU1RJTkdfQURfTVVM",
            "VElDSEFOTkVMX09OTElORRAjEh4KGlBST0RVQ1RfTElTVElOR19BRFNfQ09V",
            "UE9OECQSIwofUFJPRFVDVF9MSVNUSU5HX0FEX1RSQU5TQUNUQUJMRRAlEhsK",
            "F1BST0RVQ1RfQURfQVBQX0RFRVBMSU5LECYSHQoZU0hPV0NBU0VfQURfQ0FU",
            "RUdPUllfTElOSxAnEiUKIVNIT1dDQVNFX0FEX0xPQ0FMX1NUT1JFRlJPTlRf",
            "TElOSxAoEiMKH1NIT1dDQVNFX0FEX09OTElORV9QUk9EVUNUX0xJTksQKhIi",
            "Ch5TSE9XQ0FTRV9BRF9MT0NBTF9QUk9EVUNUX0xJTksQKxIXChNQUk9NT1RJ",
            "T05fRVhURU5TSU9OECwSIQodU1dJUEVBQkxFX0dBTExFUllfQURfSEVBRExJ",
            "TkUQLRIfChtTV0lQRUFCTEVfR0FMTEVSWV9BRF9TV0lQRVMQLhIhCh1TV0lQ",
            "RUFCTEVfR0FMTEVSWV9BRF9TRUVfTU9SRRAvEiUKIVNXSVBFQUJMRV9HQUxM",
            "RVJZX0FEX1NJVEVMSU5LX09ORRAwEiUKIVNXSVBFQUJMRV9HQUxMRVJZX0FE",
            "X1NJVEVMSU5LX1RXTxAxEicKI1NXSVBFQUJMRV9HQUxMRVJZX0FEX1NJVEVM",
            "SU5LX1RIUkVFEDISJgoiU1dJUEVBQkxFX0dBTExFUllfQURfU0lURUxJTktf",
            "Rk9VUhAzEiYKIlNXSVBFQUJMRV9HQUxMRVJZX0FEX1NJVEVMSU5LX0ZJVkUQ",
            "NBIPCgtIT1RFTF9QUklDRRA1EhMKD1BSSUNFX0VYVEVOU0lPThA2EicKI0hP",
            "VEVMX0JPT0tfT05fR09PR0xFX1JPT01fU0VMRUNUSU9OEDcSHwobU0hPUFBJ",
            "TkdfQ09NUEFSSVNPTl9MSVNUSU5HEDhC6AEKImNvbS5nb29nbGUuYWRzLmdv",
            "b2dsZWFkcy52MTAuZW51bXNCDkNsaWNrVHlwZVByb3RvUAFaQ2dvb2dsZS5n",
            "b2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92",
            "MTAvZW51bXM7ZW51bXOiAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5W",
            "MTAuRW51bXPKAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMTBcRW51bXPqAiJH",
            "b29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTA6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Enums.ClickTypeEnum), global::Google.Ads.GoogleAds.V10.Enums.ClickTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V10.Enums.ClickTypeEnum.Types.ClickType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enumeration of Google Ads click types.
  /// </summary>
  public sealed partial class ClickTypeEnum : pb::IMessage<ClickTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ClickTypeEnum> _parser = new pb::MessageParser<ClickTypeEnum>(() => new ClickTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ClickTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Enums.ClickTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClickTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClickTypeEnum(ClickTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClickTypeEnum Clone() {
      return new ClickTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ClickTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ClickTypeEnum other) {
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
    public void MergeFrom(ClickTypeEnum other) {
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
    /// <summary>Container for nested types declared in the ClickTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enumerates Google Ads click types.
      /// </summary>
      public enum ClickType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The value is unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// App engagement ad deep link.
        /// </summary>
        [pbr::OriginalName("APP_DEEPLINK")] AppDeeplink = 2,
        /// <summary>
        /// Breadcrumbs.
        /// </summary>
        [pbr::OriginalName("BREADCRUMBS")] Breadcrumbs = 3,
        /// <summary>
        /// Broadband Plan.
        /// </summary>
        [pbr::OriginalName("BROADBAND_PLAN")] BroadbandPlan = 4,
        /// <summary>
        /// Manually dialed phone calls.
        /// </summary>
        [pbr::OriginalName("CALL_TRACKING")] CallTracking = 5,
        /// <summary>
        /// Phone calls.
        /// </summary>
        [pbr::OriginalName("CALLS")] Calls = 6,
        /// <summary>
        /// Click on engagement ad.
        /// </summary>
        [pbr::OriginalName("CLICK_ON_ENGAGEMENT_AD")] ClickOnEngagementAd = 7,
        /// <summary>
        /// Driving direction.
        /// </summary>
        [pbr::OriginalName("GET_DIRECTIONS")] GetDirections = 8,
        /// <summary>
        /// Get location details.
        /// </summary>
        [pbr::OriginalName("LOCATION_EXPANSION")] LocationExpansion = 9,
        /// <summary>
        /// Call.
        /// </summary>
        [pbr::OriginalName("LOCATION_FORMAT_CALL")] LocationFormatCall = 10,
        /// <summary>
        /// Directions.
        /// </summary>
        [pbr::OriginalName("LOCATION_FORMAT_DIRECTIONS")] LocationFormatDirections = 11,
        /// <summary>
        /// Image(s).
        /// </summary>
        [pbr::OriginalName("LOCATION_FORMAT_IMAGE")] LocationFormatImage = 12,
        /// <summary>
        /// Go to landing page.
        /// </summary>
        [pbr::OriginalName("LOCATION_FORMAT_LANDING_PAGE")] LocationFormatLandingPage = 13,
        /// <summary>
        /// Map.
        /// </summary>
        [pbr::OriginalName("LOCATION_FORMAT_MAP")] LocationFormatMap = 14,
        /// <summary>
        /// Go to store info.
        /// </summary>
        [pbr::OriginalName("LOCATION_FORMAT_STORE_INFO")] LocationFormatStoreInfo = 15,
        /// <summary>
        /// Text.
        /// </summary>
        [pbr::OriginalName("LOCATION_FORMAT_TEXT")] LocationFormatText = 16,
        /// <summary>
        /// Mobile phone calls.
        /// </summary>
        [pbr::OriginalName("MOBILE_CALL_TRACKING")] MobileCallTracking = 17,
        /// <summary>
        /// Print offer.
        /// </summary>
        [pbr::OriginalName("OFFER_PRINTS")] OfferPrints = 18,
        /// <summary>
        /// Other.
        /// </summary>
        [pbr::OriginalName("OTHER")] Other = 19,
        /// <summary>
        /// Product plusbox offer.
        /// </summary>
        [pbr::OriginalName("PRODUCT_EXTENSION_CLICKS")] ProductExtensionClicks = 20,
        /// <summary>
        /// Shopping - Product - Online.
        /// </summary>
        [pbr::OriginalName("PRODUCT_LISTING_AD_CLICKS")] ProductListingAdClicks = 21,
        /// <summary>
        /// Sitelink.
        /// </summary>
        [pbr::OriginalName("SITELINKS")] Sitelinks = 22,
        /// <summary>
        /// Show nearby locations.
        /// </summary>
        [pbr::OriginalName("STORE_LOCATOR")] StoreLocator = 23,
        /// <summary>
        /// Headline.
        /// </summary>
        [pbr::OriginalName("URL_CLICKS")] UrlClicks = 25,
        /// <summary>
        /// App store.
        /// </summary>
        [pbr::OriginalName("VIDEO_APP_STORE_CLICKS")] VideoAppStoreClicks = 26,
        /// <summary>
        /// Call-to-Action overlay.
        /// </summary>
        [pbr::OriginalName("VIDEO_CALL_TO_ACTION_CLICKS")] VideoCallToActionClicks = 27,
        /// <summary>
        /// Cards.
        /// </summary>
        [pbr::OriginalName("VIDEO_CARD_ACTION_HEADLINE_CLICKS")] VideoCardActionHeadlineClicks = 28,
        /// <summary>
        /// End cap.
        /// </summary>
        [pbr::OriginalName("VIDEO_END_CAP_CLICKS")] VideoEndCapClicks = 29,
        /// <summary>
        /// Website.
        /// </summary>
        [pbr::OriginalName("VIDEO_WEBSITE_CLICKS")] VideoWebsiteClicks = 30,
        /// <summary>
        /// Visual Sitelinks.
        /// </summary>
        [pbr::OriginalName("VISUAL_SITELINKS")] VisualSitelinks = 31,
        /// <summary>
        /// Wireless Plan.
        /// </summary>
        [pbr::OriginalName("WIRELESS_PLAN")] WirelessPlan = 32,
        /// <summary>
        /// Shopping - Product - Local.
        /// </summary>
        [pbr::OriginalName("PRODUCT_LISTING_AD_LOCAL")] ProductListingAdLocal = 33,
        /// <summary>
        /// Shopping - Product - MultiChannel Local.
        /// </summary>
        [pbr::OriginalName("PRODUCT_LISTING_AD_MULTICHANNEL_LOCAL")] ProductListingAdMultichannelLocal = 34,
        /// <summary>
        /// Shopping - Product - MultiChannel Online.
        /// </summary>
        [pbr::OriginalName("PRODUCT_LISTING_AD_MULTICHANNEL_ONLINE")] ProductListingAdMultichannelOnline = 35,
        /// <summary>
        /// Shopping - Product - Coupon.
        /// </summary>
        [pbr::OriginalName("PRODUCT_LISTING_ADS_COUPON")] ProductListingAdsCoupon = 36,
        /// <summary>
        /// Shopping - Product - Sell on Google.
        /// </summary>
        [pbr::OriginalName("PRODUCT_LISTING_AD_TRANSACTABLE")] ProductListingAdTransactable = 37,
        /// <summary>
        /// Shopping - Product - App engagement ad deep link.
        /// </summary>
        [pbr::OriginalName("PRODUCT_AD_APP_DEEPLINK")] ProductAdAppDeeplink = 38,
        /// <summary>
        /// Shopping - Showcase - Category.
        /// </summary>
        [pbr::OriginalName("SHOWCASE_AD_CATEGORY_LINK")] ShowcaseAdCategoryLink = 39,
        /// <summary>
        /// Shopping - Showcase - Local storefront.
        /// </summary>
        [pbr::OriginalName("SHOWCASE_AD_LOCAL_STOREFRONT_LINK")] ShowcaseAdLocalStorefrontLink = 40,
        /// <summary>
        /// Shopping - Showcase - Online product.
        /// </summary>
        [pbr::OriginalName("SHOWCASE_AD_ONLINE_PRODUCT_LINK")] ShowcaseAdOnlineProductLink = 42,
        /// <summary>
        /// Shopping - Showcase - Local product.
        /// </summary>
        [pbr::OriginalName("SHOWCASE_AD_LOCAL_PRODUCT_LINK")] ShowcaseAdLocalProductLink = 43,
        /// <summary>
        /// Promotion Extension.
        /// </summary>
        [pbr::OriginalName("PROMOTION_EXTENSION")] PromotionExtension = 44,
        /// <summary>
        /// Ad Headline.
        /// </summary>
        [pbr::OriginalName("SWIPEABLE_GALLERY_AD_HEADLINE")] SwipeableGalleryAdHeadline = 45,
        /// <summary>
        /// Swipes.
        /// </summary>
        [pbr::OriginalName("SWIPEABLE_GALLERY_AD_SWIPES")] SwipeableGalleryAdSwipes = 46,
        /// <summary>
        /// See More.
        /// </summary>
        [pbr::OriginalName("SWIPEABLE_GALLERY_AD_SEE_MORE")] SwipeableGalleryAdSeeMore = 47,
        /// <summary>
        /// Sitelink 1.
        /// </summary>
        [pbr::OriginalName("SWIPEABLE_GALLERY_AD_SITELINK_ONE")] SwipeableGalleryAdSitelinkOne = 48,
        /// <summary>
        /// Sitelink 2.
        /// </summary>
        [pbr::OriginalName("SWIPEABLE_GALLERY_AD_SITELINK_TWO")] SwipeableGalleryAdSitelinkTwo = 49,
        /// <summary>
        /// Sitelink 3.
        /// </summary>
        [pbr::OriginalName("SWIPEABLE_GALLERY_AD_SITELINK_THREE")] SwipeableGalleryAdSitelinkThree = 50,
        /// <summary>
        /// Sitelink 4.
        /// </summary>
        [pbr::OriginalName("SWIPEABLE_GALLERY_AD_SITELINK_FOUR")] SwipeableGalleryAdSitelinkFour = 51,
        /// <summary>
        /// Sitelink 5.
        /// </summary>
        [pbr::OriginalName("SWIPEABLE_GALLERY_AD_SITELINK_FIVE")] SwipeableGalleryAdSitelinkFive = 52,
        /// <summary>
        /// Hotel price.
        /// </summary>
        [pbr::OriginalName("HOTEL_PRICE")] HotelPrice = 53,
        /// <summary>
        /// Price Extension.
        /// </summary>
        [pbr::OriginalName("PRICE_EXTENSION")] PriceExtension = 54,
        /// <summary>
        /// Book on Google hotel room selection.
        /// </summary>
        [pbr::OriginalName("HOTEL_BOOK_ON_GOOGLE_ROOM_SELECTION")] HotelBookOnGoogleRoomSelection = 55,
        /// <summary>
        /// Shopping - Comparison Listing.
        /// </summary>
        [pbr::OriginalName("SHOPPING_COMPARISON_LISTING")] ShoppingComparisonListing = 56,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
