using System;
using Microsoft.AspNetCore.Mvc;
using RegnskabAPI.mysql;
using System.Linq;
using System.Collections.Generic;

namespace RegnskabAPI.Controllers
{
[ApiController]
[Route("[controller]")]
public class RegnskabController
{
holmsennels_dk_dbContext _holmsennels_dk_dbContextDBContext;
public RegnskabController(holmsennels_dk_dbContext cpcontxt)
{
_holmsennels_dk_dbContextDBContext = cpcontxt;
}



[HttpGet]
public List<Kontostam> Get()
{
     return _holmsennels_dk_dbContextDBContext.Kontostam.ToList();
 }


[HttpGet("{Id}")]
public string Get(int Id)
{
return "Trip was : " + Id.ToString();

}




}


}