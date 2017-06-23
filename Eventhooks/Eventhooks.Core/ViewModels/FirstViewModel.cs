using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;

namespace Eventhooks.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
        string hello = "Hello MvvmCross";
        public string Hello
        {
            get { return hello; }
            set { SetProperty(ref hello, value); }
        }

        private string MyName
        {
            get
            {
                return this.GetType().Name;
            }
        }

        public override void Appearing()
        {
            //base.Appearing();
            MvxTrace.Trace(MvxTraceLevel.Diagnostic, MyName + " is appearing");
        }

		public override void Appeared()
		{
			MvxTrace.Trace(MvxTraceLevel.Diagnostic, MyName + " appeared");
		}

		public override void Disappearing()
		{
			MvxTrace.Trace(MvxTraceLevel.Diagnostic, MyName + " is disappearing");
		}

		public override void Disappeared()
		{
			MvxTrace.Trace(MvxTraceLevel.Diagnostic, MyName + " has disappeared");
		}

		public IMvxCommand ShowSecondView
		{
            get { return new MvxCommand(ExecuteSecondViewCommand); }
		}

		private void ExecuteSecondViewCommand()
		{
			ShowViewModel<SecondViewModel>();
		}

    }
}
