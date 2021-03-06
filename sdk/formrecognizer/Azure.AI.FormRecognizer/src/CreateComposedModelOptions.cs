﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.FormRecognizer.Training
{
    /// <summary>
    /// The set of options that can be specified when calling the create composed model method
    /// to configure the behavior of the request.
    /// </summary>
    public class CreateComposedModelOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateComposedModelOptions"/> class.
        /// </summary>
        public CreateComposedModelOptions()
        {
        }

        /// <summary>
        /// An optional, user-defined name to associate with your model.
        /// </summary>
        public string ModelName { get; set; }
    }
}
