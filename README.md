# 📚 Gerenciador de Livraria (BookStore API)

![Status](https://img.shields.io/badge/Status-Concluído-green)
![.NET](https://img.shields.io/badge/.NET-8.0-purple)
![C#](https://img.shields.io/badge/Language-C%23-blue)

## 📖 Sobre o Projeto

Esta API foi desenvolvida como parte do desafio técnico do curso de C# da **Rocketseat**. O objetivo foi construir uma API RESTful para o gerenciamento de uma livraria, aplicando boas práticas de programação, arquitetura em camadas e validações de regras de negócio.

O projeto simula um ambiente real de CRUD (Create, Read, Update, Delete), utilizando armazenamento em memória para persistência temporária dos dados.

## 🚀 Funcionalidades

- **Cadastrar Livros (POST):** Permite adicionar novos livros ao acervo com validações rigorosas.
- **Consultar Livros (GET):** - Listar todos os livros cadastrados.
- **Atualizar Livros (PUT):** Permite a edição de informações de um livro existente.
- **Remover Livros (DELETE):** Exclui um livro do acervo.

## 🛠️ Regras de Negócio e Validações

O sistema garante a integridade dos dados através das seguintes regras:
- **Campos Obrigatórios:** Título e Autor não podem ser vazios.
- **Tamanho do Texto:** Título e Autor devem ter entre 2 e 120 caracteres.
- **Preço e Estoque:** O preço deve ser maior que zero e o estoque não pode ser negativo.
- **Duplicidade:** Não é permitido cadastrar dois livros com o mesmo título e autor (simulação de verificação).
- **Tratamento de Erros:** Respostas HTTP adequadas (400 Bad Request, 404 Not Found) com mensagens claras de erro.

## 💻 Tecnologias Utilizadas

- **C#**
- **.NET 8** (ASP.NET Core Web API)
- **Swagger  (Para documentação e teste da API)
- **Arquitetura em Camadas** (Separação entre Communication, Application e API)

## 📂 Estrutura do Projeto

O projeto segue uma estrutura limpa para facilitar a manutenção e escalabilidade:

- `BookStore.API`: Camada de entrada (Controllers e configuração).
- `BookStore.Application`: Contém as regras de negócio (UseCases) e lógica de validação.
- `BookStore.Communication`: DTOs (Data Transfer Objects) para Requests e Responses.

## 🔧 Como Executar o Projeto

### Pré-requisitos
- .NET SDK instalado.
- Visual Studio 2022 ou VS Code.

### Passo a passo
1. Clone este repositório:
```bash
git clone [https://github.com/seu-usuario/nome-do-repositorio.git](https://github.com/seu-usuario/nome-do-repositorio.git)
