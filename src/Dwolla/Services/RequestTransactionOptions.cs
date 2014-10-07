﻿using Newtonsoft.Json;

namespace Dwolla.Services
{
    public partial class RequestTransactionOptions
    {
        /// <summary>
        /// A valid OAuth token
        /// </summary>
        [JsonProperty("oauth_token")]
        public string OAuthToken { get; set; }

        /// <summary>
        /// Identification of the user to request funds from. Must be the Dwolla, 
        /// Facebook, Twitter, phone or email identifier
        /// </summary>
        [JsonProperty("sourceId")]
        public string SourceId { get; set; }

        /// <summary>
        /// Type of destination user. Defaults to Dwolla. Can be Dwolla, Facebook, 
        /// Twitter, Email, or Phone
        /// </summary>
        [JsonProperty("sourceType")]
        public string SourceType { get; set; }

        /// <summary>
        /// Amount of funds to request from the source user.
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Amount of the facilitator fee to override. Only applicable if the 
        /// facilitator fee feature is enabled. If set to 0, facilitator fee is 
        /// dsiabled for transaction. Cannot exceed 25% of the 'amount'.
        /// </summary>
        [JsonProperty("facilitatorAmount")]
        public decimal FacilitatorAmount { get; set; }

        /// <summary>
        /// Note to attach to the transaction. Limited to 250 characters.
        /// </summary>
        [JsonProperty("notes")]
        public string Notes { get; set; }
    }
}
