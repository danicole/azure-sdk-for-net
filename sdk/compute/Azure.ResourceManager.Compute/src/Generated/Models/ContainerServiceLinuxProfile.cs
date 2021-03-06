// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Profile for Linux VMs in the container service cluster. </summary>
    public partial class ContainerServiceLinuxProfile
    {
        /// <summary> Initializes a new instance of ContainerServiceLinuxProfile. </summary>
        /// <param name="adminUsername"> The administrator username to use for Linux VMs. </param>
        /// <param name="ssh"> The ssh key configuration for Linux VMs. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="adminUsername"/> or <paramref name="ssh"/> is null. </exception>
        public ContainerServiceLinuxProfile(string adminUsername, ContainerServiceSshConfiguration ssh)
        {
            if (adminUsername == null)
            {
                throw new ArgumentNullException(nameof(adminUsername));
            }
            if (ssh == null)
            {
                throw new ArgumentNullException(nameof(ssh));
            }

            AdminUsername = adminUsername;
            Ssh = ssh;
        }

        /// <summary> The administrator username to use for Linux VMs. </summary>
        public string AdminUsername { get; set; }
        /// <summary> The ssh key configuration for Linux VMs. </summary>
        public ContainerServiceSshConfiguration Ssh { get; set; }
    }
}
