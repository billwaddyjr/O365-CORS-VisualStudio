﻿using System;
using System.Configuration;

namespace Office365CORS
{
    public class SettingsHelper
    {
        private static string _clientId = ConfigurationManager.AppSettings["ida:ClientId"] ?? ConfigurationManager.AppSettings["ida:ClientID"];
        private static string _appKey = ConfigurationManager.AppSettings["ida:AppKey"] ?? ConfigurationManager.AppSettings["ida:Password"];
        private static string _tenant = ConfigurationManager.AppSettings["ida:Tenant"];

        private static string _authorizationUri = "https://login.windows-ppe.net";
        private static string _graphResourceId = "https://graph.ppe.windows.net";
        private static string _authority = "https://login.windows-ppe.net/common/";
        private static string _discoverySvcResourceId = "https://api.officeppe.com/discovery/";
        private static string _discoverySvcEndpointUri = "https://api.officeppe.com/discovery/v1.0/me/";

        public static string Tenant
        {
            get
            {
                return _tenant;
            }
        }

        public static string ClientId
        {
            get
            {
                return _clientId;
            }
        }

        public static string AppKey
        {
            get
            {
                return _appKey;
            }
        }

        public static string AuthorizationUri
        {
            get
            {
                return _authorizationUri;
            }
        }

        public static string Authority
        {
            get
            {
                return _authority;
            }
        }

        public static string AADGraphResourceId
        {
            get
            {
                return _graphResourceId;
            }
        }

        public static string DiscoveryServiceResourceId
        {
            get
            {
                return _discoverySvcResourceId;
            }
        }

        public static Uri DiscoveryServiceEndpointUri
        {
            get
            {
                return new Uri(_discoverySvcEndpointUri);
            }
        }
    }
}