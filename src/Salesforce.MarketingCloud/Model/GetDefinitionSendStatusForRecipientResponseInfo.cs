/* 
 * Marketing Cloud REST API
 *
 * Marketing Cloud's REST API is our newest API. It supports multi-channel use cases, is much more lightweight and easy to use than our SOAP API, and is getting more comprehensive with every release.
 *
 * OpenAPI spec version: 1.1.0
 * Contact: mc_sdk@salesforce.com
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
using SwaggerDateConverter = Salesforce.MarketingCloud.Client.SwaggerDateConverter;

namespace Salesforce.MarketingCloud.Model
{
    /// <summary>
    /// GetDefinitionSendStatusForRecipientResponseInfo
    /// </summary>
    [DataContract]
    public partial class GetDefinitionSendStatusForRecipientResponseInfo :  IEquatable<GetDefinitionSendStatusForRecipientResponseInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDefinitionSendStatusForRecipientResponseInfo" /> class.
        /// </summary>
        /// <param name="messageKey">Unique identifier used to track message status..</param>
        /// <param name="contactKey">Unique identifier for a subscriber in Marketing Cloud. Each request must include a contactKey. You can use an existing subscriber key or create one at send time by using the recipient’s email address..</param>
        /// <param name="to">Channel address of the recipient. For email, it’s the recipient&#39;s email address..</param>
        /// <param name="statusCode">The specific status code.</param>
        /// <param name="statusMessage">The specific status message.</param>
        public GetDefinitionSendStatusForRecipientResponseInfo(string messageKey = default(string), string contactKey = default(string), string to = default(string), decimal? statusCode = default(decimal?), string statusMessage = default(string))
        {
            this.MessageKey = messageKey;
            this.ContactKey = contactKey;
            this.To = to;
            this.StatusCode = statusCode;
            this.StatusMessage = statusMessage;
        }
        
        /// <summary>
        /// Unique identifier used to track message status.
        /// </summary>
        /// <value>Unique identifier used to track message status.</value>
        [DataMember(Name="messageKey", EmitDefaultValue=false)]
        public string MessageKey { get; set; }

        /// <summary>
        /// Unique identifier for a subscriber in Marketing Cloud. Each request must include a contactKey. You can use an existing subscriber key or create one at send time by using the recipient’s email address.
        /// </summary>
        /// <value>Unique identifier for a subscriber in Marketing Cloud. Each request must include a contactKey. You can use an existing subscriber key or create one at send time by using the recipient’s email address.</value>
        [DataMember(Name="contactKey", EmitDefaultValue=false)]
        public string ContactKey { get; set; }

        /// <summary>
        /// Channel address of the recipient. For email, it’s the recipient&#39;s email address.
        /// </summary>
        /// <value>Channel address of the recipient. For email, it’s the recipient&#39;s email address.</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }

        /// <summary>
        /// The specific status code
        /// </summary>
        /// <value>The specific status code</value>
        [DataMember(Name="statusCode", EmitDefaultValue=false)]
        public decimal? StatusCode { get; set; }

        /// <summary>
        /// The specific status message
        /// </summary>
        /// <value>The specific status message</value>
        [DataMember(Name="statusMessage", EmitDefaultValue=false)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDefinitionSendStatusForRecipientResponseInfo {\n");
            sb.Append("  MessageKey: ").Append(MessageKey).Append("\n");
            sb.Append("  ContactKey: ").Append(ContactKey).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  StatusMessage: ").Append(StatusMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetDefinitionSendStatusForRecipientResponseInfo);
        }

        /// <summary>
        /// Returns true if GetDefinitionSendStatusForRecipientResponseInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDefinitionSendStatusForRecipientResponseInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDefinitionSendStatusForRecipientResponseInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MessageKey == input.MessageKey ||
                    (this.MessageKey != null &&
                    this.MessageKey.Equals(input.MessageKey))
                ) && 
                (
                    this.ContactKey == input.ContactKey ||
                    (this.ContactKey != null &&
                    this.ContactKey.Equals(input.ContactKey))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    (this.StatusCode != null &&
                    this.StatusCode.Equals(input.StatusCode))
                ) && 
                (
                    this.StatusMessage == input.StatusMessage ||
                    (this.StatusMessage != null &&
                    this.StatusMessage.Equals(input.StatusMessage))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.MessageKey != null)
                    hashCode = hashCode * 59 + this.MessageKey.GetHashCode();
                if (this.ContactKey != null)
                    hashCode = hashCode * 59 + this.ContactKey.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.StatusCode != null)
                    hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                if (this.StatusMessage != null)
                    hashCode = hashCode * 59 + this.StatusMessage.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
