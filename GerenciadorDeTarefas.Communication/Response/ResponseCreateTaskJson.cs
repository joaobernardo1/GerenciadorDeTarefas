using GerenciadorDeTarefas.Communication.Enums;
using GerenciadorDeTarefas.Communication.Request;

namespace GerenciadorDeTarefas.Communication.Response;

public class ResponseCreateTaskJson
{
    public int Id { get; set; }
    public string NameTask { get; set; } = string.Empty;
    public string TaskDesc { get; set; } = string.Empty;
    public Status Status { get; set; }

}
