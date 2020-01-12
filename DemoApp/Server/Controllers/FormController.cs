using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorClient.Shared;
using DemoApp.Server.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FormController : ControllerBase
    {
        public FormController(/*ICustomValidator validator*/)
        {
            //_validator = validator;
        }

        [HttpGet]
        public FormModel Get()
        {
            return new FormModel
            {
                Text = "bla",
                Select = 2,
            };
        }

        [HttpPost]
        public ResponseObject<FormModel> Post(FormModel model)
        {
            var response = new ResponseObject<FormModel>
            {
                Data = model
            };

            if (CustomValidator.Validate(model))
            {
                response.Ok = true;
                response.Message = "Model is valid";
                Response.StatusCode = 201;
            }
            else
            {
                response.Ok = false;
                response.Message = "Model is invalid";
            }
            return response;
        }
    }
}