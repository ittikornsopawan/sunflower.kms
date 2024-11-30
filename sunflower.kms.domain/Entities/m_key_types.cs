using System;
using System.ComponentModel.DataAnnotations;

namespace sunflower.kms.domain.Entities;

public class m_key_types
{
    [Key]
    public Guid id { get; set; }
    public required string code { get; set; }
    public required string name { get; set; }
    public string? description { get; set; }
    public string? created_by { get; set; }
    public DateTime created_date { get; set; }
    public string? updated_by { get; set; }
    public DateTime updated_date { get; set; }
}
