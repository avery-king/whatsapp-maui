using System.Collections.ObjectModel;
using WhatsAppMaui.Models;

namespace WhatsAppMaui.Pages;

public partial class ChatsPage : ContentPage
{
    public ChatsPage()
    {
        InitializeComponent();
        Chats = new ObservableCollection<ChatModel>(LoadChats());
        BindingContext = this;
    }

    public ObservableCollection<ChatModel> Chats { get; set; }

    private static List<ChatModel> LoadChats() =>
        [
            new ChatModel("avi.png", "Avery King", DateTime.Now.AddDays(-1), "Hello World", 1),
            new ChatModel("avi.png", "John Doe", DateTime.Now.AddDays(-3), "Hello World", 1),
            new ChatModel("avi.png", "Anna Hoffman", DateTime.Now.AddDays(-2), "Hello World", 0),
            new ChatModel("avi.png", "Walter Smith", DateTime.Now.AddDays(-5), "Hello World", 0),
            new ChatModel("avi.png", "Walter Smith", DateTime.Now.AddDays(-5), "Hello World", 0),
            new ChatModel("avi.png", "Walter Smith", DateTime.Now.AddDays(-5), "Hello World", 0),
            new ChatModel("avi.png", "Walter Smith", DateTime.Now.AddDays(-5), "Hello World", 0),
            new ChatModel("avi.png", "Walter Smith", DateTime.Now.AddDays(-5), "Hello World", 0),
            new ChatModel("avi.png", "Walter Smith", DateTime.Now.AddDays(-5), "Hello World", 0),
            new ChatModel("avi.png", "Walter Smith", DateTime.Now.AddDays(-5), "Hello World", 0),
            new ChatModel("avi.png", "Wolfgang Heisenberg", DateTime.Now.AddDays(-10), "Hello World", 14),
            new ChatModel("avi.png", "Madison Jones", DateTime.Now.AddDays(-20), "Hello World", 2)
        ];
}