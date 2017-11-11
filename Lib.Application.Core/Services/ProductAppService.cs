using Lib.Application.Core.Interfaces;
using Lib.Domain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Application.Core.Services
{
    public class ProductAppService : IProductAppService
    {
        private readonly IProductService _productService;
        public ProductAppService(IProductService pProductService)
        {
            _productService = pProductService;
        }

        public void Save()
        {
            _productService.Save();
        }
    }
}