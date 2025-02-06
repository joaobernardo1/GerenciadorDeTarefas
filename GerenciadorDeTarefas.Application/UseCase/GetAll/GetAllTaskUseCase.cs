using GerenciadorDeTarefas.Communication.Response;

namespace GerenciadorDeTarefas.Application.UseCase.GetAll;
public class GetAllTaskUseCase
{
    public ResponseAllTaskJson Exetute()
    {
        return new ResponseAllTaskJson()
        {
            Tasks = new List<ResponseShortTaskDescJson>
            {
                new ResponseShortTaskDescJson
                {
                NameTask = "Teste",
                Status = Communication.Enums.Status.em_andamento,
                TaskDesc = "Lorem Imsum"
                }
            }
        };
    }
}
