using Android.Views;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;

namespace CustomView.Forms.Droid {
    public class NativeCustomView : View {
        private readonly ShapeDrawable _shape;

        public NativeCustomView(Context context) : base(context) {
            var paint = new Paint();
            paint.SetARGB(255, 200, 255, 0);
            paint.SetStyle(Paint.Style.Stroke);
            paint.StrokeWidth = 4;

            _shape = new ShapeDrawable(new OvalShape());
            _shape.Paint.Set(paint);
        }

        protected override void OnDraw(Android.Graphics.Canvas canvas) {
            base.OnDraw(canvas);

            int width = canvas.Width / 2;
            int left = (canvas.Width - width) / 2;
            int top = (canvas.Height - width) / 2;
            _shape.SetBounds(left, top, left + width, top + width);
            _shape.Draw(canvas);
        }
    }
}
