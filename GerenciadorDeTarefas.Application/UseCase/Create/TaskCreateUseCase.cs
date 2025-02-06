using GerenciadorDeTarefas.Communication.Request;
using GerenciadorDeTarefas.Communication.Response;

namespace GerenciadorDeTarefas.Application.UseCase.Create;

public class TaskCreateUseCase
{
    public ResponseCreateTaskJson Execute(RequestCreateTaskJson request)
    {
        return new ResponseCreateTaskJson
        {
            Id = 1,
            NameTask = request.NameTask,
            TaskDesc = request.TaskDesc,
            Status = request.Status
        };
    }
}
