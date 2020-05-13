using System;
using AppKit;
using Foundation;

namespace any
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }


        partial void hellowpressed(NSObject sender)
        {

            Console.WriteLine("hello pressed");
            labelinfo.StringValue = "hello was pressed ";
            //throw new NotImplementedException();
        }







    }
}
