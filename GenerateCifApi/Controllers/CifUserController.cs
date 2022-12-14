using Confluent.Kafka;
using GenerateCifApi.Models;
using GenerateCifApi.Models.Dto;
using GenerateCifApi.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Newtonsoft.Json;
using System.Diagnostics;
using static Confluent.Kafka.ConfigPropertyNames;

namespace GenerateCifApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CifUserController : ControllerBase
    {
        protected ResponseDto _response;
        private ICifUserRepository _cifUserRepository;

        

        public CifUserController(ICifUserRepository cifUserRepository)
        {
            _cifUserRepository = cifUserRepository;
            this._response = new ResponseDto();

        }


        [HttpGet("{emailid}")]
        public async Task<object> GetCif(string emailid)
        {
            try
            {

                CifUserDto cifUserDto = await _cifUserRepository.GetCifbyemailID(emailid);
                _response.Result = cifUserDto;


            }
            catch (Exception ex)
            {
                _response.IsSuccess=false;
                _response.ErrorMessages= new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var config = new ConsumerConfig
            {
                GroupId= "test_group",
                BootstrapServers="localhost:29095",
                AutoOffsetReset=AutoOffsetReset.Earliest

            };

            using var consumer = new ConsumerBuilder<Null, string>(config).Build();
            consumer.Subscribe("test-topic");
            CancellationTokenSource token = new();
            try
            {
                while (true)
                {
                    var response = consumer.Consume(token.Token);
                        if (response.Message!=null)
                        {
                        
                        var message = JsonConvert.DeserializeObject(response.Message.Value);
                        
                        return Ok(message.ToString());
                    }

                }
            }
            catch (Exception)
            {
                throw;

            }




        }
    }
}
