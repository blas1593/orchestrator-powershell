﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UiPath.Web.Client.Models;

namespace UiPath.PowerShell.Models
{
    public class Package
    {
        public string Id { get; private set; }
        public bool? IsActive { get; private set; }
        public bool? IsLatestVersion { get; private set; }
        public string Key { get; private set; }
        public string OldVersion { get; private set; }
        public DateTime? Published { get; private set; }
        public string Title { get; private set; }
        public string Version { get; private set; }
        public string Description { get; private set; }

        internal static Package FromDto(ProcessDto dto)
        {
            return new Package
            {
                Id = dto.Id,
                IsActive = dto.IsActive,
                IsLatestVersion = dto.IsLatestVersion,
                Key = dto.Key,
                OldVersion = dto.OldVersion,
                Published = dto.Published,
                Title = dto.Title,
                Version = dto.Version,
                Description = dto.Description
            };
        }
    }
}
