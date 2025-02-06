using GerenciadorDeTarefas.Application.UseCase.Create;
using GerenciadorDeTarefas.Application.UseCase.Delete;
using GerenciadorDeTarefas.Application.UseCase.Edit;
using GerenciadorDeTarefas.Application.UseCase.GetAll;
using GerenciadorDeTarefas.Application.UseCase.GetById;
using GerenciadorDeTarefas.Communication.Request;
using GerenciadorDeTarefas.Communication.Response;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeTarefas.API.Controllers;
[Route("api/[controller]")]
[ApiController]

public class Task : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseCreateTaskJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorJson),StatusCodes.Status400BadRequest)]
    public IActionResult CreateTask([FromBody] RequestCreateTaskJson request)
    {
        var useCase = new TaskCreateUseCase();
        var response = useCase.Execute(request);
        return NoContent();
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseCreateTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
    public IActionResult EditTask([FromRoute] int id, RequestEditTaskJson request)
    {
        var useCase = new EditTaskUseCase();
        var response = useCase.Execute(id, request);

        return Ok(response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<ResponseAllTaskJson>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAllTasks()
    {
        var useCase = new GetAllTaskUseCase();
        var response = useCase.Exetute();

        if (response.Tasks.Any())
        {
            return Ok(response);
        }
        return NoContent();
    }
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseCreateTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
    public IActionResult GetById([FromRoute] int id)
    {
        var useCase = new GetTaskByIdUseCase();
        var response = useCase.Execute(id);
        return Ok(response);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
    public IActionResult DeleteById([FromRoute] int id)
    {
        var useCase = new DeleteTaskUseCase();
        useCase.Execute(id);

        return NoContent();
    }
}
