using ReactiveUI;

namespace TeamsUI.ViewModels;

public class ActivitiesViewModel : ReactiveUI.ReactiveObject
{

    private bool _isNavVisible = true;

    public bool IsNavVisible
    {
        get => _isNavVisible;
        set => this.RaiseAndSetIfChanged(ref _isNavVisible, value);
    }

    
    public void HandleVisibility()
    {
        IsNavVisible = !IsNavVisible;
    }
}