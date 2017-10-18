using System;
using CoreGraphics;
using UIKit;
using Foundation;
using BigTed;
using ZXing.Mobile;
using MessageUI;

namespace WineHangoutz
{
	public class AboutController1 : UIViewController
	{
		private string screen = "About Controller";
		UINavigationController NavCtrl;
		UIScrollView scrollView;
		MFMailComposeViewController mailController;
		public AboutController1(UINavigationController navCtrl) : base("AboutController", null)
		{
			NavCtrl = navCtrl;
		}
		public override void ViewDidLoad()
		{
			try
			{
				base.ViewDidLoad();
				//LoggingClass.UploadLogs();
				CGSize sTemp = new CGSize(UIScreen.MainScreen.Bounds.Width, 100);
				LoggingClass.LogInfo("Entered into About View ", screen);
				nfloat ScreenHeight = UIScreen.MainScreen.Bounds.Height;
				nfloat Screenwidth = UIScreen.MainScreen.Bounds.Width-10;
				nfloat bckimgheight = (ScreenHeight - 100) / 3;
				bckimgheight = bckimgheight + 30;
				UIImageView backgroud = new UIImageView();
				backgroud.Frame = new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, bckimgheight);
				backgroud.Image = new UIImage("Images/aboutus.jpg");
				nfloat y = bckimgheight;
				UILabel T1 = new UILabel();
				T1.Frame = new CGRect(0, y+10, UIScreen.MainScreen.Bounds.Width - 20, 10);
				T1.Font = UIFont.FromName("HelveticaNeue-Bold", 35f);
				T1.Text = "Wine Outlet";
				T1.TextColor = UIColor.Purple;
				T1.TextAlignment = UITextAlignment.Center;
				sTemp = T1.SizeThatFits(sTemp);
				T1.Frame = new CGRect(0, y+10, Screenwidth, sTemp.Height);


				y = y + T1.Frame.Height+20;
				//Console.WriteLine(y);

				UILabel H1 = new UILabel();
				H1.Frame = new CGRect(5, y , Screenwidth, 10);
				H1.Text="Uncork the Merriment";
				H1.TextAlignment=UITextAlignment.Left;
				H1.TextColor = UIColor.Black;
				H1.Font = UIFont.FromName("Verdana-Bold", 20f);
				sTemp = H1.SizeThatFits(sTemp);
				H1.Frame = new CGRect(5, y, Screenwidth, sTemp.Height);

				y = y + sTemp.Height+10;
				//Console.WriteLine(y);

				//UITextView Heading1 = new UITextView();
				//Heading1.Frame = new CGRect(5, y+10, UIScreen.MainScreen.Bounds.Width - 20, UIScreen.MainScreen.Bounds.Height);
				//Heading1.Text = "Uncork the Merriment";
				//Heading1.TextAlignment = UITextAlignment.Left;
				////Heading1.TextAlignment = UITextAlignment.Justified;
				//Heading1.TextColor = UIColor.Black;
				//Heading1.Font = UIFont.FromName("Verdana-Bold", 20f);
				//Heading1.Editable = false;

				UITextView p1 = new UITextView();
				p1.Frame = new CGRect(5, y, Screenwidth, UIScreen.MainScreen.Bounds.Height);
				p1.Text = "“Wine is inspiring and adds greatly to the joy of living”-Napoleon Bonaparte.\n\n The Wine Outlet app was developed to deliver the complete wine experience of internationally acclaimed wines while easing the pressure in choosing an exceptional wine. Wine Outlet has partnered with the world’s number 1 wine dispensing and preservation system Enomatic, a self-serve system that provides customers with a try before you buy experience.";
				p1.TextColor = UIColor.Black;
				p1.TextAlignment = UITextAlignment.Justified;
				p1.Font = UIFont.FromName("Verdana", 13f);
				p1.Editable = false;
				sTemp = p1.SizeThatFits(sTemp);
				p1.Frame = new CGRect(5, y, UIScreen.MainScreen.Bounds.Width - 20, sTemp.Height);
				y = y + sTemp.Height-40;

				UITextView Heading2 = new UITextView();
				Heading2.Frame = new CGRect(5, y, UIScreen.MainScreen.Bounds.Width - 20, 10);
				Heading2.Text = "WHO WE ARE";
				Heading2.TextColor = UIColor.Black;
				Heading2.TextAlignment = UITextAlignment.Justified;
				Heading2.Font = UIFont.FromName("Verdana-Bold", 20f);
				Heading2.Editable = false;
				sTemp = Heading2.SizeThatFits(sTemp);
				Heading2.Frame = new CGRect(5, y, UIScreen.MainScreen.Bounds.Width - 20, sTemp.Height);
				y = y + sTemp.Height;

				UITextView p2 = new UITextView();
				p2.Frame = new CGRect(5, y, UIScreen.MainScreen.Bounds.Width - 20, 10);
				p2.Text = "With the wide variety of assorted wines to sample from, Wine Outlet presents the perfect backdrop connecting wine lovers with the opportunity to try new wines before they buy. Our enticing VIP program allows customers an exclusive opportunity to sample for FREE from personally selected wines. Stocked with one of the" +
					" largest selections throughout New Jersey, each Wine Outlet will " +
					"be the perfect spot for both the novice and connoisseur.";
				p2.TextColor = UIColor.Black;
				p2.TextAlignment = UITextAlignment.Justified;
				p2.Font = UIFont.FromName("Verdana", 13f);
				p2.Editable = false;
				sTemp = p2.SizeThatFits(sTemp);
				p2.Frame = new CGRect(5, y, UIScreen.MainScreen.Bounds.Width - 20, sTemp.Height);

				y = y + sTemp.Height-180;
				UITextView Heading3 = new UITextView();
				Heading3.Frame = new CGRect(5, y, UIScreen.MainScreen.Bounds.Width - 20, UIScreen.MainScreen.Bounds.Height);
				Heading3.Text = "WHAT WE OFFER";
				Heading3.TextAlignment = UITextAlignment.Justified;
				Heading3.TextColor = UIColor.Black;
				Heading3.Font = UIFont.FromName("Verdana-Bold", 20f);
				Heading3.Editable = false;
				Heading3.TextAlignment = UITextAlignment.Left;
				sTemp = Heading3.SizeThatFits(sTemp);
				Heading3.Frame = new CGRect(5, y, UIScreen.MainScreen.Bounds.Width - 20, sTemp.Height);

				y = y + sTemp.Height-30;
				UITextView p3 = new UITextView();
				p3.Frame = new CGRect(5, y, UIScreen.MainScreen.Bounds.Width - 20, UIScreen.MainScreen.Bounds.Height);
				p3.Text = "We offer an experience of enjoyment. Upon the authentication, our exciting mobile application, Wine Outlet, takes our privileged customers to the virtual vineyard of savors and flavors, through the following options:  \n\nPick the Choice: Guest users also can see all the available wines for tasting.\n\n My Tasting: See the list of wines you have tasted. \n\n My Reviews: View your ratings and reviews and let other wine lovers explore it along with you.\n\n My Favorites: Pick your favorites and we send you customized notifications when there are any discounts or available for wine tasting.\n\n My Profile: Protect your credentials and update it as and when you wish.";
				p3.TextColor = UIColor.Black;
				p3.TextAlignment = UITextAlignment.Justified;
				p3.Font = UIFont.FromName("Verdana", 13f);
				p3.Editable = false;
				sTemp = p3.SizeThatFits(sTemp);
				p3.Frame = new CGRect(5, y, UIScreen.MainScreen.Bounds.Width - 20, sTemp.Height);

				y = y + sTemp.Height-450;
				UITextView p4 = new UITextView();
				p4.Frame = new CGRect(5, y, UIScreen.MainScreen.Bounds.Width - 20, UIScreen.MainScreen.Bounds.Height);
				p4.Text = "RATE AND REVIEW";
				p4.TextColor = UIColor.Black;
				p4.TextAlignment = UITextAlignment.Justified;
				p4.Font = UIFont.FromName("Verdana-Bold", 20f);
				p4.Editable = false;
				p4.TextAlignment = UITextAlignment.Left;
				sTemp = p4.SizeThatFits(sTemp);
				p4.Frame = new CGRect(5, y, UIScreen.MainScreen.Bounds.Width - 20, sTemp.Height);

				y = y + sTemp.Height-20;
				UITextView p5 = new UITextView();
				p5.Frame = new CGRect(5, y, UIScreen.MainScreen.Bounds.Width - 20, UIScreen.MainScreen.Bounds.Height);
				p5.Text = "Please provide rating and review for your favorite wine. Wine Outlet app displays the average rating and the individual rating of the users.";
				p5.TextColor = UIColor.Black;
				p5.TextAlignment = UITextAlignment.Justified;
				p5.Font = UIFont.FromName("Verdana", 13f);
				p5.Editable = false;
				sTemp = p5.SizeThatFits(sTemp);
				p5.Frame = new CGRect(5, y, UIScreen.MainScreen.Bounds.Width - 20, sTemp.Height);

				//y = y + sTemp.Height-10;
				//UITextView p6 = new UITextView();
				//p6.Frame = new CGRect(5, y, UIScreen.MainScreen.Bounds.Width - 20, UIScreen.MainScreen.Bounds.Height);
				//p6.Text = "Rate and Review is the spot for rating your favorite wine and Wine outlet displays the average rating and the individual rating of the users.";
				//p5.TextColor = UIColor.Black;
				//p6.Font = UIFont.FromName("Verdana", 13f);
				//p6.Editable = false;
				//p6.TextAlignment = UITextAlignment.Justified;
				//sTemp = p6.SizeThatFits(sTemp);
				//p6.Frame = new CGRect(5, y, UIScreen.MainScreen.Bounds.Width - 20, sTemp.Height);

				y = y + sTemp.Height-100;
				UITextView VersionText = new UITextView();
				VersionText.Frame = new CGRect(5, y, UIScreen.MainScreen.Bounds.Width - 20, UIScreen.MainScreen.Bounds.Height);
				var ver = NSBundle.MainBundle.InfoDictionary["CFBundleVersion"];
				//MonoTouch.Constants.Version;
				//Console.WriteLine(ver);
				VersionText.Text = "Version 1.4("+ver+").\nAll rights reserved.";
				VersionText.TextColor = UIColor.Black;
				VersionText.Font = UIFont.FromName("Verdana", 18f);
				VersionText.Editable = false;
				VersionText.TextAlignment = UITextAlignment.Center;
				sTemp = VersionText.SizeThatFits(sTemp);
				VersionText.Frame = new CGRect(5, y, UIScreen.MainScreen.Bounds.Width - 20, sTemp.Height);

				y = y + sTemp.Height;
				UITextView ContactUsText = new UITextView();
				ContactUsText.Frame = new CGRect(5, y-50, UIScreen.MainScreen.Bounds.Width - 20, UIScreen.MainScreen.Bounds.Height);
				ContactUsText.Text = "Click here to contact us";
				ContactUsText.TextColor = UIColor.Purple;
				ContactUsText.Font = UIFont.FromName("Verdana", 18f);
				ContactUsText.Editable = false;
				ContactUsText.TextAlignment = UITextAlignment.Center;

				if (MFMailComposeViewController.CanSendMail)
				{
					ContactUsText.UserInteractionEnabled = true;
				}
				else
				{
					ContactUsText.UserInteractionEnabled = false;
				}

				//ContactUsText.ShouldInteractWithUrl += ContactUsText_ShouldInteractWithUrl;
				var tap = new UITapGestureRecognizer { CancelsTouchesInView = false };
				tap.AddTarget(() =>
				{
					mailController = new MFMailComposeViewController();
					mailController.SetToRecipients (new string[]{"sales@wineoutlet.com"});
					mailController.SetSubject ("Feedback "+ver);
					mailController.SetMessageBody("User info "+CurrentUser.RetreiveUserId().ToString(),true);
                    this.PresentViewController (mailController, true, null);
					mailController.Finished += ( object s, MFComposeResultEventArgs args) =>
					{
						args.Controller.DismissViewController (true, null);
					};
				});
				//ContactUsText.UserInteractionEnabled = true;
				ContactUsText.AddGestureRecognizer(tap);

				nfloat h = 0;

				scrollView = new UIScrollView
				{
					Frame = new CGRect(0, 20, View.Frame.Width, View.Frame.Height),
					ContentSize = new CGSize(View.Frame.Width, View.Frame.Height),
					BackgroundColor = UIColor.White,
					AutoresizingMask = UIViewAutoresizing.FlexibleHeight
				};


				scrollView.AddSubview(backgroud);
				//scrollView.AddSubview(Title1);
				scrollView.AddSubview(T1);
				scrollView.AddSubview(H1);
				//scrollView.AddSubview(Heading1);
				scrollView.AddSubview(p1);
				scrollView.AddSubview(Heading2);
				scrollView.AddSubview(p2);
				scrollView.AddSubview(Heading3);
				scrollView.AddSubview(p3);
				scrollView.AddSubview(p4);
				scrollView.AddSubview(p5);
				//scrollView.AddSubview(p6);
				scrollView.AddSubview(VersionText);
				scrollView.AddSubview(ContactUsText);

				//for (int i = 0; i < scrollView.Subviews.Length; i++)
				//{
				//	h = scrollView.Subviews[i].Frame.Size.Height + 370 + ScreenHeight;
				//}
				scrollView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, y+30);
				View = (scrollView);
			}
			catch (Exception ex)
			{
				LoggingClass.LogError(ex.ToString(), screen, ex.StackTrace);
				//Console.WriteLine(ex.Message);
			}
		}
}
}
