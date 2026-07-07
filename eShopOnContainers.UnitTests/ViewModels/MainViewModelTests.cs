namespace eShopOnContainers.UnitTests;

public class MainViewModelTests
{
    private readonly INavigationService _navigationService;

    public MainViewModelTests()
    {
        _navigationService = new MockNavigationService();
    }

    [Fact]
    public void MainViewModelIsInstantiatedTest()
    {
        var mainViewModel = new MainViewModel(_navigationService);
        Assert.NotNull(mainViewModel);
    }

    [Fact]
    public void IsBusyPropertyIsFalseWhenViewModelInstantiatedTest()
    {
        var mainViewModel = new MainViewModel(_navigationService);
        Assert.False(mainViewModel.IsBusy);
    }
}
