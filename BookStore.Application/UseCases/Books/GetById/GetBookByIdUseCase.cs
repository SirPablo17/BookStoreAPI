using BookStore.Communication.Responses;

namespace BookStore.Application.UseCases.Books.GetById;
public class GetBookByIdUseCase
{
    public ResponseBookJson Execute(Guid id)
    {
        return new ResponseBookJson
        {
            Id = id,
            Title = "Fido",
            Author = "Tolkien",
            Type = Communication.Enums.BookType.Ficcao
        };
    }
}
