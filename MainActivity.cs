using Android.App;
using Android.OS;
using Android.Views;
using AndroidX.AppCompat.App;
using AndroidX.AppCompat.Widget;
using AndroidX.DrawerLayout.Widget;
using AndroidX.Navigation;
using AndroidX.Navigation.Fragment;
using AndroidX.Navigation.UI;
using Google.Android.Material.Navigation;

namespace com.companyname.NavigationGraph1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, NavController.IOnDestinationChangedListener
    {
        private AppBarConfiguration appBarConfiguration;
        private NavController navController;

        #region OnCreate
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            // navigationView for NavigationUI and drawerLayout for the AppBarConfiguration and NavigationUI
            NavigationView navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
            DrawerLayout drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);

            // The new stuff
            // NavHostFragment so we can get a NavController
            NavHostFragment navHostFragment = SupportFragmentManager.FindFragmentById(Resource.Id.nav_host) as NavHostFragment;
            navController = navHostFragment.NavController;

            // Top Level Destinations - for the NavigationView and AppBarConfiguration
            int[] topLevelDestinationIds = new int[] { Resource.Id.import_fragment, Resource.Id.gallery_fragment, Resource.Id.slideshow_fragment, Resource.Id.tools_fragment };
            appBarConfiguration = new AppBarConfiguration.Builder(topLevelDestinationIds).SetOpenableLayout(drawerLayout).Build();

            NavigationUI.SetupActionBarWithNavController(this, navController, appBarConfiguration);
            NavigationUI.SetupWithNavController(navigationView, navController);

            // Add the DestinationChanged listener
            navController.AddOnDestinationChangedListener(this);
        }
        #endregion

        #region OnSupportNavigationUp
        public override bool OnSupportNavigateUp()
        {
            return NavigationUI.NavigateUp(navController, appBarConfiguration) || base.OnSupportNavigateUp();
        }
        #endregion

        #region OnDestinationChanged
        public void OnDestinationChanged(NavController navController, NavDestination navDestination, Bundle bundle)
        {
            // Nothing as yet - but will be used in NavigationGraph2.
        }
        #endregion

        #region OnCreateOptionsMenu
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            base.OnCreateOptionsMenu(menu);
            MenuInflater.Inflate(Resource.Menu.menu, menu);
            return true;
        }
        #endregion

        #region OnOptionsItemSelected
        public override bool OnOptionsItemSelected(IMenuItem menuItem)
        {
            switch (menuItem.ItemId)
            {
                case Resource.Id.action_settings:
                    // Nothing yet..
                    break;
            }
            return NavigationUI.OnNavDestinationSelected(menuItem, Navigation.FindNavController(this, Resource.Id.nav_host)) || base.OnOptionsItemSelected(menuItem);
        }
        #endregion

    }
}

