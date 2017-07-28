using System;
using CoreGraphics;
using UIKit;

namespace TipCalculator
{
    public class MyViewController : UIViewController
    {
        public MyViewController()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.Yellow;
            UITextField TotalAmount = CreateTotalAmountEntryField();
            UIButton calcButton = CreateCalculateButton();
            UILabel resultLabel = CreateResultLabel();

            View.AddSubviews(TotalAmount, calcButton, resultLabel);
        }

        private UILabel CreateResultLabel()
        {
            UILabel resultLabel = new UILabel();
            resultLabel.Frame = new CGRect(20, 124, View.Bounds.Width - 40, 40);
            resultLabel.TextColor = UIColor.Blue;
            resultLabel.TextAlignment = UITextAlignment.Center;
            resultLabel.Font = UIFont.SystemFontOfSize(24);
            resultLabel.Text = "Tip is $0.00";
            return resultLabel;
        }

        private UIButton CreateCalculateButton()
        {
            UIButton calcButton = new UIButton(UIButtonType.Custom);
            calcButton.Frame = new CGRect(20, 71, View.Bounds.Width - 40, 45);
            calcButton.SetTitle("Calculate", UIControlState.Normal);
            calcButton.BackgroundColor = UIColor.FromRGB(0f, 0.5f, 0f);
            return calcButton;
        }

        private UITextField CreateTotalAmountEntryField()
        {
            UITextField TotalAmount = new UITextField();
            TotalAmount.Frame = new CGRect(20, 28, View.Bounds.Width - 40, 35);
            TotalAmount.KeyboardType = UIKeyboardType.DecimalPad;
            TotalAmount.BorderStyle = UITextBorderStyle.RoundedRect;
            TotalAmount.Placeholder = "Enter Total Amount";
            return TotalAmount;
        }
    }
}
