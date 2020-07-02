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
    /// Class of profiling by template
    /// </summary>
    [DataContract]
    public partial class ModelProfileSchemaDTO :  IEquatable<ModelProfileSchemaDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelProfileSchemaDTO" /> class.
        /// </summary>
        /// <param name="modelId">Template Identifier.</param>
        /// <param name="modelDescription">Description.</param>
        /// <param name="options">Options.</param>
        /// <param name="behaviour">Behaviour.</param>
        /// <param name="openModelAfterProfilation">Open file after profiling..</param>
        /// <param name="editModelAfterProfilation">Editing file after profiling..</param>
        /// <param name="maskId">Mask Identifier.</param>
        /// <param name="showOption">Possible values:  0: EmptyProfile  1: PredefinedProfile  2: Mask .</param>
        /// <param name="id">Identifier.</param>
        /// <param name="document">File data.</param>
        /// <param name="fields">Fields.</param>
        /// <param name="postProfilationActions">Post Profilation Actions.</param>
        /// <param name="constrainRoleBehaviour">Possible values:  0: None  1: ForceInsert  2: State .</param>
        /// <param name="attachments">Attachments.</param>
        /// <param name="notes">Notes.</param>
        /// <param name="paNotes">Public Amministration Notes.</param>
        /// <param name="authorityData">Authority Data.</param>
        /// <param name="generatePaProtocol">Defines if a protocol has been generated.</param>
        public ModelProfileSchemaDTO(int? modelId = default(int?), string modelDescription = default(string), ProfileMaskOptionsDTO options = default(ProfileMaskOptionsDTO), ProfileMaskBehaviourDTO behaviour = default(ProfileMaskBehaviourDTO), bool? openModelAfterProfilation = default(bool?), bool? editModelAfterProfilation = default(bool?), string maskId = default(string), int? showOption = default(int?), int? id = default(int?), FileDTO document = default(FileDTO), List<FieldBaseDTO> fields = default(List<FieldBaseDTO>), List<PostProfilationActionDTO> postProfilationActions = default(List<PostProfilationActionDTO>), int? constrainRoleBehaviour = default(int?), List<string> attachments = default(List<string>), List<NoteDTO> notes = default(List<NoteDTO>), List<string> paNotes = default(List<string>), AuthorityDataDTO authorityData = default(AuthorityDataDTO), bool? generatePaProtocol = default(bool?))
        {
            this.ModelId = modelId;
            this.ModelDescription = modelDescription;
            this.Options = options;
            this.Behaviour = behaviour;
            this.OpenModelAfterProfilation = openModelAfterProfilation;
            this.EditModelAfterProfilation = editModelAfterProfilation;
            this.MaskId = maskId;
            this.ShowOption = showOption;
            this.Id = id;
            this.Document = document;
            this.Fields = fields;
            this.PostProfilationActions = postProfilationActions;
            this.ConstrainRoleBehaviour = constrainRoleBehaviour;
            this.Attachments = attachments;
            this.Notes = notes;
            this.PaNotes = paNotes;
            this.AuthorityData = authorityData;
            this.GeneratePaProtocol = generatePaProtocol;
        }
        
        /// <summary>
        /// Template Identifier
        /// </summary>
        /// <value>Template Identifier</value>
        [DataMember(Name="modelId", EmitDefaultValue=false)]
        public int? ModelId { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="modelDescription", EmitDefaultValue=false)]
        public string ModelDescription { get; set; }

        /// <summary>
        /// Options
        /// </summary>
        /// <value>Options</value>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public ProfileMaskOptionsDTO Options { get; set; }

        /// <summary>
        /// Behaviour
        /// </summary>
        /// <value>Behaviour</value>
        [DataMember(Name="behaviour", EmitDefaultValue=false)]
        public ProfileMaskBehaviourDTO Behaviour { get; set; }

        /// <summary>
        /// Open file after profiling.
        /// </summary>
        /// <value>Open file after profiling.</value>
        [DataMember(Name="openModelAfterProfilation", EmitDefaultValue=false)]
        public bool? OpenModelAfterProfilation { get; set; }

        /// <summary>
        /// Editing file after profiling.
        /// </summary>
        /// <value>Editing file after profiling.</value>
        [DataMember(Name="editModelAfterProfilation", EmitDefaultValue=false)]
        public bool? EditModelAfterProfilation { get; set; }

        /// <summary>
        /// Mask Identifier
        /// </summary>
        /// <value>Mask Identifier</value>
        [DataMember(Name="maskId", EmitDefaultValue=false)]
        public string MaskId { get; set; }

        /// <summary>
        /// Possible values:  0: EmptyProfile  1: PredefinedProfile  2: Mask 
        /// </summary>
        /// <value>Possible values:  0: EmptyProfile  1: PredefinedProfile  2: Mask </value>
        [DataMember(Name="showOption", EmitDefaultValue=false)]
        public int? ShowOption { get; set; }

        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// File data
        /// </summary>
        /// <value>File data</value>
        [DataMember(Name="document", EmitDefaultValue=false)]
        public FileDTO Document { get; set; }

        /// <summary>
        /// Fields
        /// </summary>
        /// <value>Fields</value>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<FieldBaseDTO> Fields { get; set; }

        /// <summary>
        /// Post Profilation Actions
        /// </summary>
        /// <value>Post Profilation Actions</value>
        [DataMember(Name="postProfilationActions", EmitDefaultValue=false)]
        public List<PostProfilationActionDTO> PostProfilationActions { get; set; }

        /// <summary>
        /// Possible values:  0: None  1: ForceInsert  2: State 
        /// </summary>
        /// <value>Possible values:  0: None  1: ForceInsert  2: State </value>
        [DataMember(Name="constrainRoleBehaviour", EmitDefaultValue=false)]
        public int? ConstrainRoleBehaviour { get; set; }

        /// <summary>
        /// Attachments
        /// </summary>
        /// <value>Attachments</value>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public List<string> Attachments { get; set; }

        /// <summary>
        /// Notes
        /// </summary>
        /// <value>Notes</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public List<NoteDTO> Notes { get; set; }

        /// <summary>
        /// Public Amministration Notes
        /// </summary>
        /// <value>Public Amministration Notes</value>
        [DataMember(Name="paNotes", EmitDefaultValue=false)]
        public List<string> PaNotes { get; set; }

        /// <summary>
        /// Authority Data
        /// </summary>
        /// <value>Authority Data</value>
        [DataMember(Name="authorityData", EmitDefaultValue=false)]
        public AuthorityDataDTO AuthorityData { get; set; }

        /// <summary>
        /// Defines if a protocol has been generated
        /// </summary>
        /// <value>Defines if a protocol has been generated</value>
        [DataMember(Name="generatePaProtocol", EmitDefaultValue=false)]
        public bool? GeneratePaProtocol { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelProfileSchemaDTO {\n");
            sb.Append("  ModelId: ").Append(ModelId).Append("\n");
            sb.Append("  ModelDescription: ").Append(ModelDescription).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Behaviour: ").Append(Behaviour).Append("\n");
            sb.Append("  OpenModelAfterProfilation: ").Append(OpenModelAfterProfilation).Append("\n");
            sb.Append("  EditModelAfterProfilation: ").Append(EditModelAfterProfilation).Append("\n");
            sb.Append("  MaskId: ").Append(MaskId).Append("\n");
            sb.Append("  ShowOption: ").Append(ShowOption).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  PostProfilationActions: ").Append(PostProfilationActions).Append("\n");
            sb.Append("  ConstrainRoleBehaviour: ").Append(ConstrainRoleBehaviour).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  PaNotes: ").Append(PaNotes).Append("\n");
            sb.Append("  AuthorityData: ").Append(AuthorityData).Append("\n");
            sb.Append("  GeneratePaProtocol: ").Append(GeneratePaProtocol).Append("\n");
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
            return this.Equals(input as ModelProfileSchemaDTO);
        }

        /// <summary>
        /// Returns true if ModelProfileSchemaDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelProfileSchemaDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelProfileSchemaDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ModelId == input.ModelId ||
                    (this.ModelId != null &&
                    this.ModelId.Equals(input.ModelId))
                ) && 
                (
                    this.ModelDescription == input.ModelDescription ||
                    (this.ModelDescription != null &&
                    this.ModelDescription.Equals(input.ModelDescription))
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
                ) && 
                (
                    this.Behaviour == input.Behaviour ||
                    (this.Behaviour != null &&
                    this.Behaviour.Equals(input.Behaviour))
                ) && 
                (
                    this.OpenModelAfterProfilation == input.OpenModelAfterProfilation ||
                    (this.OpenModelAfterProfilation != null &&
                    this.OpenModelAfterProfilation.Equals(input.OpenModelAfterProfilation))
                ) && 
                (
                    this.EditModelAfterProfilation == input.EditModelAfterProfilation ||
                    (this.EditModelAfterProfilation != null &&
                    this.EditModelAfterProfilation.Equals(input.EditModelAfterProfilation))
                ) && 
                (
                    this.MaskId == input.MaskId ||
                    (this.MaskId != null &&
                    this.MaskId.Equals(input.MaskId))
                ) && 
                (
                    this.ShowOption == input.ShowOption ||
                    (this.ShowOption != null &&
                    this.ShowOption.Equals(input.ShowOption))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Document == input.Document ||
                    (this.Document != null &&
                    this.Document.Equals(input.Document))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.PostProfilationActions == input.PostProfilationActions ||
                    this.PostProfilationActions != null &&
                    this.PostProfilationActions.SequenceEqual(input.PostProfilationActions)
                ) && 
                (
                    this.ConstrainRoleBehaviour == input.ConstrainRoleBehaviour ||
                    (this.ConstrainRoleBehaviour != null &&
                    this.ConstrainRoleBehaviour.Equals(input.ConstrainRoleBehaviour))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.Notes == input.Notes ||
                    this.Notes != null &&
                    this.Notes.SequenceEqual(input.Notes)
                ) && 
                (
                    this.PaNotes == input.PaNotes ||
                    this.PaNotes != null &&
                    this.PaNotes.SequenceEqual(input.PaNotes)
                ) && 
                (
                    this.AuthorityData == input.AuthorityData ||
                    (this.AuthorityData != null &&
                    this.AuthorityData.Equals(input.AuthorityData))
                ) && 
                (
                    this.GeneratePaProtocol == input.GeneratePaProtocol ||
                    (this.GeneratePaProtocol != null &&
                    this.GeneratePaProtocol.Equals(input.GeneratePaProtocol))
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
                if (this.ModelId != null)
                    hashCode = hashCode * 59 + this.ModelId.GetHashCode();
                if (this.ModelDescription != null)
                    hashCode = hashCode * 59 + this.ModelDescription.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.Behaviour != null)
                    hashCode = hashCode * 59 + this.Behaviour.GetHashCode();
                if (this.OpenModelAfterProfilation != null)
                    hashCode = hashCode * 59 + this.OpenModelAfterProfilation.GetHashCode();
                if (this.EditModelAfterProfilation != null)
                    hashCode = hashCode * 59 + this.EditModelAfterProfilation.GetHashCode();
                if (this.MaskId != null)
                    hashCode = hashCode * 59 + this.MaskId.GetHashCode();
                if (this.ShowOption != null)
                    hashCode = hashCode * 59 + this.ShowOption.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Document != null)
                    hashCode = hashCode * 59 + this.Document.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.PostProfilationActions != null)
                    hashCode = hashCode * 59 + this.PostProfilationActions.GetHashCode();
                if (this.ConstrainRoleBehaviour != null)
                    hashCode = hashCode * 59 + this.ConstrainRoleBehaviour.GetHashCode();
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.PaNotes != null)
                    hashCode = hashCode * 59 + this.PaNotes.GetHashCode();
                if (this.AuthorityData != null)
                    hashCode = hashCode * 59 + this.AuthorityData.GetHashCode();
                if (this.GeneratePaProtocol != null)
                    hashCode = hashCode * 59 + this.GeneratePaProtocol.GetHashCode();
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