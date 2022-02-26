using StreamDeckLib;
using StreamDeckLib.Messages;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace NukiControlCenter
{
    [ActionUuid(Uuid = "raketentier.nuki.plugin.action.OpenSmartLock")]
    public class OpenSmartLockAction : BaseStreamDeckActionWithSettingsModel<Models.NukiSettingsModel>
    {
        public override async Task OnKeyDown(StreamDeckEventPayload args)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.nuki.io/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {SettingsModel.ApiToken}");


            var allInputParams = new List<KeyValuePair<string, string>>();

            var requestParams = new FormUrlEncodedContent(allInputParams);
            await client.PostAsync($"smartlock/{SettingsModel.SmartLockId}/action/unlock", requestParams).ConfigureAwait(false);
        }

        public override async Task OnKeyUp(StreamDeckEventPayload args)
        {
            await Manager.ShowOkAsync(args.context);
            await Manager.SetStateAsync(args.context, 1);
        }

        public override async Task OnDidReceiveSettings(StreamDeckEventPayload args)
        {
            await base.OnDidReceiveSettings(args);
        }

        public override async Task OnWillAppear(StreamDeckEventPayload args)
        {
            await base.OnWillAppear(args);
        }

    }
}
