using Android.App;
using Android.OS;
using PokemonSnap.Droid.Fragments;

namespace PokemonSnap.Droid.Activities
{
    [Activity(Label = "PokemonSnap.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class CameraActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            ActionBar.Hide();
            SetContentView(Resource.Layout.activity_camera);

            if (bundle == null)
            {
                FragmentManager.BeginTransaction().Replace(Resource.Id.container, CameraFragment.NewInstance()).Commit();
            }
        }
    }
}

