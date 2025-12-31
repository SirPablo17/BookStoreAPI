using BookStore.Communication.Enums;

namespace BookStore.Communication.Requests;
public class RequestBookJson
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public BookType Type { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }

}
