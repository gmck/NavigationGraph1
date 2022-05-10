using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;

namespace com.companyname.NavigationGraph1.Fragments
{
    public class ToolsFragment : Fragment
    {
        public ToolsFragment() { }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            HasOptionsMenu = true;
            View view = inflater.Inflate(Resource.Layout.fragment_tools, container, false);
            TextView textView = view.FindViewById<TextView>(Resource.Id.text_tools);
            textView.Text = "This is Tools fragment";
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