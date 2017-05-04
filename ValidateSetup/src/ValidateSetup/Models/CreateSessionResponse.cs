// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ValidateSetup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CreateSessionResponse
    {
        /// <summary>
        /// Initializes a new instance of the CreateSessionResponse class.
        /// </summary>
        public CreateSessionResponse()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreateSessionResponse class.
        /// </summary>
        /// <param name="sessionId">Id of the newly created session.</param>
        public CreateSessionResponse(string sessionId = default(string))
        {
            SessionId = sessionId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of the newly created session.
        /// </summary>
        [JsonProperty(PropertyName = "sessionId")]
        public string SessionId { get; set; }

    }
}
