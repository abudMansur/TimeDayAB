using Oxide.Core.Plugins;
using Oxide.Game.Rust.Cui;

namespace Oxide.Plugins
{
    [Info("TimedayAB", "AbudMansur", "1.0.0")]
    [Description("Sunucuda her zaman sabah olmasını sağlar.")]
    public class TimedayAB : RustPlugin
    {
        private float dayTime = 12f; // 12.0 saat = öğle (sabah için 8.0 yapabilirsin)

        void OnServerInitialized()
        {
            timer.Every(60f, () =>
            {
                TOD_Sky.Instance.Cycle.Hour = dayTime;
            });
        }
    }
}
