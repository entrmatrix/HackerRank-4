
using System;
using System.Collections.Generic;
using System.IO;
class Solution {

	static void Main(String[] args) {

		var results = new int [61];
		results [0] = 1;
		for (int i = 1; i <= 60; i++) {
			results [i] = i % 2 == 0 ? results [i - 1] + 1 : results [i - 1] * 2;
		}

		int t = Convert.ToInt32(Console.ReadLine());

		for (int i = 0; i < t; i++) {

			var cycle = Convert.ToInt32 (Console.ReadLine ());



			Console.WriteLine (results[cycle]);

		}
	}
}      

