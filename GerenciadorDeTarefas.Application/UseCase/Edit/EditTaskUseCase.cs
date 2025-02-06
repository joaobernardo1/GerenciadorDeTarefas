using GerenciadorDeTarefas.Communication.Request;
using GerenciadorDeTarefas.Communication.Response;

namespace GerenciadorDeTarefas.Application.UseCase.Edit;

public class EditTaskUseCase
{
    public ResponseCreateTaskJson Execute(int id, RequestEditTaskJson request)
    {
        return new ResponseCreateTaskJson
        {
            Id = id,
            NameTask = request.NameTask,
            Status = request.Status,
            TaskDesc = request.TaskDesc
        };
    }
}
