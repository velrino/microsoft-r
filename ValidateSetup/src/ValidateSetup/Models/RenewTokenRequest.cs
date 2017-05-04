// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ValidateSetup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class RenewTokenRequest
    {
        /// <summary>
        /// Initializes a new instance of the RenewTokenRequest class.
        /// </summary>
        public RenewTokenRequest()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RenewTokenRequest class.
        /// </summary>
        /// <param name="refreshToken">A currently valid refresh token.</param>
        public RenewTokenRequest(string refreshToken = default(string))
        {
            RefreshToken = refreshToken;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a currently valid refresh token.
        /// </summary>
        [JsonProperty(PropertyName = "refreshToken")]
        public string RefreshToken { get; set; }

    }
}
