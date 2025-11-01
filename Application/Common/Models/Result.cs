
namespace Application.Common.Models;

internal class Result
{
    internal Result(bool successed, IEnumerable<string> errors)
    {
        Successed = successed;
        Errors = errors.ToArray();
    }

    public bool Successed { get; set; }
    public string[] Errors { get; set; }
    public static Result Success()
    {
        return new Result(true, Array.Empty<string>());
    }
    public static Result Failure(IEnumerable<string> errors)
    {
        return new Result(false, errors);
    }
}
