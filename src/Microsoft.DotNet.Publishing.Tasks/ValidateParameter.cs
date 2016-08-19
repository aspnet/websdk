﻿using System;
using System.Globalization;
using Microsoft.Build.Framework;

namespace Microsoft.DotNet.Publishing.Tasks
{
    public class ValidateParameter : Build.Utilities.Task
    {
        [Required]
        public string ParameterName { get; set; }

        public string ParameterValue { get; set; }

        public override bool Execute()
        {
            if (String.IsNullOrEmpty(ParameterValue))
            {
                Log.LogError(String.Format(CultureInfo.CurrentCulture, SR.ValidateParameter_ArgumentNullError, ParameterName));
                return false;
            }

            return true;
        }
    }
}
