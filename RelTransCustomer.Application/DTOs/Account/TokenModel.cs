﻿namespace RelTransCustomer.Application.DTOs.Account
{
    public record TokenModel
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
