namespace eShopOnContainers.Services;

public class DialogService : IDialogService
{
    public Task ShowAlertAsync(string message, string title, string buttonLabel)
    {
        var page = Application.Current?.Windows.Count > 0 ? Application.Current.Windows[0].Page : null;

        return page?.DisplayAlertAsync(title, message, buttonLabel) ?? Task.CompletedTask;
    }
}