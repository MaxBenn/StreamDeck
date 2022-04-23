using System;
using StreamDeckLib;
using StreamDeckLib.Messages;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;

namespace Macro
{
    

    [ActionUuid(Uuid = "raketentier.macro.plugin.action.RunMacro")]
    public class JmMacroAction : BaseStreamDeckActionWithSettingsModel<Models.InputSettingsModel>
    {
        public InputSimulator InputSimulator { get; set; }
        private bool _isSpaming;

        public override Task OnKeyDown(StreamDeckEventPayload args)
        {
            _isSpaming = !_isSpaming;
            return base.OnKeyDown(args);
        }

        public override Task OnKeyUp(StreamDeckEventPayload args)
        {
            var isSpaming = Wait();
            while (true)
            {
                InputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_U);
            }
        }

        private async Task<bool> Wait()
        {
            await Task.Delay(10000);
            return true;
        }

        private Task DoStuff(VirtualKeyCode virtualKeyCode)
        {
            return Task.CompletedTask;
        }

        public override async Task OnDidReceiveSettings(StreamDeckEventPayload args)
        {
            await base.OnDidReceiveSettings(args);
            await Manager.SetTitleAsync(args.context, SettingsModel.Input);
        }

        public override async Task OnWillAppear(StreamDeckEventPayload args)
        {
            InputSimulator = new InputSimulator();
            _isSpaming = false;
            await base.OnWillAppear(args);
            await Manager.SetTitleAsync(args.context, SettingsModel.Input);
        }
    }
}