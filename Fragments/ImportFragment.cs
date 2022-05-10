using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;

namespace com.companyname.NavigationGraph1.Fragments
{
    public  class ImportFragment : Fragment
    {
        public ImportFragment() { }  // important parameterless ctor

        //public override void OnCreate(Bundle savedInstanceState)
        //{
        //    base.OnCreate(savedInstanceState);
        //}

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            HasOptionsMenu = true;
            View view = inflater.Inflate(Resource.Layout.fragment_import, container, false);
            TextView textView = view.FindViewById<TextView>(Resource.Id.text_import);
            textView.Text = "This is Import fragment";
            return view;
        }
    }
}