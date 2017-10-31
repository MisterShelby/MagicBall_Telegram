using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace telegramBot.Models
{
    static public class GameLogic
    {
        static private string[] answers = new string[]
        {// Positive
        "It is certain|Бесспорно",
        "It is decidedly so|Предрешено",
        " Without a doubt|Никаких сомнений",
        " Yes — definitely|Определённо да",
        "You may rely on it|Можешь быть уверен в этом",
        //Indecently positive
        " As I see it, yes |Мне кажется-да",
        " Most likely|Вереоятнее всего",
        " Outlook good|Хорошие перспективы",
        "Signs point to yes|Знаки говорят -да",
        "Yes| ДА",
        //Neutral
        "Reply hazy, try again|Пока не ясно,попробуй снова",
        "Ask again later |Спроси позже",
        "Better not tell you now |Лучше не рассказывать",
        "Cannot predict now|Сейчас  нельза предсказать",
        "Concentrate and ask again |Сконцентрируйся и спроси опять",
        //Negative
        "Don’t count on it|Даже не думай ",
        "My reply is no|Мой ответ - нет",
        "My sources say no| По моим данным - нет",
        " Outlook not so good|Перспективы не очень хорошие ",
        "Very doubtful |Весьма сомнительно"
        };
        static public string GetAnswer()
        {
            Random r = new Random();

            return answers[r.Next(0, answers.Length - 1)];


        }

    }
}