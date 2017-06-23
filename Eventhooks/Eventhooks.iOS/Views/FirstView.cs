using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using Eventhooks.Core.ViewModels;
using MvvmCross.iOS.Views.Presenters.Attributes;

namespace Eventhooks.iOS.Views
{
    [MvxFromStoryboard]
    public partial class FirstView : MvxViewController<FirstViewModel>
    {
        public FirstView(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            if (NavigationItem != null)
            {
                NavigationItem.Title = "First View";
            }

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
			set.Bind(Label).To(vm => vm.Hello);
			set.Bind(TextField).To(vm => vm.Hello);
			set.Bind(VCButton).To(vm => vm.ShowSecondView);
            set.Apply();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }

    }
}
