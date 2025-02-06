using GerenciadorDeTarefas.Communication.Enums;
namespace GerenciadorDeTarefas.Communication.Response;

public class ResponseShortTaskDescJson
{
    public string NameTask { get; set; } = string.Empty;
    public string TaskDesc { get; set; } = string.Empty;
    public Status Status { get; set; }
}
