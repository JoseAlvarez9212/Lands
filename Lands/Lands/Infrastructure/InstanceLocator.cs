namespace Lands.Infrastructure
{
    using Lands.ViewModels;

    public class InstanceLocator
    {
        #region Properties
        public MainViewModel Main { get; set; }
        #endregion

        #region Constructure
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
