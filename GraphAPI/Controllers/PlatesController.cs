using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphAPI.Models;
using GraphAPI.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraphAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatesController : ControllerBase
    {
        private readonly IDataRepository<Plate> _dataRepository;

        public PlatesController(IDataRepository<Plate> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public IActionResult Get()
        {
            var plates = _dataRepository.GetAll();
            return Ok(plates);
        }
    }
}