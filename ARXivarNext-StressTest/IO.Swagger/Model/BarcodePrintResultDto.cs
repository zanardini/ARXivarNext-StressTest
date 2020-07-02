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
    /// Class of result of print barcode
    /// </summary>
    [DataContract]
    public partial class BarcodePrintResultDto :  IEquatable<BarcodePrintResultDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BarcodePrintResultDto" /> class.
        /// </summary>
        /// <param name="printMethod">Possible values:  0: Client  1: Server  2: ClientFile  3: TerminalServer .</param>
        /// <param name="printerDataMode">Possible values:  0: MachineLanguage  1: GraphicData .</param>
        /// <param name="printerName">Printer Name.</param>
        /// <param name="machineLanguageText">Language Machine.</param>
        /// <param name="graphicTemplateB64">Graphic Template Blob.</param>
        /// <param name="templateDattableB64">Origin Datatable.</param>
        public BarcodePrintResultDto(int? printMethod = default(int?), int? printerDataMode = default(int?), string printerName = default(string), string machineLanguageText = default(string), string graphicTemplateB64 = default(string), string templateDattableB64 = default(string))
        {
            this.PrintMethod = printMethod;
            this.PrinterDataMode = printerDataMode;
            this.PrinterName = printerName;
            this.MachineLanguageText = machineLanguageText;
            this.GraphicTemplateB64 = graphicTemplateB64;
            this.TemplateDattableB64 = templateDattableB64;
        }
        
        /// <summary>
        /// Possible values:  0: Client  1: Server  2: ClientFile  3: TerminalServer 
        /// </summary>
        /// <value>Possible values:  0: Client  1: Server  2: ClientFile  3: TerminalServer </value>
        [DataMember(Name="printMethod", EmitDefaultValue=false)]
        public int? PrintMethod { get; set; }

        /// <summary>
        /// Possible values:  0: MachineLanguage  1: GraphicData 
        /// </summary>
        /// <value>Possible values:  0: MachineLanguage  1: GraphicData </value>
        [DataMember(Name="printerDataMode", EmitDefaultValue=false)]
        public int? PrinterDataMode { get; set; }

        /// <summary>
        /// Printer Name
        /// </summary>
        /// <value>Printer Name</value>
        [DataMember(Name="printerName", EmitDefaultValue=false)]
        public string PrinterName { get; set; }

        /// <summary>
        /// Language Machine
        /// </summary>
        /// <value>Language Machine</value>
        [DataMember(Name="machineLanguageText", EmitDefaultValue=false)]
        public string MachineLanguageText { get; set; }

        /// <summary>
        /// Graphic Template Blob
        /// </summary>
        /// <value>Graphic Template Blob</value>
        [DataMember(Name="graphicTemplateB64", EmitDefaultValue=false)]
        public string GraphicTemplateB64 { get; set; }

        /// <summary>
        /// Origin Datatable
        /// </summary>
        /// <value>Origin Datatable</value>
        [DataMember(Name="templateDattableB64", EmitDefaultValue=false)]
        public string TemplateDattableB64 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BarcodePrintResultDto {\n");
            sb.Append("  PrintMethod: ").Append(PrintMethod).Append("\n");
            sb.Append("  PrinterDataMode: ").Append(PrinterDataMode).Append("\n");
            sb.Append("  PrinterName: ").Append(PrinterName).Append("\n");
            sb.Append("  MachineLanguageText: ").Append(MachineLanguageText).Append("\n");
            sb.Append("  GraphicTemplateB64: ").Append(GraphicTemplateB64).Append("\n");
            sb.Append("  TemplateDattableB64: ").Append(TemplateDattableB64).Append("\n");
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
            return this.Equals(input as BarcodePrintResultDto);
        }

        /// <summary>
        /// Returns true if BarcodePrintResultDto instances are equal
        /// </summary>
        /// <param name="input">Instance of BarcodePrintResultDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BarcodePrintResultDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PrintMethod == input.PrintMethod ||
                    (this.PrintMethod != null &&
                    this.PrintMethod.Equals(input.PrintMethod))
                ) && 
                (
                    this.PrinterDataMode == input.PrinterDataMode ||
                    (this.PrinterDataMode != null &&
                    this.PrinterDataMode.Equals(input.PrinterDataMode))
                ) && 
                (
                    this.PrinterName == input.PrinterName ||
                    (this.PrinterName != null &&
                    this.PrinterName.Equals(input.PrinterName))
                ) && 
                (
                    this.MachineLanguageText == input.MachineLanguageText ||
                    (this.MachineLanguageText != null &&
                    this.MachineLanguageText.Equals(input.MachineLanguageText))
                ) && 
                (
                    this.GraphicTemplateB64 == input.GraphicTemplateB64 ||
                    (this.GraphicTemplateB64 != null &&
                    this.GraphicTemplateB64.Equals(input.GraphicTemplateB64))
                ) && 
                (
                    this.TemplateDattableB64 == input.TemplateDattableB64 ||
                    (this.TemplateDattableB64 != null &&
                    this.TemplateDattableB64.Equals(input.TemplateDattableB64))
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
                if (this.PrintMethod != null)
                    hashCode = hashCode * 59 + this.PrintMethod.GetHashCode();
                if (this.PrinterDataMode != null)
                    hashCode = hashCode * 59 + this.PrinterDataMode.GetHashCode();
                if (this.PrinterName != null)
                    hashCode = hashCode * 59 + this.PrinterName.GetHashCode();
                if (this.MachineLanguageText != null)
                    hashCode = hashCode * 59 + this.MachineLanguageText.GetHashCode();
                if (this.GraphicTemplateB64 != null)
                    hashCode = hashCode * 59 + this.GraphicTemplateB64.GetHashCode();
                if (this.TemplateDattableB64 != null)
                    hashCode = hashCode * 59 + this.TemplateDattableB64.GetHashCode();
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
