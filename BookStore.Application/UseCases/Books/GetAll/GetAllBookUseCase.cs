using BookStore.Communication.Responses;

namespace BookStore.Application.UseCases.Books.GetAll;
public class GetAllBookUseCase
{
    public ResponseAllBookJson Execute()
    {
        // Lógica para obter todos os livros do sistema
        // Exemplo: Buscar os livros no banco de dados e retornar uma lista
        return new ResponseAllBookJson
        {
            Books = new List<ResponseShortBookJson>
            {
                new ResponseShortBookJson
                {
                    Id = Guid.NewGuid(),
                    Title = "Sample Book",
                    Type = Communication.Enums.BookType.Romance,
                }
            }
        };
    }
}
