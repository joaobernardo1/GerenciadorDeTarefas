using GerenciadorDeTarefas.Communication.Enums;
namespace GerenciadorDeTarefas.Communication.Request;

public class RequestEditTaskJson
{
    public string NameTask { get; set; } = string.Empty;
    public string TaskDesc { get; set; } = string.Empty;
    public Priority Priority { get; set; }
    public Status Status { get; set; }
    public DateTime DeadLine { get; set; }
}
