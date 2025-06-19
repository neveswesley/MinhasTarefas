using MinhasTarefas.Models;

namespace MinhasTarefas.Repositories.Interfaces;

public interface ITokenRepository
{
    void CadastrarToken(Token token);
    Token ObterToken(string refreshToken);
    void AtualizarToken(Token token);

}