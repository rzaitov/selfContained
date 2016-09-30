using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;

using UIKit;
using Foundation;
using ObjCRuntime;

namespace MMAPTest
{
	[Register ("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		[DllImport ("/usr/lib/libc.dylib", SetLastError = true)]
		static extern IntPtr mmap (IntPtr start, ulong length, int prot, int flags, int fd, long offset);

		[DllImport ("/usr/lib/libc.dylib", SetLastError = true)]
		static extern IntPtr munmap (IntPtr handler);

		const string LibC = "/usr/lib/libc.dylib";

		public override UIWindow Window { get; set; }

		unsafe public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			var path = NSBundle.MainBundle.PathForResource ("data", "txt");
			using (var mmf = MemoryMappedFile.CreateFromFile (path, FileMode.Open, null, 0, MemoryMappedFileAccess.Read)) {
				using(var view = mmf.CreateViewAccessor (0, 0, MemoryMappedFileAccess.Read)) {
					byte* ptr = null;
					view.SafeMemoryMappedViewHandle.AcquirePointer (ref ptr);
					for (int i = 0; i < 9; i++) {
						Console.WriteLine ((char)(*ptr));
						ptr++;
					}
				}
			}
			//var fs = new FileStream ("data.txt", FileMode.Open, FileAccess.Read);
			//var fd = fs.SafeFileHandle.DangerousGetHandle ();

			//var libc = Dlfcn.dlopen (Constants.FoundationLibrary, 0);
			//var PROT_READ = Dlfcn.GetInt32 (libc, "PROT_READ");
			//var MAP_FILE = Dlfcn.GetInt32 (libc, "PROT_READ");
			//var MAP_SHARED = Dlfcn.GetInt32 (libc, "PROT_READ");

			//var ptr = mmap (IntPtr.Zero, 6, PROT_READ, MAP_FILE | MAP_SHARED, fd.ToInt32 (), 0);
			//var pointer = (byte*)ptr;

			//for (int i = 0; i < 6; i++) {
			//	byte b = *pointer;
			//	Console.WriteLine ((char)b);
			//	pointer++;
			//}

			//var result = munmap (ptr);
			//Console.WriteLine (result);

			return true;
		}

	}
}

