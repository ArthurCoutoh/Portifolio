namespace PortifolioBlazor.Models;

public class Project
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Icon { get; set; } = "💻";
    public string Status { get; set; } = "completed"; // "completed" | "progress"
    public List<string> Tags { get; set; } = new();
    public string? GitHubUrl { get; set; }
    public string? DemoUrl { get; set; }
    public string Language { get; set; } = "C#";
}
