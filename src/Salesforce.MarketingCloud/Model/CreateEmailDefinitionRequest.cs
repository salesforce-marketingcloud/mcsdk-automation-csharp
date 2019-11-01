/* 
 * Marketing Cloud REST API
 *
 * Marketing Cloud's REST API is our newest API. It supports multi-channel use cases, is much more lightweight and easy to use than our SOAP API, and is getting more comprehensive with every release.
 *
 * OpenAPI spec version: 1.0.0
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
    /// CreateEmailDefinitionRequest
    /// </summary>
    [DataContract]
    public partial class CreateEmailDefinitionRequest :  IEquatable<CreateEmailDefinitionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmailDefinitionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateEmailDefinitionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmailDefinitionRequest" /> class.
        /// </summary>
        /// <param name="name">Name of the definition. Must be unique. (required).</param>
        /// <param name="definitionKey">Unique, user-generated key to access the definition object. (required).</param>
        /// <param name="definitionId">Definition Id.</param>
        /// <param name="description">User-provided description of the email definition..</param>
        /// <param name="classification">Marketing Cloud external key of a sending classification defined in Email Studio Administration. Only transactional classifications are permitted. Default is default transactional..</param>
        /// <param name="status">Operational state of the definition: active, inactive, or deleted. A message sent to an active definition is processed and delivered. A message sent to an inactive definition isn’t processed or delivered. Instead, the message is queued for later processing for up to three days..</param>
        /// <param name="content">content (required).</param>
        /// <param name="subscriptions">subscriptions (required).</param>
        /// <param name="options">options.</param>
        public CreateEmailDefinitionRequest(string name = default(string), string definitionKey = default(string), string definitionId = default(string), string description = default(string), string classification = default(string), string status = default(string), CreateEmailDefinitionContent content = default(CreateEmailDefinitionContent), CreateEmailDefinitionSubscriptions subscriptions = default(CreateEmailDefinitionSubscriptions), CreateEmailDefinitionOptionsRequest options = default(CreateEmailDefinitionOptionsRequest))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for CreateEmailDefinitionRequest and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "definitionKey" is required (not null)
            if (definitionKey == null)
            {
                throw new InvalidDataException("definitionKey is a required property for CreateEmailDefinitionRequest and cannot be null");
            }
            else
            {
                this.DefinitionKey = definitionKey;
            }
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new InvalidDataException("content is a required property for CreateEmailDefinitionRequest and cannot be null");
            }
            else
            {
                this.Content = content;
            }
            // to ensure "subscriptions" is required (not null)
            if (subscriptions == null)
            {
                throw new InvalidDataException("subscriptions is a required property for CreateEmailDefinitionRequest and cannot be null");
            }
            else
            {
                this.Subscriptions = subscriptions;
            }
            this.DefinitionId = definitionId;
            this.Description = description;
            this.Classification = classification;
            this.Status = status;
            this.Options = options;
        }
        
        /// <summary>
        /// The ID of the request
        /// </summary>
        /// <value>The ID of the request</value>
        [DataMember(Name="requestId", EmitDefaultValue=false)]
        public string RequestId { get; private set; }

        /// <summary>
        /// Name of the definition. Must be unique.
        /// </summary>
        /// <value>Name of the definition. Must be unique.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Unique, user-generated key to access the definition object.
        /// </summary>
        /// <value>Unique, user-generated key to access the definition object.</value>
        [DataMember(Name="definitionKey", EmitDefaultValue=false)]
        public string DefinitionKey { get; set; }

        /// <summary>
        /// Definition Id
        /// </summary>
        /// <value>Definition Id</value>
        [DataMember(Name="definitionId", EmitDefaultValue=false)]
        public string DefinitionId { get; set; }

        /// <summary>
        /// User-provided description of the email definition.
        /// </summary>
        /// <value>User-provided description of the email definition.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Marketing Cloud external key of a sending classification defined in Email Studio Administration. Only transactional classifications are permitted. Default is default transactional.
        /// </summary>
        /// <value>Marketing Cloud external key of a sending classification defined in Email Studio Administration. Only transactional classifications are permitted. Default is default transactional.</value>
        [DataMember(Name="classification", EmitDefaultValue=false)]
        public string Classification { get; set; }

        /// <summary>
        /// Operational state of the definition: active, inactive, or deleted. A message sent to an active definition is processed and delivered. A message sent to an inactive definition isn’t processed or delivered. Instead, the message is queued for later processing for up to three days.
        /// </summary>
        /// <value>Operational state of the definition: active, inactive, or deleted. A message sent to an active definition is processed and delivered. A message sent to an inactive definition isn’t processed or delivered. Instead, the message is queued for later processing for up to three days.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// The date the object was created.
        /// </summary>
        /// <value>The date the object was created.</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; private set; }

        /// <summary>
        /// The date the object was modified.
        /// </summary>
        /// <value>The date the object was modified.</value>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; private set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public CreateEmailDefinitionContent Content { get; set; }

        /// <summary>
        /// Gets or Sets Subscriptions
        /// </summary>
        [DataMember(Name="subscriptions", EmitDefaultValue=false)]
        public CreateEmailDefinitionSubscriptions Subscriptions { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public CreateEmailDefinitionOptionsRequest Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateEmailDefinitionRequest {\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DefinitionKey: ").Append(DefinitionKey).Append("\n");
            sb.Append("  DefinitionId: ").Append(DefinitionId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Classification: ").Append(Classification).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Subscriptions: ").Append(Subscriptions).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(input as CreateEmailDefinitionRequest);
        }

        /// <summary>
        /// Returns true if CreateEmailDefinitionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateEmailDefinitionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateEmailDefinitionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DefinitionKey == input.DefinitionKey ||
                    (this.DefinitionKey != null &&
                    this.DefinitionKey.Equals(input.DefinitionKey))
                ) && 
                (
                    this.DefinitionId == input.DefinitionId ||
                    (this.DefinitionId != null &&
                    this.DefinitionId.Equals(input.DefinitionId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Classification == input.Classification ||
                    (this.Classification != null &&
                    this.Classification.Equals(input.Classification))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.ModifiedDate == input.ModifiedDate ||
                    (this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(input.ModifiedDate))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Subscriptions == input.Subscriptions ||
                    (this.Subscriptions != null &&
                    this.Subscriptions.Equals(input.Subscriptions))
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
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
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DefinitionKey != null)
                    hashCode = hashCode * 59 + this.DefinitionKey.GetHashCode();
                if (this.DefinitionId != null)
                    hashCode = hashCode * 59 + this.DefinitionId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Classification != null)
                    hashCode = hashCode * 59 + this.Classification.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.ModifiedDate != null)
                    hashCode = hashCode * 59 + this.ModifiedDate.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Subscriptions != null)
                    hashCode = hashCode * 59 + this.Subscriptions.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
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
