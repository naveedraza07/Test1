using System;
using System.Collections.Generic;

class Utilities
{
	public static Dictionary<String, Int32> freqCnt(List<String> data)
	{
		Dictionary<String, Int32> result = new Dictionary<String, Int32>();
		for (Int32 i = 0; i < data.Count; i++)
		{
			if (result.ContainsKey(data[i]))
			{
				Int32 value = 0;
				result.TryGetValue(data[i], out value);
				result.Remove(data[i]); // -- otherwise an exception on the next line?!?
				result.Add(data[i], value + 1);
			}
			else
				result.Add(data[i], 1);
		}
		return result;
	}
}
