using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using telegramBot.Models;


namespace telegramBot.Controllers
{
    public class MessageController : ApiController
    {
        //[Route(@"api/message/update")] //webhook uri part
        //public async Task<OkResult> Update([FromBody]Update update)
        //{
        //var commands = Bot.Commands;
        //var message = update.Message;
        //var client = await Bot.Get();

        //foreach (var command in commands)
        //{
        //    if (command.Contains(message.Text))
        //    {
        //        command.Execute(message, client);
        //        break;
        //    }
        //}
        //--------------------------------------------------
        public async Task<IHttpActionResult> Post(Update update)
        {
            var message = update.Message;

            if (message.Type == MessageType.TextMessage)
            {
                await Bot.client.SendTextMessageAsync(message.Chat.Id, GameLogic.GetAnswer());
                // Echo each Message
              // await Bot.client.SendTextMessageAsync(message.Chat.Id, message.Text);
            }
            

            return Ok();
        }

        //    return Ok();
        //}
    }
}
