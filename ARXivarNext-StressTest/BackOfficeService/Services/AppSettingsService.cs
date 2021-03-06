﻿using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.Extensions.Configuration;
using System;

namespace BackOfficeService.Services
{
    public class AppSettingsService : IAppSettingsService
    {
        private readonly IConfiguration _configuration;

        public AppSettingsService(Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            _configuration = configuration;

        }

        public int CacheMin
        {
            get
            {
                return _configuration.GetValue<int>("AppSettings:CacheMin");
            }
        }


        public string ARXivarNextWebApiUrl
        {
            get
            {
                return _configuration.GetValue<string>("AppSettings:ARXivarNextWebApiUrl");
            }
        }

        public string ARXivarNextAuthenticationUrl
        {
            get
            {
                return _configuration.GetValue<string>("AppSettings:ARXivarNextAuthenticationUrl");
            }
        }
        public string ARXivarNextClientId
        {
            get
            {
                return _configuration.GetValue<string>("AppSettings:ARXivarNextClientId");
            }
        }


        public string ARXivarNextClientSecret
        {
            get
            {
                return _configuration.GetValue<string>("AppSettings:ARXivarNextClientSecret");
            }
        }
        public string ARXivarNextUserName
        {
            get
            {
                return _configuration.GetValue<string>("AppSettings:ARXivarNextUserName");
            }
        }
        public string ARXivarNextPassword
        {
            get
            {
                return _configuration.GetValue<string>("AppSettings:ARXivarNextPassword");
            }
        }
        public string SwaggerUIPage
        {
            get
            {
                return _configuration.GetValue<string>("AppSettings:SwaggerUIPage");
            }
        }
        
        public Uri ElasticSearchApiUrl
        {
            get
            {
                var value = _configuration.GetValue<string>("AppSettings:ElasticSearchApiUrl");
                return new Uri(value);
            }
        }

        public bool HangFireUseMemoryStorage
        {
            get
            {
                return _configuration.GetValue<bool>("AppSettings:HangFireUseMemoryStorage");
            }
        }
        public int HangFireWorkerCount
        {
            get
            {
                var result = _configuration.GetValue<int>("AppSettings:HangFireWorkerCount");
                if (result <= 0)
                    result = 1;
                return result;
            }
        }
    }
}
