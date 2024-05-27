namespace WhatsAppMaui.Models;
public record ChatModel(string Avatar, string Name, DateTime LastMessageTime, string LastMessage, int UnreadCount)

{
    public String LastMessageTimeDisplay => $"{LastMessageTime:hh:mm}";
}