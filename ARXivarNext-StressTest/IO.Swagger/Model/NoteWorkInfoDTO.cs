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
    /// Class of note of process
    /// </summary>
    [DataContract]
    public partial class NoteWorkInfoDTO :  IEquatable<NoteWorkInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoteWorkInfoDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="taskName">Name of workflow.</param>
        /// <param name="userCompleteName">User Description.</param>
        /// <param name="date">Creation Date.</param>
        /// <param name="text">Text.</param>
        public NoteWorkInfoDTO(int? id = default(int?), string taskName = default(string), string userCompleteName = default(string), DateTime? date = default(DateTime?), string text = default(string))
        {
            this.Id = id;
            this.TaskName = taskName;
            this.UserCompleteName = userCompleteName;
            this.Date = date;
            this.Text = text;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Name of workflow
        /// </summary>
        /// <value>Name of workflow</value>
        [DataMember(Name="taskName", EmitDefaultValue=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// User Description
        /// </summary>
        /// <value>User Description</value>
        [DataMember(Name="userCompleteName", EmitDefaultValue=false)]
        public string UserCompleteName { get; set; }

        /// <summary>
        /// Creation Date
        /// </summary>
        /// <value>Creation Date</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Text
        /// </summary>
        /// <value>Text</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NoteWorkInfoDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TaskName: ").Append(TaskName).Append("\n");
            sb.Append("  UserCompleteName: ").Append(UserCompleteName).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(input as NoteWorkInfoDTO);
        }

        /// <summary>
        /// Returns true if NoteWorkInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of NoteWorkInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NoteWorkInfoDTO input)
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
                    this.TaskName == input.TaskName ||
                    (this.TaskName != null &&
                    this.TaskName.Equals(input.TaskName))
                ) && 
                (
                    this.UserCompleteName == input.UserCompleteName ||
                    (this.UserCompleteName != null &&
                    this.UserCompleteName.Equals(input.UserCompleteName))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
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
                if (this.TaskName != null)
                    hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.UserCompleteName != null)
                    hashCode = hashCode * 59 + this.UserCompleteName.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
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
