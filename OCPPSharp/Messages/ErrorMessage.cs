namespace OCPPSharp.Messages;

public class ErrorMessage
{
    public string ErrorCode { get; set; }
    public string ErrorDescription { get; set; }

    public object ErrorDetails { get; set; }
}
