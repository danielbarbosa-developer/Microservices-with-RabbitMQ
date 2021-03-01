using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Abstractions.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Application.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeliveryController : ControllerBase
    {
        private readonly ILogger<DeliveryController> _logger;
        private readonly IDeliveryQueriesRepository _repository;

        public DeliveryController(ILogger<DeliveryController> logger, IDeliveryQueriesRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<IRestaurant> GetRestaurants(string city)
        {
            return _repository.GetAllRestaurants(city);
        }

        [HttpGet]
        [Route("{id}")]
        public IEnumerable<IFood> GetFoods(int id)
        {
            return _repository.GetAllFoods("");
        }
        
    }
}

   