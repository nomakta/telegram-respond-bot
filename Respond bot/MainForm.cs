using System;
using System.Windows.Forms;
using System.Diagnostics;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using System.Net;

namespace Respond_bot
{

    public partial class MainForm : Form
    {
        private static readonly TelegramBotClient Bot = new TelegramBotClient("API KEY HERE");
        private readonly string APIkey = "API KEY HERE";

        public MainForm()
        {
            InitializeComponent();
            Bot.OnMessage += BotOnMessageReceived;
            Bot.OnMessageEdited += BotOnMessageReceived;
            Bot.OnReceiveError += BotOnReceiveError;

            var me = Bot.GetMeAsync().Result;
            Bot.StartReceiving();
        }

        private static void BotOnReceiveError(object sender, ReceiveErrorEventArgs receiveErrorEventArgs)
        {
            Debugger.Break();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            var me = Bot.GetMeAsync().Result;

            BotUsernameLBL.Text = me.Username;
            BotIDlbl.Text = me.Id.ToString();
            BotNameLBL.Text = me.FirstName + me.LastName; 
                     
            ChatlogRTB.AppendText("Bot loaded!");
        }


        public async void SpamUser(int amount, long UserID, string Message)
        {
            int test2 = 0;
            while (amount > test2)
            {
                test2++;
                await Bot.SendTextMessageAsync(UserID, Message);
                if (test2 == amount)
                {
                    Invoke(new Action(() => ChatlogRTB.AppendText("Done Spamming user " + UserID + " Amount of times spammed " + test2 + "\n")));

                }
                System.Threading.Thread.Sleep(1000); // i cba making a propper function tbh

            }  
        }

        private async void BotOnMessageReceived(object sender, MessageEventArgs messageEventArgs)
        {
            var message = messageEventArgs.Message;

            if (message.Type == MessageType.TextMessage)
            {
             Invoke(new Action(() => ChatlogRTB.AppendText("[" + "CHAT ID:" + message.Chat.Id + "]" + message.Chat.FirstName + ":" + message.Text.ToString() + "\n")));
            }

             if (message == null || message.Type != MessageType.TextMessage) return;

            if (message.Text.StartsWith("/help"))
            {
                var usage = @"=========================
            /help 
            /spam.(times).(userid).(message)
            /phonetrace (nummber)
            
    ==========================";

                await Bot.SendTextMessageAsync(message.Chat.Id, usage, replyMarkup: new ReplyKeyboardHide());
            }

            else if (message.Text.StartsWith("/spam"))
            {
                try
                {
                    string test = message.Text.ToString();
                    string[] Splitted = test.Split('.');

                    int Amount = Int32.Parse(Splitted[1]);
                    long ID = Int64.Parse(Splitted[2]);
                    string Message = Splitted[3];

                    SpamUser(Amount, ID, Message);
                }
                catch(Exception e)
                {
                    await Bot.SendTextMessageAsync(message.Chat.Id, "Usage /spam.(times).(userid).(message)");
                }
             }


            else if (message.Text.StartsWith("/phonetrace"))
            {
                string test = message.Text.ToString();
                string[] Splitted = test.Split(' ');

                try
                {

                    WebClient phonelookup = new WebClient();                  
                    string resolve = phonelookup.DownloadString(@"http://webresolver.nl/api.php?key=" + APIkey + "&action=phonenumbercheck&string=" + Splitted[1]);

                    if(resolve.StartsWith("Use the international formatting")) // just some cheap way to translate our API 
                    {
                        await Bot.SendTextMessageAsync(message.Chat.Id, "Use international phone formatting ");

                    }
                     else if (resolve.StartsWith("Number is invalid")) // just some cheap way to translate our API
                    {
                        await Bot.SendTextMessageAsync(message.Chat.Id, " is it that hard to fill in a good number");
                    }
                    else
                    {
                        await Bot.SendTextMessageAsync(message.Chat.Id, resolve);
                    }
                }

                catch (Exception e)
                {
                    Invoke(new Action(() => ChatlogRTB.AppendText("[DEBUG] User ID:" + message.Chat.Id + " Tried to use a command without a input\n[DEBUG] " + e.Message + "\n")));
                }
            }
        }
    }
}
