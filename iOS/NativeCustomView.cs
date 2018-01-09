using UIKit;
using CoreGraphics;

namespace CustomView.Forms.iOS {
    public class NativeCustomView : UIView {
        public override void Draw(CGRect rect) {
            base.Draw(rect);

            using (CGContext g = UIGraphics.GetCurrentContext()) {
                // calc points
                float height = (float)rect.Height / 2;
                float centerX = (float)rect.Width / 2;
                CGPoint p1 = new CGPoint(centerX - height / 2, height / 2 + height);
                CGPoint p2 = new CGPoint(centerX, height / 2);
                CGPoint p3 = new CGPoint(centerX + height / 2, height / 2 + height);

                //set up drawing attributes
                g.SetLineWidth(10);
                UIColor.Blue.SetFill();
                UIColor.Red.SetStroke();

                //create geometry
                var path = new CGPath();

                path.AddLines(new CGPoint[]{
                    p1,
                    p2,
                    p3
                });

                path.CloseSubpath();

                //add geometry to graphics context and draw it
                g.AddPath(path);
                g.DrawPath(CGPathDrawingMode.FillStroke);
            }
        }
    }
}
