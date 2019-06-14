using ViewNavigationAndHierarchy.ViewModel;
using ViewNavigationAndHierarchy.Commands;


namespace ViewNavigationAndHierarchy
{
    public class MainWindowViewModel :ViewModelBase
    {
        public MainWindowViewModel()
        {
            NavCommand = new MyICommand<string>(OnNav);
        }

        private ViewModelBase _CurrentViewModel;

        private CustomerListViewModel customerListViewModel = new CustomerListViewModel();

        private OrderViewModel orderViewModel = new OrderViewModel();

        
        public ViewModelBase CurrentViewModel
        {
            get { return _CurrentViewModel; }
            set { SetProperty(ref _CurrentViewModel, value); }
        }

        public MyICommand<string> NavCommand { get; private set; }

        private void OnNav(string destination)
        {

            switch (destination)
            {
                case "Orders":
                    CurrentViewModel = orderViewModel;
                    break;
                case "Customers":
                default:
                    CurrentViewModel = customerListViewModel;
                    break;
            }
        }

    }
}
