/* 
 * videoapi
 *
 * The video APIs help you convert, encode, and transcode videos.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Client.SwaggerDateConverter;

namespace Cloudmersive.APIClient.NETCore.VideoAndMediaServices.Model
{
    /// <summary>
    /// A video file
    /// </summary>
    [DataContract]
    public partial class VideoFile :  IEquatable<VideoFile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoFile" /> class.
        /// </summary>
        /// <param name="videoNumber">Sequence number of the video.</param>
        /// <param name="content">The video file as a byte array.</param>
        public VideoFile(int? videoNumber = default(int?), byte[] content = default(byte[]))
        {
            this.VideoNumber = videoNumber;
            this.Content = content;
        }
        
        /// <summary>
        /// Sequence number of the video
        /// </summary>
        /// <value>Sequence number of the video</value>
        [DataMember(Name="VideoNumber", EmitDefaultValue=false)]
        public int? VideoNumber { get; set; }

        /// <summary>
        /// The video file as a byte array
        /// </summary>
        /// <value>The video file as a byte array</value>
        [DataMember(Name="Content", EmitDefaultValue=false)]
        public byte[] Content { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoFile {\n");
            sb.Append("  VideoNumber: ").Append(VideoNumber).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
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
            return this.Equals(input as VideoFile);
        }

        /// <summary>
        /// Returns true if VideoFile instances are equal
        /// </summary>
        /// <param name="input">Instance of VideoFile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VideoFile input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VideoNumber == input.VideoNumber ||
                    (this.VideoNumber != null &&
                    this.VideoNumber.Equals(input.VideoNumber))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
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
                if (this.VideoNumber != null)
                    hashCode = hashCode * 59 + this.VideoNumber.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                return hashCode;
            }
        }
    }

}
