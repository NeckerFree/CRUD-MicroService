﻿using CommonLibrary.RabbitMQ;
using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;
using System.Text;
namespace Inventory.AuthAPI.Controllers
{
[Route("api/[controller]/[action]")]
    [ApiController]
    public class RabbitController : ControllerBase
    {
        private readonly IRabbitMQService _rabbitMqService;

        public RabbitController(IRabbitMQService rabbitMqService)
        {
            _rabbitMqService = rabbitMqService;
        }

        [HttpPost]
        public IActionResult SendMessage()
        {
            using var connection = _rabbitMqService.CreateChannel();
            using var model = connection.CreateModel();
            var body = Encoding.UTF8.GetBytes("Hi");
            model.BasicPublish("UserExchange",
                                 string.Empty,
                                 basicProperties: null,
                                 body: body);

            return Ok();
        }
    }
}
