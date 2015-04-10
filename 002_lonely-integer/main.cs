using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

	static void Main(String[] args) {


		Convert.ToInt32(Console.ReadLine());

		var elements = new HashSet<string> ();
		String move = Console.ReadLine();
		String[] move_split = move.Split(' ');
		for(int i = 0; i < move_split.Length; i++) {
			var element = move_split [i].Trim();
			if (!elements.Add(element)) {
				elements.Remove (element);
			}

		}
		Console.WriteLine(elements.First());

	}
}

