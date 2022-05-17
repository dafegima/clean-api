using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace User.Example.Application.PipelineBehaviors
{
    public class CustomValidationException : Exception
    {
        public CustomValidationException() : base() { }

        public CustomValidationException(List<CustomValidationModel> messages) : base(JsonConvert.SerializeObject(messages)) { }

        public CustomValidationException(List<CustomValidationModel> messages, params object[] args)
            : base(String.Format(CultureInfo.CurrentCulture, JsonConvert.SerializeObject(messages), args))
        {
        }
    }
}
