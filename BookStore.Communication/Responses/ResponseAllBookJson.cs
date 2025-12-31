namespace BookStore.Communication.Responses;
public class ResponseAllBookJson
{
    public List<ResponseShortBookJson> Books { get; set; } = new List<ResponseShortBookJson>();
}
