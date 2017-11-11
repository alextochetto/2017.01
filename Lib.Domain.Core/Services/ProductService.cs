using Lib.Domain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Options;
using Lib.Infra.Helpers.Settings;

namespace Lib.Domain.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IOptions<AppSettings> _appSettings;
        public ProductService(IOptions<AppSettings> pAppSettings)
        {
            _appSettings = pAppSettings;
        }
        public void Save()
        {

        }
    }
}
