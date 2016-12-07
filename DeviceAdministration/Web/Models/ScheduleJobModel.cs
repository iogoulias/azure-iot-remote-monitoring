﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.Azure.Devices.Applications.RemoteMonitoring.DeviceAdmin.Web.Models
{
    public class ScheduleJobViewModel
    {
        [Required]
        public string FilterId { get; set; }

        [Required]
        public string FilterName { get; set; }

        [Required]
        public string JobName { get; set; }

        [Required]
        public DateTime StartDateUtc { get; set; }

        [Required]
        public int MaxExecutionTimeInMinutes { get; set; }
    }
}