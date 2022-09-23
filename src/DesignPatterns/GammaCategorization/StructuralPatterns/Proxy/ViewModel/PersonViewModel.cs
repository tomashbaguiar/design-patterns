using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DesignPatterns.GammaCategorization.StructuralPatterns.Proxy.ViewModel;

public class PersonViewModel : INotifyPropertyChanged
{
    private readonly Person _person;

    public PersonViewModel(Person person)
    {
        _person = person;
    }

    public string FirstName
    {
        get => _person.FirstName;
        set
        {
            if (_person.FirstName == value) return;
            _person.FirstName = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(FullName));
        }
    }
    
    public string LastName
    {
        get => _person.LastName;
        set
        {
            if (_person.LastName == value) return;
            _person.LastName = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(FullName));
        }
    }

    public string FullName
    {
        get => $"{FirstName} {LastName}".Trim();
        set
        {
            if (value == null)
            {
                FirstName = LastName = null;
                return;
            }

            var items = value.Split();
            if (items.Length > 0)
                FirstName = items.First();
            if (items.Length > 1)
                LastName = items.Last();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}