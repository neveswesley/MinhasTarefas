using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;

namespace MinhasTarefas.Models;

public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; }
    
    [ForeignKey("UsuarioId")]
    public virtual ICollection<Tarefa> Tarefas { get; set; }
    
    [ForeignKey("UsuarioId")]
    public virtual ICollection<Token> Tokens { get; set; }
    
}