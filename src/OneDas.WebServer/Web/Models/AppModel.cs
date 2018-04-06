﻿using OneDas.Engine.Core;
using OneDas.Infrastructure;
using OneDas.Plugin;
using OneDas.WebServer.PackageManagement;
using System.Collections.Generic;

namespace OneDas.WebServer.Web
{
    public class AppModel
    {
        public AppModel(OneDasProjectSettings activeProjectSettings, IEnumerable<PackageMetaData> installedPackageSet, IEnumerable<string> clientSet, IEnumerable<PluginIdentificationAttribute> dataGatewayPluginIdentificationSet, IEnumerable<PluginIdentificationAttribute> dataWriterPluginIdentificationSet, string productVersion, string lastError, OneDasState oneDasState, WebServerOptionsLight webServerOptionsLight)
        {
            this.ProductVersion = productVersion;
            this.InstalledPackageSet = installedPackageSet;
            this.ActiveProjectSettings = activeProjectSettings;
            this.ClientSet = clientSet;
            this.DataGatewayPluginIdentificationSet = dataGatewayPluginIdentificationSet;
            this.DataWriterPluginIdentificationSet = dataWriterPluginIdentificationSet;
            this.LastError = lastError;
            this.OneDasState = oneDasState;
            this.WebServerOptionsLight = webServerOptionsLight;
        }

        // if this list is modified, remember to update method "Update()" in AppViewModel.ts
        public readonly OneDasProjectSettings ActiveProjectSettings;
        public readonly IEnumerable<PackageMetaData> InstalledPackageSet;
        public readonly IEnumerable<string> ClientSet;
        public readonly IEnumerable<PluginIdentificationAttribute> DataGatewayPluginIdentificationSet;
        public readonly IEnumerable<PluginIdentificationAttribute> DataWriterPluginIdentificationSet;
        public readonly string ProductVersion;
        public readonly string LastError;
        public readonly OneDasState OneDasState;
        public readonly WebServerOptionsLight WebServerOptionsLight;
    }
}
