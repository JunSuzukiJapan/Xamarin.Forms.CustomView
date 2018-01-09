using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomView.Forms.CustomView), typeof(CustomView.Forms.iOS.NativeCustomRenderer))]
namespace CustomView.Forms.iOS {
    public class NativeCustomRenderer : ViewRenderer<CustomView, NativeCustomView> {
        NativeCustomView customView;

        protected override void OnElementChanged(ElementChangedEventArgs<CustomView> e) {
            base.OnElementChanged(e);

            if (Control == null) {
                customView = new NativeCustomView();
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
