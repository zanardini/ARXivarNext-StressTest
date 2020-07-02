/* 
 * WebAPI
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: data
 * 
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// LicenseExpiration
    /// </summary>
    [DataContract]
    public partial class LicenseExpiration :  IEquatable<LicenseExpiration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseExpiration" /> class.
        /// </summary>
        /// <param name="utcValidFrom">utcValidFrom.</param>
        /// <param name="utcValidTo">utcValidTo.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="isExpired">isExpired.</param>
        public LicenseExpiration(DateTime? utcValidFrom = default(DateTime?), DateTime? utcValidTo = default(DateTime?), bool? isActive = default(bool?), bool? isExpired = default(bool?))
        {
            this.UtcValidFrom = utcValidFrom;
            this.UtcValidTo = utcValidTo;
            this.IsActive = isActive;
            this.IsExpired = isExpired;
        }
        
        /// <summary>
        /// Gets or Sets UtcValidFrom
        /// </summary>
        [DataMember(Name="utcValidFrom", EmitDefaultValue=false)]
        public DateTime? UtcValidFrom { get; set; }

        /// <summary>
        /// Gets or Sets UtcValidTo
        /// </summary>
        [DataMember(Name="utcValidTo", EmitDefaultValue=false)]
        public DateTime? UtcValidTo { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or Sets IsExpired
        /// </summary>
        [DataMember(Name="isExpired", EmitDefaultValue=false)]
        public bool? IsExpired { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LicenseExpiration {\n");
            sb.Append("  UtcValidFrom: ").Append(UtcValidFrom).Append("\n");
            sb.Append("  UtcValidTo: ").Append(UtcValidTo).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsExpired: ").Append(IsExpired).Append("\n");
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
            return this.Equals(input as LicenseExpiration);
        }

        /// <summary>
        /// Returns true if LicenseExpiration instances are equal
        /// </summary>
        /// <param name="input">Instance of LicenseExpiration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicenseExpiration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UtcValidFrom == input.UtcValidFrom ||
                    (this.UtcValidFrom != null &&
                    this.UtcValidFrom.Equals(input.UtcValidFrom))
                ) && 
                (
                    this.UtcValidTo == input.UtcValidTo ||
                    (this.UtcValidTo != null &&
                    this.UtcValidTo.Equals(input.UtcValidTo))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.IsExpired == input.IsExpired ||
                    (this.IsExpired != null &&
                    this.IsExpired.Equals(input.IsExpired))
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
                if (this.UtcValidFrom != null)
                    hashCode = hashCode * 59 + this.UtcValidFrom.GetHashCode();
                if (this.UtcValidTo != null)
                    hashCode = hashCode * 59 + this.UtcValidTo.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.IsExpired != null)
                    hashCode = hashCode * 59 + this.IsExpired.GetHashCode();
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
