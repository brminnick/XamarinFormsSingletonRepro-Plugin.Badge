using Xamarin.Forms;

using Android.Content;

using XamarinFormsSingletonRepro;
using XamarinFormsSingletonRepro.Droid;

using Plugin.Badge.Droid;

[assembly: ExportRenderer(typeof(SingletonTabbedPage), typeof(SingletonTabbedPageRenderer))]
namespace XamarinFormsSingletonRepro.Droid
{
    public class SingletonTabbedPageRenderer : BadgedTabbedPageRenderer
    {
        public SingletonTabbedPageRenderer(Context context) : base(context)
        {
        }
    }
}
