using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V4.View;
using Android.Support.V7.App;

namespace FragmentPageAdapter
{
    [Activity(Label = "FragmentPageAdapter", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);


            ViewPager viewPager = (ViewPager) FindViewById(Resource.Id.view_pager);

            CustomAdapter adapter = new CustomAdapter(SupportFragmentManager);

            viewPager.Adapter = adapter;


        }
    }
}

