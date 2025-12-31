using BookStore.Communication.Enums;

namespace BookStore.Communication.Responses;
public class ResponseShortBookJson
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public BookType Type { get; set; }
}
