using Foundation;
using System;
using UIKit;
using Xamarin.Bindings.iosUI;
using xamarin_business_logic;


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
            image = UIImage.FromBundle(BusinessLogic.getImage(toggle));
            lightControl = new LightControl(View.Frame);
            lightControl.SetLabelTextWithText(BusinessLogic.getRoom());
            lightControl.SetImageWithImage(image);
            lightControl.SetSwitchValueWithValue(toggle);
            View.AddSubview(lightControl);

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

    }
}