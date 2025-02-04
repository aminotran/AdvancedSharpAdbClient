﻿// <copyright file="FileStatistics.cs" company="The Android Open Source Project, Ryan Conrad, Quamotion, yungd1plomat, wherewhere">
// Copyright (c) The Android Open Source Project, Ryan Conrad, Quamotion, yungd1plomat, wherewhere. All rights reserved.
// </copyright>

using System;

namespace AdvancedSharpAdbClient
{
    /// <summary>
    /// Contains information about a file on the remote device.
    /// </summary>
    public class FileStatistics
    {
        /// <summary>
        /// Gets or sets the path of the file.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="UnixFileMode"/> attributes of the file.
        /// </summary>
        public UnixFileMode FileMode { get; set; }

        /// <summary>
        /// Gets or sets the total file size, in bytes.
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// Gets or sets the time of last modification.
        /// </summary>
        public DateTimeOffset Time { get; set; }

        /// <summary>
        /// Gets a <see cref="string"/> that represents the current <see cref="FileStatistics"/> object.
        /// </summary>
        /// <returns>The <see cref="Path"/> of the current <see cref="FileStatistics"/> object.</returns>
        public override string ToString() => Path;
    }
}
