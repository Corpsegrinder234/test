using System;

public class RepairRequest
{
    public int RequestNumber { get; set; }
    public DateTime DateAdded { get; set; }
    public string DeviceName { get; set; }
    public string IssueType { get; set; }
    public string IssueDescription { get; set; }
    public string ClientName { get; set; }
    public string Status { get; set; } = "В ожидании"; // По умолчанию "В ожидании"
}