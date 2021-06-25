using roofstock.Core.Repository;
using roofstock.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;


namespace roofstockaspmvcversion.Api.Controller
{
    public class PropertyDataController : ApiController
    {
        IPropertyRepository _propertyRepository = new PropertyRepository();

        [HttpGet]
        public IEnumerable<PropertyViewModel> GetAllProperty()
        {
            var propertyModel = _propertyRepository.GetAll();
            return propertyModel;
        }
    }
}
