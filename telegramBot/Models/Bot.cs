using System.Threading.Tasks;
using Telegram.Bot;

namespace telegramBot.Models
{
    public static class Bot
    {
        //private 
        public static TelegramBotClient client;
        public static async Task<TelegramBotClient> Get()
        {
            if (client != null)
            {
                return client;
            }

            client = new TelegramBotClient(AppSettings.Key);
            var hook = string.Format(AppSettings.Url, "api/message/post");
            await client.SetWebhookAsync(hook);

            return client;
        }
    }

}
