using Android.App;
using Android.Widget;
using Android.OS;

namespace Spinner_Key_Value
{
    [Activity(Label = "Spinner_Key_Value", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Spinner spinner0;
        TextView textView0;
        string[] text0 = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        int[] val1 = { 0, 1, 2, 3, 4, 5, 6 };
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            textView0 = FindViewById<TextView>(Resource.Id.text0);
            spinner0 = FindViewById<Spinner>(Resource.Id.spinner0);

            var adapter0 = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, text0);
            spinner0.Adapter = adapter0;
            spinner0.ItemSelected += Spinner0_ItemSelected; ;

        }
        private void Spinner0_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            string s1 = val1[e.Position].ToString();
            textView0.Text = s1;
        }
    }
}