
using System;
using System.Collections.Generic;
using System.IO;
class Solution {

	static void Main(String[] args) {
		int t = Convert.ToInt32(Console.ReadLine());

		for (int i = 0; i < t; i++) {


			Console.WriteLine(~((Convert.ToUInt32(Console.ReadLine()))));
		}
	}
}      

