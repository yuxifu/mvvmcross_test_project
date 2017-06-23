using Android.App;
using Android.OS;
using Android.Widget;

namespace Eventhooks.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : BaseView
    {
		private int count = 1;

        protected override int LayoutResource => Resource.Layout.FirstView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SupportActionBar.SetDisplayHomeAsUpEnabled(false);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.myButton);

            //both worked
			//button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
            button.Click += (sender, e) =>
            {
                button.Text = string.Format("{0} clicks!", count++);
            };
        }
    }
}
