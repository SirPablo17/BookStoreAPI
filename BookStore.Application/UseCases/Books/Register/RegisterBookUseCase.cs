using BookStore.Communication.Requests;
using BookStore.Communication.Responses;

namespace BookStore.Application.UseCases.Books.Register;

public class RegisterBookUseCase
{
    public ResponseRegisterBookJson Execute(RequestBookJson request)
    {
        // 1. Valida os dados (incluindo regra de duplicidade)
        Validate(request);

        // 2. Simula a criação da entidade (futuramente aqui você salva no banco)
        var entity = new
        {
            Id = Guid.NewGuid(),
            Title = request.Title,
            Author = request.Author,
            Type = request.Type,
            Price = request.Price,
            Stock = request.Stock
        };

        // 3. Retorna a resposta preenchida (Correção do erro de JSON vazio)
        return new ResponseRegisterBookJson
        {
            Id = entity.Id,
            Title = entity.Title
        };
    }

    private void Validate(RequestBookJson request)
    {
        var erros = new List<string>();

        // --- VALIDAÇÃO DE TÍTULO ---
        // Se for vazio OU menor que 2 OU maior que 120 -> ERRO
        if (string.IsNullOrWhiteSpace(request.Title) || request.Title.Length < 2 || request.Title.Length > 120)
        {
            erros.Add("O título é obrigatório e deve ter entre 2 e 120 caracteres.");
        }

        // --- VALIDAÇÃO DE AUTOR ---
        if (string.IsNullOrWhiteSpace(request.Author) || request.Author.Length < 2 || request.Author.Length > 120)
        {
            erros.Add("O autor é obrigatório e deve ter entre 2 e 120 caracteres.");
        }

        // --- VALIDAÇÃO DE PREÇO ---
        if (request.Price <= 0)
        {
            erros.Add("O preço deve ser maior que zero.");
        }

        // --- VALIDAÇÃO DE ESTOQUE ---
        if (request.Stock < 0)
        {
            erros.Add("O estoque não pode ser negativo.");
        }

        // --- VALIDAÇÃO DE DUPLICIDADE (Simulada) ---
        if (ExisteLivroComMesmoTituloEAutor(request.Title, request.Author))
        {
            erros.Add("Já existe um livro cadastrado com este título e autor.");
        }

        // SE HOUVER ERROS, LANÇA A EXCEÇÃO
        if (erros.Count > 0)
        {
            var mensagemFinal = string.Join("; ", erros);
            throw new ArgumentException(mensagemFinal);
        }
    }

    // Método auxiliar para simular o Banco de Dados
    // Futuramente, isso será substituído por uma chamada ao Repository
    private bool ExisteLivroComMesmoTituloEAutor(string title, string author)
    {
        return false;
    }
}