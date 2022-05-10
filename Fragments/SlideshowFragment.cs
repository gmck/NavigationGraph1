using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;

namespace com.companyname.NavigationGraph1.Fragments
{
    public class SlideshowFragment : Fragment
    {
        public SlideshowFragment() { }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            HasOptionsMenu = true;
            View view = inflater.Inflate(Resource.Layout.fragment_slideshow, container, false);
            TextView textView = view.FindViewById<TextView>(Resource.Id.text_slideshow);
            textView.Text = "This is Slideshow fragment";
            return view;
        }

        public override void OnCreateOptionsMenu(IMenu menu, MenuInflater inflater)
        {
            // Don't want a menu
            base.OnCreateOptionsMenu(menu, inflater);
            menu.Clear();
        }


    }
}