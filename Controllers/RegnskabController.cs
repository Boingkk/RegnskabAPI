using System;
using Microsoft.AspNetCore.Mvc;
namespace RegnskabAPI.Controllers
{
[ApiController]
[Route("[controller]")]
public class RegnskabController
{
[HttpGet]
public string Get()
{
return "Hello world";
}

[HttpGet("{Id}")]
public string Get(int Id)
{
return "Trip was : " + Id.ToString();
}


}


}