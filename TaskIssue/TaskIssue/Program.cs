using System;
using System.Threading.Tasks;
using System.Threading;
using System.Text;

using System.Runtime.InteropServices;

namespace TaskIssue
{
	class MainClass
	{
		[DllImport ("libc")]
		private static extern int getpid ();

		[DllImport ("libclang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "clang_createIndex")]
		public static extern IntPtr createIndex (int excludeDeclarationsFromPCH, int displayDiagnostics);


		public static void Main (string[] args)
		{
			Console.WriteLine (createIndex (1, 1));
			Console.WriteLine (getpid());

			Task.Factory.StartNew (() => {
				Console.WriteLine ("Hello world");
			});

			Thread.Sleep (1000);
		}
	}
}
