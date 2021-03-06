﻿
namespace InternPortal.UI.Models
{
    public class AuthenticationResult
    {
        public AuthenticationResult(string errorMessage = null)
        {
            ErrorMessage = errorMessage;
        }

        public string ErrorMessage { get; }
        public bool IsSuccess => string.IsNullOrEmpty(ErrorMessage);
    }
}