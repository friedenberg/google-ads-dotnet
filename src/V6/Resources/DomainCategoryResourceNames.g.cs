// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V6.Resources
{
    /// <summary>Resource name for the <c>DomainCategory</c> resource.</summary>
    public sealed partial class DomainCategoryName : gax::IResourceName, sys::IEquatable<DomainCategoryName>
    {
        /// <summary>The possible contents of <see cref="DomainCategoryName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/domainCategories/{campaign_id}~{base64_category}~{language_code}</c>.
            /// </summary>
            CustomerCampaignBase64CategoryLanguageCode = 1,
        }

        private static gax::PathTemplate s_customerCampaignBase64CategoryLanguageCode = new gax::PathTemplate("customers/{customer_id}/domainCategories/{campaign_id_base64_category_language_code}");

        /// <summary>Creates a <see cref="DomainCategoryName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DomainCategoryName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DomainCategoryName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DomainCategoryName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DomainCategoryName"/> with the pattern
        /// <c>customers/{customer_id}/domainCategories/{campaign_id}~{base64_category}~{language_code}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="base64CategoryId">The <c>Base64Category</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="languageCodeId">The <c>LanguageCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DomainCategoryName"/> constructed from the provided ids.</returns>
        public static DomainCategoryName FromCustomerCampaignBase64CategoryLanguageCode(string customerId, string campaignId, string base64CategoryId, string languageCodeId) =>
            new DomainCategoryName(ResourceNameType.CustomerCampaignBase64CategoryLanguageCode, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), base64CategoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(base64CategoryId, nameof(base64CategoryId)), languageCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(languageCodeId, nameof(languageCodeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DomainCategoryName"/> with pattern
        /// <c>customers/{customer_id}/domainCategories/{campaign_id}~{base64_category}~{language_code}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="base64CategoryId">The <c>Base64Category</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="languageCodeId">The <c>LanguageCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DomainCategoryName"/> with pattern
        /// <c>customers/{customer_id}/domainCategories/{campaign_id}~{base64_category}~{language_code}</c>.
        /// </returns>
        public static string Format(string customerId, string campaignId, string base64CategoryId, string languageCodeId) =>
            FormatCustomerCampaignBase64CategoryLanguageCode(customerId, campaignId, base64CategoryId, languageCodeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DomainCategoryName"/> with pattern
        /// <c>customers/{customer_id}/domainCategories/{campaign_id}~{base64_category}~{language_code}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="base64CategoryId">The <c>Base64Category</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="languageCodeId">The <c>LanguageCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DomainCategoryName"/> with pattern
        /// <c>customers/{customer_id}/domainCategories/{campaign_id}~{base64_category}~{language_code}</c>.
        /// </returns>
        public static string FormatCustomerCampaignBase64CategoryLanguageCode(string customerId, string campaignId, string base64CategoryId, string languageCodeId) =>
            s_customerCampaignBase64CategoryLanguageCode.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(base64CategoryId, nameof(base64CategoryId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(languageCodeId, nameof(languageCodeId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DomainCategoryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/domainCategories/{campaign_id}~{base64_category}~{language_code}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="domainCategoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DomainCategoryName"/> if successful.</returns>
        public static DomainCategoryName Parse(string domainCategoryName) => Parse(domainCategoryName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DomainCategoryName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/domainCategories/{campaign_id}~{base64_category}~{language_code}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="domainCategoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DomainCategoryName"/> if successful.</returns>
        public static DomainCategoryName Parse(string domainCategoryName, bool allowUnparsed) =>
            TryParse(domainCategoryName, allowUnparsed, out DomainCategoryName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DomainCategoryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/domainCategories/{campaign_id}~{base64_category}~{language_code}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="domainCategoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DomainCategoryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string domainCategoryName, out DomainCategoryName result) =>
            TryParse(domainCategoryName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DomainCategoryName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/domainCategories/{campaign_id}~{base64_category}~{language_code}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="domainCategoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DomainCategoryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string domainCategoryName, bool allowUnparsed, out DomainCategoryName result)
        {
            gax::GaxPreconditions.CheckNotNull(domainCategoryName, nameof(domainCategoryName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCampaignBase64CategoryLanguageCode.TryParseName(domainCategoryName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerCampaignBase64CategoryLanguageCode(resourceName[0], split1[0], split1[1], split1[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(domainCategoryName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private static string[] ParseSplitHelper(string s, char[] separators)
        {
            string[] result = new string[separators.Length + 1];
            int i0 = 0;
            for (int i = 0; i <= separators.Length; i++)
            {
                int i1 = i < separators.Length ? s.IndexOf(separators[i], i0) : s.Length;
                if (i1 < 0 || i1 == i0)
                {
                    return null;
                }
                result[i] = s.Substring(i0, i1 - i0);
                i0 = i1 + 1;
            }
            return result;
        }

        private DomainCategoryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string base64CategoryId = null, string campaignId = null, string customerId = null, string languageCodeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            Base64CategoryId = base64CategoryId;
            CampaignId = campaignId;
            CustomerId = customerId;
            LanguageCodeId = languageCodeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DomainCategoryName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/domainCategories/{campaign_id}~{base64_category}~{language_code}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="base64CategoryId">The <c>Base64Category</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="languageCodeId">The <c>LanguageCode</c> ID. Must not be <c>null</c> or empty.</param>
        public DomainCategoryName(string customerId, string campaignId, string base64CategoryId, string languageCodeId) : this(ResourceNameType.CustomerCampaignBase64CategoryLanguageCode, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), base64CategoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(base64CategoryId, nameof(base64CategoryId)), languageCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(languageCodeId, nameof(languageCodeId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Base64Category</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string Base64CategoryId { get; }

        /// <summary>
        /// The <c>Campaign</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CampaignId { get; }

        /// <summary>
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The <c>LanguageCode</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string LanguageCodeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerCampaignBase64CategoryLanguageCode: return s_customerCampaignBase64CategoryLanguageCode.Expand(CustomerId, $"{CampaignId}~{Base64CategoryId}~{LanguageCodeId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DomainCategoryName);

        /// <inheritdoc/>
        public bool Equals(DomainCategoryName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(DomainCategoryName a, DomainCategoryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(DomainCategoryName a, DomainCategoryName b) => !(a == b);
    }

    public partial class DomainCategory
    {
        /// <summary>
        /// <see cref="DomainCategoryName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal DomainCategoryName ResourceNameAsDomainCategoryName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : DomainCategoryName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CampaignName"/>-typed view over the <see cref="Campaign"/> resource name property.
        /// </summary>
        internal CampaignName CampaignAsCampaignName
        {
            get => string.IsNullOrEmpty(Campaign) ? null : CampaignName.Parse(Campaign, allowUnparsed: true);
            set => Campaign = value?.ToString() ?? "";
        }
    }
}