using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Content;

[assembly: ExportRenderer(typeof(CustomView.Forms.CustomView), typeof(CustomView.Forms.Droid.NativeCustomRenderer))]
namespace CustomView.Forms.Droid {
    public class NativeCustomRenderer : ViewRenderer<CustomView, NativeCustomView> {
        NativeCustomView customView; // この例では必要ないが、あとで必要になったときのため。

        public NativeCustomRenderer(Context context) : base(context) {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<CustomView> e) {
            base.OnElementChanged(e);

            if (Control == null) {
                customView = new NativeCustomView(Context);
                SetNativeControl(customView);
            }
            if (e.OldElement != null) {
                // Unsubscribe
                // 何かイベントをSubscribeしているときには、必ずここでUnsubscribeしておく。
            }
            if (e.NewElement != null) {
                // Subscribe
                // 何かイベントをSubscribeしたいときには、ここでSubscribeする。
            }
        }
    }
}
