// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies the configuration parameters for automatic repairs on the virtual machine scale set. </summary>
    public partial class AutomaticRepairsPolicy
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AutomaticRepairsPolicy"/>. </summary>
        public AutomaticRepairsPolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AutomaticRepairsPolicy"/>. </summary>
        /// <param name="enabled"> Specifies whether automatic repairs should be enabled on the virtual machine scale set. The default value is false. </param>
        /// <param name="gracePeriod"> The amount of time for which automatic repairs are suspended due to a state change on VM. The grace time starts after the state change has completed. This helps avoid premature or accidental repairs. The time duration should be specified in ISO 8601 format. The minimum allowed grace period is 10 minutes (PT10M), which is also the default value. The maximum allowed grace period is 90 minutes (PT90M). </param>
        /// <param name="repairAction"> Type of repair action (replace, restart, reimage) that will be used for repairing unhealthy virtual machines in the scale set. Default value is replace. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomaticRepairsPolicy(bool? enabled, string gracePeriod, RepairAction? repairAction, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Enabled = enabled;
            GracePeriod = gracePeriod;
            RepairAction = repairAction;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies whether automatic repairs should be enabled on the virtual machine scale set. The default value is false. </summary>
        public bool? Enabled { get; set; }
        /// <summary> The amount of time for which automatic repairs are suspended due to a state change on VM. The grace time starts after the state change has completed. This helps avoid premature or accidental repairs. The time duration should be specified in ISO 8601 format. The minimum allowed grace period is 10 minutes (PT10M), which is also the default value. The maximum allowed grace period is 90 minutes (PT90M). </summary>
        public string GracePeriod { get; set; }
        /// <summary> Type of repair action (replace, restart, reimage) that will be used for repairing unhealthy virtual machines in the scale set. Default value is replace. </summary>
        public RepairAction? RepairAction { get; set; }
    }
}
