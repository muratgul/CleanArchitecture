using CleanArchitecture.Domain.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Domain.Entities;

public sealed class Plan : Entity
{
    [Key]
    public int id { get; set; }
    public string planNr { get; set; }
    public Int16 planType { get; set; }
    public DateTime planDate { get; set; }
    public Int16 status { get; set; }
    public int client { get; set; }
    public int parent { get; set; }
    public bool hasChild { get; set; }
    public bool createInWeighing { get; set; }
    public DateTime approveDate { get; set; }
    public string notes { get; set; }
}