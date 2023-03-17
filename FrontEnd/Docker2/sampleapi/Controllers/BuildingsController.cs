using Microsoft.AspNetCore.Mvc;
[Route("api/[controller]")]
[ApiController]
public class BuildingsController:ControllerBase{
    [HttpGet]
    public IEnumerable<string> Get(){
    return new string[]{"hello"};
}
}