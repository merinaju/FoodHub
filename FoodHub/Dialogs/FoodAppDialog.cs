using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using System.Threading.Tasks;

namespace FoodHub.Dialogs
{
    [LuisModel("819d5c89-d3fa-41a6-9d8b-cc996e593bef", "b7de1eda300f4e99913d9eac7748d430")]
    [Serializable]
    public class FoodAppDialog : LuisDialog<object>
    {
        [LuisIntent("")]
        [LuisIntent("None")]
        public async Task None(IDialogContext context, LuisResult luisResult)
        {
            string message = "Sorry, I talk only food. Try again";
            await context.PostAsync(message);
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("less spicy medium hot")]
        public async Task lessspicymediumhot(IDialogContext context, LuisResult luisResult)
        {
            string message = "Do you want it to be medium spicy or hot";
            await context.PostAsync(message);
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("type of cuisine you like")]
        public async Task typeofcuisineyoulike(IDialogContext context, LuisResult luisResult)
        {
            string message = "what type of cuisine you like";
            await context.PostAsync(message);
            context.Wait(this.MessageReceived);
        }



    }
}