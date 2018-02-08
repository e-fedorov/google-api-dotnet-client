// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by google-apis-code-generator 1.5.1
//     C# generator version: 1.32.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/**
 * \brief
 *   Google Search Console URL Testing Tools API Version v1
 *
 * \section ApiInfo API Version Information
 *    <table>
 *      <tr><th>API
 *          <td><a href='https://developers.google.com/webmaster-tools/search-console-api/'>Google Search Console URL Testing Tools API</a>
 *      <tr><th>API Version<td>v1
 *      <tr><th>API Rev<td>20180207 (1133)
 *      <tr><th>API Docs
 *          <td><a href='https://developers.google.com/webmaster-tools/search-console-api/'>
 *              https://developers.google.com/webmaster-tools/search-console-api/</a>
 *      <tr><th>Discovery Name<td>searchconsole
 *    </table>
 *
 * \section ForMoreInfo For More Information
 *
 * The complete API documentation for using Google Search Console URL Testing Tools API can be found at
 * <a href='https://developers.google.com/webmaster-tools/search-console-api/'>https://developers.google.com/webmaster-tools/search-console-api/</a>.
 *
 * For more information about the Google APIs Client Library for .NET, see
 * <a href='https://developers.google.com/api-client-library/dotnet/get_started'>
 * https://developers.google.com/api-client-library/dotnet/get_started</a>
 */

namespace Google.Apis.SearchConsole.v1
{
    /// <summary>The SearchConsole Service.</summary>
    public class SearchConsoleService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public SearchConsoleService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public SearchConsoleService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            urlTestingTools = new UrlTestingToolsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features
        {
            get { return new string[0]; }
        }

        /// <summary>Gets the service name.</summary>
        public override string Name
        {
            get { return "searchconsole"; }
        }

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri
        {
            get { return "https://searchconsole.googleapis.com/"; }
        }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath
        {
            get { return ""; }
        }

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri
        {
            get { return "https://searchconsole.googleapis.com/batch"; }
        }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath
        {
            get { return "batch"; }
        }
        #endif





        private readonly UrlTestingToolsResource urlTestingTools;

        /// <summary>Gets the UrlTestingTools resource.</summary>
        public virtual UrlTestingToolsResource UrlTestingTools
        {
            get { return urlTestingTools; }
        }
    }

    ///<summary>A base abstract class for SearchConsole requests.</summary>
    public abstract class SearchConsoleBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new SearchConsoleBaseServiceRequest instance.</summary>
        protected SearchConsoleBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1,
            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        /// [default: json]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media,
            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto,
        }

        /// <summary>OAuth bearer token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("bearer_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string BearerToken { get; set; }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Pretty-print response.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("pp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> Pp { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes SearchConsole parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "$.xgafv", new Google.Apis.Discovery.Parameter
                {
                    Name = "$.xgafv",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "access_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "access_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "bearer_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "bearer_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "callback", new Google.Apis.Discovery.Parameter
                {
                    Name = "callback",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "pp", new Google.Apis.Discovery.Parameter
                {
                    Name = "pp",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "uploadType", new Google.Apis.Discovery.Parameter
                {
                    Name = "uploadType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "upload_protocol", new Google.Apis.Discovery.Parameter
                {
                    Name = "upload_protocol",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "urlTestingTools" collection of methods.</summary>
    public class UrlTestingToolsResource
    {
        private const string Resource = "urlTestingTools";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public UrlTestingToolsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            mobileFriendlyTest = new MobileFriendlyTestResource(service);

        }

        private readonly MobileFriendlyTestResource mobileFriendlyTest;

        /// <summary>Gets the MobileFriendlyTest resource.</summary>
        public virtual MobileFriendlyTestResource MobileFriendlyTest
        {
            get { return mobileFriendlyTest; }
        }

        /// <summary>The "mobileFriendlyTest" collection of methods.</summary>
        public class MobileFriendlyTestResource
        {
            private const string Resource = "mobileFriendlyTest";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public MobileFriendlyTestResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Runs Mobile-Friendly Test for a given URL.</summary>
            /// <param name="body">The body of the request.</param>
            public virtual RunRequest Run(Google.Apis.SearchConsole.v1.Data.RunMobileFriendlyTestRequest body)
            {
                return new RunRequest(service, body);
            }

            /// <summary>Runs Mobile-Friendly Test for a given URL.</summary>
            public class RunRequest : SearchConsoleBaseServiceRequest<Google.Apis.SearchConsole.v1.Data.RunMobileFriendlyTestResponse>
            {
                /// <summary>Constructs a new Run request.</summary>
                public RunRequest(Google.Apis.Services.IClientService service, Google.Apis.SearchConsole.v1.Data.RunMobileFriendlyTestRequest body)
                    : base(service)
                {
                    Body = body;
                    InitParameters();
                }



                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SearchConsole.v1.Data.RunMobileFriendlyTestRequest Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() { return Body; }

                ///<summary>Gets the method name.</summary>
                public override string MethodName
                {
                    get { return "run"; }
                }

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod
                {
                    get { return "POST"; }
                }

                ///<summary>Gets the REST path.</summary>
                public override string RestPath
                {
                    get { return "v1/urlTestingTools/mobileFriendlyTest:run"; }
                }

                /// <summary>Initializes Run parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                }

            }
        }
    }
}

namespace Google.Apis.SearchConsole.v1.Data
{    

    /// <summary>Blocked resource.</summary>
    public class BlockedResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URL of the blocked resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Describe image data.</summary>
    public class Image : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Image data in format determined by the mime type. Currently, the format will always be "image/png",
        /// but this might change in the future.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; } 

        /// <summary>The mime-type of the image data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Mobile-friendly issue.</summary>
    public class MobileFriendlyIssue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Rule violated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rule")]
        public virtual string Rule { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Information about a resource with issue.</summary>
    public class ResourceIssue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Describes a blocked resource issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockedResource")]
        public virtual BlockedResource BlockedResource { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Mobile-friendly test request.</summary>
    public class RunMobileFriendlyTestRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether or not screenshot is requested. Default is false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestScreenshot")]
        public virtual System.Nullable<bool> RequestScreenshot { get; set; } 

        /// <summary>URL for inspection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Mobile-friendly test response, including mobile-friendly issues and resource issues.</summary>
    public class RunMobileFriendlyTestResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Test verdict, whether the page is mobile friendly or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileFriendliness")]
        public virtual string MobileFriendliness { get; set; } 

        /// <summary>List of mobile-usability issues.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileFriendlyIssues")]
        public virtual System.Collections.Generic.IList<MobileFriendlyIssue> MobileFriendlyIssues { get; set; } 

        /// <summary>Information about embedded resources issues.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceIssues")]
        public virtual System.Collections.Generic.IList<ResourceIssue> ResourceIssues { get; set; } 

        /// <summary>Screenshot of the requested URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenshot")]
        public virtual Image Screenshot { get; set; } 

        /// <summary>Final state of the test, can be either complete or an error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testStatus")]
        public virtual TestStatus TestStatus { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Final state of the test, including error details if necessary.</summary>
    public class TestStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Error details if applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual string Details { get; set; } 

        /// <summary>Status of the test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
