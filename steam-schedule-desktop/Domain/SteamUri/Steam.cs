using System.Diagnostics;


namespace steam_schedule_desktop.Domain.SteamUri
{
    internal class Steam
    {
        private readonly dynamic _steam;

        public Steam()
        {
            _steam = new UriComponent(null, "steam");
        }

        public void SetStatusOnline()
        {
            Process.Start(new ProcessStartInfo(_steam.Friends.Status.Online.GetUri()) { UseShellExecute = true });
        }

        public void SetStatusInvisible()
        {
            Process.Start(new ProcessStartInfo(_steam.Friends.Status.Invisible.GetUri()) { UseShellExecute = true });
        }
    }
}
