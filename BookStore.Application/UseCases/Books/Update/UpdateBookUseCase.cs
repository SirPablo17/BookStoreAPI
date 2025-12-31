using BookStore.Communication.Requests;

namespace BookStore.Application.UseCases.Books.Update;

public class UpdateBookUseCase
{
    public void Execute(Guid id, RequestBookJson request)
    {
        // 1. Validamos os dados recebidos
        Validate(id, request);
    }

    private void Validate(Guid id, RequestBookJson request)
    {
        var erros = new List<string>();

        // --- VALIDAÇÃO 1: O ID EXISTE? ---
        // Simulamos que se o ID for vazio, o livro não existe.
        // No futuro, aqui você usará: if (_repository.Exists(id) == false)
        if (id == Guid.Empty)
        {
            erros.Add("O ID do livro não foi encontrado.");
        }

        // --- VALIDAÇÃO 2: TÍTULO ---
        if (string.IsNullOrWhiteSpace(request.Title) || request.Title.Length < 2 || request.Title.Length > 120)
        {
            erros.Add("O título é obrigatório e deve ter entre 2 e 120 caracteres.");
        }

        // --- VALIDAÇÃO 3: AUTOR ---
        if (string.IsNullOrWhiteSpace(request.Author) || request.Author.Length < 2 || request.Author.Length > 120)
        {
            erros.Add("O autor é obrigatório e deve ter entre 2 e 120 caracteres.");
        }

        // --- VALIDAÇÃO 4: PREÇO ---
        if (request.Price <= 0)
        {
            erros.Add("O preço deve ser maior que zero.");
        }

        // --- VALIDAÇÃO 5: ESTOQUE ---
        if (request.Stock < 0)
        {
            erros.Add("O estoque não pode ser negativo.");
        }

        // SE HOUVER ERROS, LANÇA A EXCEÇÃO
        if (erros.Count > 0)
        {
            var mensagemFinal = string.Join("; ", erros);
            throw new ArgumentException(mensagemFinal);
        }
    }
}