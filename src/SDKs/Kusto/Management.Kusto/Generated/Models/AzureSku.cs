// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Kusto.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class AzureSku
    {
        /// <summary>
        /// Initializes a new instance of the AzureSku class.
        /// </summary>
        public AzureSku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureSku class.
        /// </summary>
        /// <param name="name">SKU name. Possible values include: 'KC8',
        /// 'KC16', 'KS8', 'KS16', 'D13_v2', 'D14_v2', 'L8', 'L16'</param>
        /// <param name="capacity">SKU capacity.</param>
        public AzureSku(string name, int? capacity = default(int?))
        {
            Name = name;
            Capacity = capacity;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for AzureSku class.
        /// </summary>
        static AzureSku()
        {
            Tier = "Standard";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets SKU name. Possible values include: 'KC8', 'KC16',
        /// 'KS8', 'KS16', 'D13_v2', 'D14_v2', 'L8', 'L16'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets SKU capacity.
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public int? Capacity { get; set; }

        /// <summary>
        /// SKU tier.
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public static string Tier { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
