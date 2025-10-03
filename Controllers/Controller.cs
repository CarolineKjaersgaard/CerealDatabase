using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/[controller]")]

// Allows user to call endpoints in webserver
public class Controller : ControllerBase
{
    private readonly CommandService _commander;

    public Controller(AppDbContext db)
    {
        _commander = new CommandService(db);
    }

    // Endpoint for POST request
    [HttpPost("{name}")]
    public IActionResult PostCereal(Cereal cereal)
    {
        if (_commander.IsInDatabase(cereal.Name))
        {
            _commander.UpdateCereal(cereal);
        }
        else
        {
            _commander.AddCereal(cereal);
        }
        return NoContent();
    }

    // Endpoint for DELETE request
    [HttpDelete("{name}")]
    public IActionResult DeleteCereal(string name)
    {
        try
        {
            _commander.DeleteCereal(name);
            return NoContent();
        }
        catch (CerealNotFoundException)
        {
            return NotFound($"{name} not found in database");
        }
    }
}
