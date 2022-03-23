using DSharpPlus;

namespace Labs;

public static class Program
{
    /// <summary>
    /// Point D'entrer : D
    /// </summary>
    public static void Main()
    {
        MainAsync().GetAwaiter().GetResult(); // eheh boy 😊
        
    }

    public static async Task MainAsync()
    {
        
        var discord = new DiscordClient(new DiscordConfiguration()
        {
            Token = "Bien Tenter mais le token est pas ici ahah !",
            TokenType = TokenType.Bot,
            Intents = DiscordIntents.AllUnprivileged     
        });
        
        await discord.ConnectAsync();
        await Task.Delay(-1);
    }
}