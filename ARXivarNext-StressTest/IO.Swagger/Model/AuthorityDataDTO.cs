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
    /// Class of the authority data
    /// </summary>
    [DataContract]
    public partial class AuthorityDataDTO :  IEquatable<AuthorityDataDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorityDataDTO" /> class.
        /// </summary>
        /// <param name="id">Authority Identifier.</param>
        /// <param name="docNumber">Document Identifier.</param>
        /// <param name="protocol">Protocol number.</param>
        /// <param name="protocolDate">Protocol Date and time.</param>
        /// <param name="office">Office.</param>
        /// <param name="person">Reference person.</param>
        /// <param name="shipping">Shipping address.</param>
        /// <param name="yourReferent">Referent.</param>
        public AuthorityDataDTO(int? id = default(int?), int? docNumber = default(int?), string protocol = default(string), DateTime? protocolDate = default(DateTime?), string office = default(string), string person = default(string), string shipping = default(string), string yourReferent = default(string))
        {
            this.Id = id;
            this.DocNumber = docNumber;
            this.Protocol = protocol;
            this.ProtocolDate = protocolDate;
            this.Office = office;
            this.Person = person;
            this.Shipping = shipping;
            this.YourReferent = yourReferent;
        }
        
        /// <summary>
        /// Authority Identifier
        /// </summary>
        /// <value>Authority Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Document Identifier
        /// </summary>
        /// <value>Document Identifier</value>
        [DataMember(Name="docNumber", EmitDefaultValue=false)]
        public int? DocNumber { get; set; }

        /// <summary>
        /// Protocol number
        /// </summary>
        /// <value>Protocol number</value>
        [DataMember(Name="protocol", EmitDefaultValue=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// Protocol Date and time
        /// </summary>
        /// <value>Protocol Date and time</value>
        [DataMember(Name="protocolDate", EmitDefaultValue=false)]
        public DateTime? ProtocolDate { get; set; }

        /// <summary>
        /// Office
        /// </summary>
        /// <value>Office</value>
        [DataMember(Name="office", EmitDefaultValue=false)]
        public string Office { get; set; }

        /// <summary>
        /// Reference person
        /// </summary>
        /// <value>Reference person</value>
        [DataMember(Name="person", EmitDefaultValue=false)]
        public string Person { get; set; }

        /// <summary>
        /// Shipping address
        /// </summary>
        /// <value>Shipping address</value>
        [DataMember(Name="shipping", EmitDefaultValue=false)]
        public string Shipping { get; set; }

        /// <summary>
        /// Referent
        /// </summary>
        /// <value>Referent</value>
        [DataMember(Name="yourReferent", EmitDefaultValue=false)]
        public string YourReferent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthorityDataDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DocNumber: ").Append(DocNumber).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  ProtocolDate: ").Append(ProtocolDate).Append("\n");
            sb.Append("  Office: ").Append(Office).Append("\n");
            sb.Append("  Person: ").Append(Person).Append("\n");
            sb.Append("  Shipping: ").Append(Shipping).Append("\n");
            sb.Append("  YourReferent: ").Append(YourReferent).Append("\n");
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
            return this.Equals(input as AuthorityDataDTO);
        }

        /// <summary>
        /// Returns true if AuthorityDataDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthorityDataDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthorityDataDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DocNumber == input.DocNumber ||
                    (this.DocNumber != null &&
                    this.DocNumber.Equals(input.DocNumber))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.ProtocolDate == input.ProtocolDate ||
                    (this.ProtocolDate != null &&
                    this.ProtocolDate.Equals(input.ProtocolDate))
                ) && 
                (
                    this.Office == input.Office ||
                    (this.Office != null &&
                    this.Office.Equals(input.Office))
                ) && 
                (
                    this.Person == input.Person ||
                    (this.Person != null &&
                    this.Person.Equals(input.Person))
                ) && 
                (
                    this.Shipping == input.Shipping ||
                    (this.Shipping != null &&
                    this.Shipping.Equals(input.Shipping))
                ) && 
                (
                    this.YourReferent == input.YourReferent ||
                    (this.YourReferent != null &&
                    this.YourReferent.Equals(input.YourReferent))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DocNumber != null)
                    hashCode = hashCode * 59 + this.DocNumber.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.ProtocolDate != null)
                    hashCode = hashCode * 59 + this.ProtocolDate.GetHashCode();
                if (this.Office != null)
                    hashCode = hashCode * 59 + this.Office.GetHashCode();
                if (this.Person != null)
                    hashCode = hashCode * 59 + this.Person.GetHashCode();
                if (this.Shipping != null)
                    hashCode = hashCode * 59 + this.Shipping.GetHashCode();
                if (this.YourReferent != null)
                    hashCode = hashCode * 59 + this.YourReferent.GetHashCode();
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