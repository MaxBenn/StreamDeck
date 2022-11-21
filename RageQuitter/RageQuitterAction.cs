using StreamDeckLib;
using StreamDeckLib.Messages;
using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using RageQuitter.models;

namespace RageQuitter
{
    [ActionUuid(Uuid = "de.frittenmittitten.plugin.action.RageQuit")]
    public class RageQuitterAction : BaseStreamDeckActionWithSettingsModel<SettingsModel>
    {
        public override Task OnKeyUp(StreamDeckEventPayload args)
        {
            foreach (var process in Process.GetProcesses())
            {
                try
                {
                    var hasFileName = process.MainModule != null
                                      && process.MainModule.FileName != null;

                    if (!hasFileName) continue;

                    var isWallpaperEngine = process.MainModule.FileName.Contains("wallpaper");
                    var isGame = process.MainModule.FileName.Contains("steamapps") && !isWallpaperEngine;

                    var fileInfo = new FileInfo(process.MainModule.FileName);
                    foreach (var directoryInfo in fileInfo.Directory.GetDirectories())
                    {
                        var tempDirectoryInfo = directoryInfo;
                        while (tempDirectoryInfo.Name != directoryInfo.Root.Name)
                        {
                            if (Regex.IsMatch(tempDirectoryInfo.Name, "\\.egstore"))
                            {
                                isGame = true;
                                break;
                            }
                            tempDirectoryInfo = tempDirectoryInfo.Parent;
                        }

                        if (isGame)
                            process.Kill();
                    }
                }
                catch (Exception)
                {
                    // ignored
                }
            }

            return Task.CompletedTask;
        }
    }
}