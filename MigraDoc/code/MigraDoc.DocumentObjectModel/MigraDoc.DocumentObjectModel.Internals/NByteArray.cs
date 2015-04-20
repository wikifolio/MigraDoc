using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.DocumentObjectModel.Internals
{
	class NByteArray : INullableValue
	{
		public NByteArray(byte[] val)
		{
		  this.val = val;
		}

		public byte[] Value
		{
			get { return this.val; }
			set { this.val = value; }
		}

		object INullableValue.GetValue()
		{
			return Value;
		}

		void INullableValue.SetValue(object value)
		{
			this.val = (byte[])value;
		}

		public void SetNull()
		{
			this.val = null;
		}

		public bool IsNull
		{
			get { return this.val == null; }
		}
		
		public static readonly NByteArray NullValue = new NByteArray(null);

		byte[] val;
	}
}
