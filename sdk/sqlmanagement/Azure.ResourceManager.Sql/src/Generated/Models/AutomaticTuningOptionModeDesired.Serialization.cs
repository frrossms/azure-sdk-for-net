// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    internal static class AutomaticTuningOptionModeDesiredExtensions
    {
        public static string ToSerialString(this AutomaticTuningOptionModeDesired value) => value switch
        {
            AutomaticTuningOptionModeDesired.Off => "Off",
            AutomaticTuningOptionModeDesired.On => "On",
            AutomaticTuningOptionModeDesired.Default => "Default",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AutomaticTuningOptionModeDesired value.")
        };

        public static AutomaticTuningOptionModeDesired ToAutomaticTuningOptionModeDesired(this string value)
        {
            if (string.Equals(value, "Off", StringComparison.InvariantCultureIgnoreCase)) return AutomaticTuningOptionModeDesired.Off;
            if (string.Equals(value, "On", StringComparison.InvariantCultureIgnoreCase)) return AutomaticTuningOptionModeDesired.On;
            if (string.Equals(value, "Default", StringComparison.InvariantCultureIgnoreCase)) return AutomaticTuningOptionModeDesired.Default;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AutomaticTuningOptionModeDesired value.");
        }
    }
}