// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using UnityEngine;


namespace Utilities
{
	public class MathUtils
	{
		public static Vector3 LatLong2Vector3(float lat, float lon)
		{
			double cosLat = Math.Cos(lat * Math.PI / 180.0);
			double sinLat = Math.Sin(lat * Math.PI / 180.0);
			double cosLon = Math.Cos(lon * Math.PI / 180.0);
			double sinLon = Math.Sin(lon * Math.PI / 180.0);
			double rad = 1f;
			double f = 1.0 / 298.257224;
			double C = 1.0 / Math.Sqrt(cosLat * cosLat + (1 - f) * (1 - f) * sinLat * sinLat);
			double S = (1.0 - f) * (1.0 - f) * C;
			double h = 0.0;
			float x = (float)((rad * C + h) * cosLat * cosLon);
			float y = (float)((rad * C + h) * cosLat * sinLon);
			float z = (float)((rad * S + h) * sinLat);

			return new Vector3(x, y, z);
		}

	}
}

