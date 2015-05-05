using System;

namespace RenameInterfaceMember
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		}
	}

	public interface ISimple
	{
		void SimpleMehod ();			// Rename me!!
		bool SimpleProp { get; }		// Rename me!!
	}

	public class SimpleImpl : ISimple
	{
		public void SimpleMehod ()		// I will not change
		{
			throw new NotImplementedException ();
		}

		public bool SimpleProp {		// I will not change my name
			get {
				throw new NotImplementedException ();
			}
		}
	}
}
