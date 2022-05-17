using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json;
using User.Example.Domain.Exceptions.Models;

namespace User.Example.Domain.Exceptions
{
    public class CustomValidationException : Exception
    {
        public CustomValidationException() : base() { }

        public CustomValidationException(List<CustomValidationModel> messages) : base(JsonSerializer.Serialize(messages)) { }

        public CustomValidationException(List<CustomValidationModel> messages, params object[] args)
            : base(String.Format(CultureInfo.CurrentCulture, JsonSerializer.Serialize(messages), args))
        {
        }
    }
}
