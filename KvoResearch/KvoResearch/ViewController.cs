using System;
using System.Collections.Generic;
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

			// The orthodox way to do KVO
			// View.AddObserver ("frame", NSKeyValueObservingOptions.New, FrameChanged);

			// A proposed way to do KVO
			// View.AddObserver (v => v.Frame, NSKeyValueObservingOptions.New, FrameChanged);

			// This will build keyPath "view.frame" for you
			this.AddObserver (vc => vc.View.Frame, NSKeyValueObservingOptions.New, FrameChanged);

			// This will not work as expected
			// View.AddObserver (v => v.Frame.Height, NSKeyValueObservingOptions.New, FrameChanged);
		}

		void FrameChanged (NSObservedChange change)
		{
			Console.WriteLine (((NSValue)change.NewValue).CGRectValue);
		}
	}

	public static class NSObjectExtensions
	{
		public static IDisposable AddObserver<T, TProperty> (this T subject, Expression<Func<T, TProperty>> lambdaExpression, NSKeyValueObservingOptions options, Action<NSObservedChange> handler) where T : NSObject
		{
			Expression expression = lambdaExpression.Body;
			MemberExpression memberExpression;
			if(!TryCastMemberExpression (expression, out memberExpression))
				throw new InvalidOperationException ($"Expression {expression} doesn't refer to property");

			var stack = new Stack<string> ();
			do {
				var propInfo = memberExpression.Member as PropertyInfo;
				if (propInfo == null)
					throw new InvalidOperationException ($"Expression {expression} doesn't refer to property");

				var getter = propInfo.GetAccessors () [0];
				var export = getter.CustomAttributes
								   .FirstOrDefault (a => a.AttributeType.Name == "ExportAttribute"
													&& a.AttributeType.Namespace == "Foundation");
				if (export == null)
					throw new InvalidOperationException ($"Property {propInfo.Name} is not KVO compliant");

				var selector = (string)export.ConstructorArguments [0].Value;
				stack.Push (selector);

				expression = memberExpression.Expression;
			} while (TryCastMemberExpression (expression, out memberExpression));

			var keyPath = string.Join (".", stack);
			return subject.AddObserver (keyPath, options, handler);
		}

		static bool TryCastMemberExpression (Expression expr, out MemberExpression memberExpression)
		{
			memberExpression = expr as MemberExpression;
			return memberExpression != null;
		}
	}
}
