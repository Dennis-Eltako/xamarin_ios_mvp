using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Xamarin.Bindings.iosUI
{
	// @interface LightControl : UIView
	[BaseType(typeof(UIView), Name = "_TtC5iosUI12LightControl")]
	interface LightControl
	{
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor(CGRect frame);

		// -(void)setImageWithImage:(UIImage * _Nonnull)image;
		[Export("setImageWithImage:")]
		void SetImageWithImage(UIImage image);

		// -(void)setLabelTextWithText:(NSString * _Nonnull)text;
		[Export("setLabelTextWithText:")]
		void SetLabelTextWithText(string text);

		// -(void)setSwitchValueWithValue:(BOOL)value;
		[Export("setSwitchValueWithValue:")]
		void SetSwitchValueWithValue(bool value);
	}
}
