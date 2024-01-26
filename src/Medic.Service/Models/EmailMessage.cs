﻿namespace Medic.Service.Models;
    
public class EmailMessage
{
    public string Recipent { get; set; } = String.Empty;
    public string Title { get; set; } = String.Empty;
    public string Content { get; set; } = String.Empty;
}
