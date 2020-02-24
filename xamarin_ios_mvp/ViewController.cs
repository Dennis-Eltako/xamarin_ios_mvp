using Foundation;
using System;
using UIKit;
using Xamarin.Bindings.iosUI;


namespace xamarin_ios_mvp
{
    public partial class ViewController : UIViewController
    {

        LightControl lightControl;
        UIImage image;
        bool toggle = true;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            image = UIImage.FromBundle(getImage());
            lightControl = new LightControl(View.Frame);
            lightControl.SetLabelTextWithText("Living Room");
            lightControl.SetImageWithImage(image);
            lightControl.SetSwitchValueWithValue(toggle);
            View.AddSubview(lightControl);

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        String getImage()
        {
            if (toggle)
            {
                return "lightOn.png";
            }
            else
            {
                return "lightOff.png";
            }
        }

    }
}