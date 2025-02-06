using GerenciadorDeTarefas.Communication.Response;

namespace GerenciadorDeTarefas.Application.UseCase.GetById;

public class GetTaskByIdUseCase
{
    public ResponseCreateTaskJson Execute(int id)
    {
        return new ResponseCreateTaskJson
        {
            Id = id,
            NameTask = "Test",
            Status = Communication.Enums.Status.concluida,
            TaskDesc = "Lorem Impsum"
        };
    }
}
