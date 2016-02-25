using Foundation;
using System;
using UIKit;

namespace DistanceConverted
{
    public partial class ViewController : UIViewController, IUIPickerViewDataSource
    {
        private static string[] englishUnits = { "inches", "feet", "yards", "miles" };

        public ViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            pckOldUnits.Delegate = new PickerViewDelegate();
            pckOldUnits.DataSource = this;
            pckNewUnits.Delegate = new PickerViewDelegate();
            pckNewUnits.DataSource = this;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        //From IUIPickerViewDataSource
        public nint GetComponentCount(UIPickerView pickerView)
        {
            return 1;
        }

        public nint GetRowsInComponent(UIPickerView pickerView, nint component)
        {
            return englishUnits.Length;
        }

        //Nested class - derived from IUIPickerViewDelegate
        class PickerViewDelegate : UIPickerViewDelegate
        {
            public override string GetTitle(UIPickerView pView, nint row, nint component)
            {
                //Gets names from array to display in picker bar
                return englishUnits[row];
            }
        }

        partial void BtnConvert_TouchUpInside(UIButton sender)
        {
            string oldUnits = "";
            string newUnits = "";
            double distance = 0.0;
            //get user input from pickers
            int row = (int)pckOldUnits.SelectedRowInComponent(0);
            oldUnits = englishUnits[row];
            row = (int)pckNewUnits.SelectedRowInComponent(0);
            newUnits = englishUnits[row];
            //get user input from text box
            double.TryParse(txtDistance.Text, out distance);
            //do conversion
            ConvertDistance convert = new ConvertDistance();
            string[] result = convert.Convert(distance, oldUnits, newUnits);
            //ConvertTabBarController ctbc = (ConvertTabBarController)this.TabBarController;
            //ctbc.Result = result;
			((AppDelegate)UIApplication.SharedApplication.Delegate).Result = result;
            lblOldUnits.Text = oldUnits.ToString() + " " + distance;
            lblNewUnits.Text = result[0];
        }
        public override void TouchesBegan(NSSet touches, UIEvent evt)
        {
            View.EndEditing(true);
        }
    }
}