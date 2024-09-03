//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Describes a typed variable value
	/// </summary>
	public class GlobalVariableValue {

		/// <summary>
		/// Type of a variable
		/// </summary>
		public GlobalVariableTypes Type { get; }

		/// <summary>
		/// Value of the variable
		/// </summary>
		public object Value { get; }

		/// <summary>
		/// Returns a string that describes the variable, regardless of its type
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns an array of GlobalVariableValue if Type is List. Else, null is returned
		/// </summary>
		public GlobalVariableValue[] ToList()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns a Pose if Type is Pose. Else, null is returned
		/// </summary>
		public Pose ToPose()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns variable value if type is Bool. Il type is Float or Int, it returns True if value is not 0. Else, it returns false
		/// </summary>
		public bool ToBool()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns variable value if type is Int. Il type is Float, it tries to cast it to int. If Type is bool, it returns 1 or 0. Else it returns 0
		/// </summary>
		public int ToInt()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns variable value if type is Float. Il type is int, it casts it to float. If Type is bool, it returns 1 or 0. Else it returns NaN
		/// </summary>
		public float ToFloat()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Return variable value GlobalVariable[,] if variable is a matrix. First dimension is row index and second dimension is column index.
		/// Use GetLength(0) to get row number and GetLength(1) to get column count
		/// </summary>
		public Array ToMatrix()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Estimate variable value from its string representation
		/// </summary>
		public static GlobalVariableValue Parse(string message)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
