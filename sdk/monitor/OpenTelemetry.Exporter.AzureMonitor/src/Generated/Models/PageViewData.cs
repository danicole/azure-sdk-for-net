// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace OpenTelemetry.Exporter.AzureMonitor.Models
{
    /// <summary> An instance of PageView represents a generic action on a page like a button click. It is also the base type for PageView. </summary>
    public partial class PageViewData : MonitorDomain
    {
        /// <summary> Initializes a new instance of PageViewData. </summary>
        /// <param name="ver"> Schema version. </param>
        /// <param name="id"> Identifier of a page view instance. Used for correlation between page view and other telemetry items. </param>
        /// <param name="name"> Event name. Keep it low cardinality to allow proper grouping and useful metrics. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="name"/> is null. </exception>
        public PageViewData(int ver, string id, string name)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Ver = ver;
            Id = id;
            Name = name;
            Properties = new ChangeTrackingDictionary<string, string>();
            Measurements = new ChangeTrackingDictionary<string, double>();
        }

        /// <summary> Initializes a new instance of PageViewData. </summary>
        /// <param name="test"> Ignored value. </param>
        /// <param name="ver"> Schema version. </param>
        /// <param name="id"> Identifier of a page view instance. Used for correlation between page view and other telemetry items. </param>
        /// <param name="name"> Event name. Keep it low cardinality to allow proper grouping and useful metrics. </param>
        /// <param name="url"> Request URL with all query string parameters. </param>
        /// <param name="duration"> Request duration in format: DD.HH:MM:SS.MMMMMM. For a page view (PageViewData), this is the duration. For a page view with performance information (PageViewPerfData), this is the page load time. Must be less than 1000 days. </param>
        /// <param name="referredUri"> Fully qualified page URI or URL of the referring page; if unknown, leave blank. </param>
        /// <param name="properties"> Collection of custom properties. TODO: max key length validate. </param>
        /// <param name="measurements"> Collection of custom measurements. TODO: max key length validate. </param>
        internal PageViewData(string test, int ver, string id, string name, string url, TimeSpan? duration, string referredUri, IDictionary<string, string> properties, IDictionary<string, double> measurements) : base(test)
        {
            Ver = ver;
            Id = id;
            Name = name;
            Url = url;
            Duration = duration;
            ReferredUri = referredUri;
            Properties = properties;
            Measurements = measurements;
        }

        /// <summary> Schema version. </summary>
        public int Ver { get; set; }
        /// <summary> Identifier of a page view instance. Used for correlation between page view and other telemetry items. </summary>
        public string Id { get; set; }
        /// <summary> Event name. Keep it low cardinality to allow proper grouping and useful metrics. </summary>
        public string Name { get; set; }
        /// <summary> Request URL with all query string parameters. </summary>
        public string Url { get; set; }
        /// <summary> Request duration in format: DD.HH:MM:SS.MMMMMM. For a page view (PageViewData), this is the duration. For a page view with performance information (PageViewPerfData), this is the page load time. Must be less than 1000 days. </summary>
        public TimeSpan? Duration { get; set; }
        /// <summary> Fully qualified page URI or URL of the referring page; if unknown, leave blank. </summary>
        public string ReferredUri { get; set; }
        /// <summary> Collection of custom properties. TODO: max key length validate. </summary>
        public IDictionary<string, string> Properties { get; }
        /// <summary> Collection of custom measurements. TODO: max key length validate. </summary>
        public IDictionary<string, double> Measurements { get; }
    }
}
