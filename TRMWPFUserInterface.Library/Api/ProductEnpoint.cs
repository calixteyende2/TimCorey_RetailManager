﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TRMWPFUserInterface.Helpers;
using TRMWPFUserInterface.Library.Models;
using TRMWPFUserInterface.Models;

namespace TRMWPFUserInterface.Library.Api
{
    public class ProductEnpoint : IProductEnpoint
    {
        private IAPIHelper _apiHelper;
        public ProductEnpoint(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public async Task<IList<ProductModel>> GetAll()
        {
            using (HttpResponseMessage responseMessage = await _apiHelper.APIClient.GetAsync("api/Product/GetAll"))
            {
                if (responseMessage.IsSuccessStatusCode)
                {
                    var result = await responseMessage.Content.ReadAsAsync<IList<ProductModel>>();
                    return result;
                }
                else
                {
                    throw new Exception($"{responseMessage.ReasonPhrase}");
                }

            }
        }
    }
}
