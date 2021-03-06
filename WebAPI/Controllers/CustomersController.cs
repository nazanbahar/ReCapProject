﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        //Loosely coupled
        //naming convention
        //IoC Container -- Inversion of Control
        ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }





        [HttpPost("add")]
        public IActionResult Add(Customer customer)
        {
            var result = _customerService.Add(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }





        [HttpPost("update")]
        public IActionResult Update(Customer customer)
        {
            var result = _customerService.Update(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }





        [HttpPost("delete")]
        public IActionResult Delete(Customer customer)
        {
            var result = _customerService.Delete(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }




        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Swagger
            //Dependencey chain --
            var result = _customerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }





        [HttpGet("getbyid")]
        public IActionResult GetById(int customerId)
        {
            var result = _customerService.GetById(customerId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }




        //(x) [HttpGet("getallcustomerdetails")]
        //(x) [HttpGet("getcustomerdetails")]
        [HttpGet("getalldetails")]
        public IActionResult getcustomerdetails()
        {
            var result = _customerService.GetAllDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



    }
}
