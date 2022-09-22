using System.Text;

namespace DesignPatterns.GammaCategorization.CreationalPatterns.Factory.FactoryObjTrackAndBulkRep;

public class TrackingThemeFactory
{
    private readonly List<WeakReference<ITheme>> _themes = new();

    public ITheme CreateLightTheme()
    {
        var theme = new LightTheme();
        _themes.Add(new WeakReference<ITheme>(theme));
        return theme;
    }
    
    public ITheme CreateDarkTheme(bool dark)
    {
        var theme = new DarkTheme();
        _themes.Add(new WeakReference<ITheme>(theme));
        return theme;
    }

    public string Info
    {
        get
        {
            var sb = new StringBuilder();
            foreach (var reference in _themes)
            {
                if (!reference.TryGetTarget(out var theme)) continue;
                var dark = theme is DarkTheme;
                sb.Append(dark ? "Dark" : "Light")
                    .AppendLine(" theme");
            }

            return sb.ToString();
        }
    }
}