using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tasklify.Contracts
{
    public class TasklifyTask :IValidatableObject
    {
        [JsonProperty("id", NullValueHandling=NullValueHandling.Ignore)]
        public int Id {get; private set;}
        [JsonProperty("summary")]
        [Required, StringLength(100, ErrorMessage = "{0} cannot exceed {1} characters")]
        public string Summary {get; set;}
        [JsonProperty("description", NullValueHandling=NullValueHandling.Ignore)]
        [StringLength(500, ErrorMessage = "{0} cannot exceed {1} characters")]
        public string Description {get; set;}

        public TasklifyTask(int id, string summary, string description)
        {
            if (!string.IsNullOrWhiteSpace(summary))
            {
                Id = id;
                Summary = summary;
                Description = description;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            return results;
        }
    }
}