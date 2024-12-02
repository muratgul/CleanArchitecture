using CleanArchitecture.Domain.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Domain.Entities;

public sealed class ErrorLog : Entity
{
    [Key]
    public int Id { get; set; }
    public string ErrorMessage { get; set; }
    public string StackTrace { get; set; }
    public string RequestPath { get; set; }
    public string RequestMethod { get; set; }
    public DateTime Timestamp { get; set; }
}
