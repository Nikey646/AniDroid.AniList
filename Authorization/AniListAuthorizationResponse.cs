﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AniDroid.AniList.Authorization
{
    public class AniListAuthorizationResponse
    {
        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }
        [JsonProperty(PropertyName = "token_type")]
        public string TokenType { get; set; }
        [JsonProperty(PropertyName = "expires_in")]
        public int ExpiresIn { get; set; }
        [JsonProperty(PropertyName = "refresh_token")]
        public string RefreshToken { get; set; }
    }
}
