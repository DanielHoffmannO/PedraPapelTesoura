namespace PedraPapelTesoura.Domain.Modal;
public class Result
{
    public Result(bool success, string message)
    {
        Success = success;
        Message = message;
    }

    public bool Success { get; set; }
    public string Message { get; set; }
}
