using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Foundation;
using UIKit;

namespace KvoResearch
{
	public partial class ViewController : UIViewController
	{
		protected ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			bool useCuteOverload = true;

			if(useCuteOverload)
				View.AddObserver (v => v.Frame, NSKeyValueObservingOptions.New, FrameChanged);
			else
				View.AddObserver ("frame", NSKeyValueObservingOptions.New, FrameChanged);
		}

		void FrameChanged (NSObservedChange change)
		{
			Console.WriteLine (((NSValue)change.NewValue).CGRectValue);
		}
	}

	public static class SubscriberHelper
	{
		public static IDisposable AddObserver<T, TProperty> (this T subject, Expression<Func<T, TProperty>> expr, NSKeyValueObservingOptions options, Action<NSObservedChange> handler) where T : NSObject
		{
			var member = expr.Body as MemberExpression;
			if (member == null)
				throw new InvalidOperationException ($"Expression {expr} doesn't refer to property");

			var propInfo = member.Member as PropertyInfo;
			if (propInfo == null)
				throw new InvalidOperationException ($"Expression {expr} doesn't refer to property");

			var getter = propInfo.GetAccessors () [0];
			var export = getter.CustomAttributes
							   .First (a => a.AttributeType.Name == "ExportAttribute" && a.AttributeType.Namespace == "Foundation");

			var selector = (string)export.ConstructorArguments [0].Value;

			return subject.AddObserver (selector, options, handler);
		}
	}
}
