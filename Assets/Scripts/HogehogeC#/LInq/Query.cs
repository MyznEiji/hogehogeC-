using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Query : MonoBehaviour {

	// Use this for initialization
	void Start () {
		var sample = new[]
		{
            new { X = 0, Y = 10, Z = new[]{ 1, 2, 3} },
            new { X = 1, Y = 11, Z = new[]{ 4, 5, 6} },
            new { X = 2, Y = 12, Z = new[]{ 7, 8, 9} },
            new { X = 3, Y = 13, Z = new[]{ 0, 1, 2} },
            new { X = 4, Y = 14, Z = new[]{ 3, 4, 5} },
		};

		var sample1 = new[]
		{
            new { X = 0, W = 1 },
            new { X = 0, W = 2 },
            new { X = 1, W = 3 },
            new { X = 1, W = 4 },
		};

		// var select_test = 
		// from p in sample
		// select p.X;

		// foreach (var p in select_test) print(p);

		// var where_test = 
		// 	from p in sample
		// 	where p.X > 2
		// 	select p;

		// foreach(var p in where_test)print(p);

		// var group_test = 
		// 	from p in sample1
		// 	group p.W by p.X;
		
		// foreach(var p in group_test)
		// {
		// 	print("p : " + p.Key);
		// 	foreach(var q in p)print(q);
		// }

		// var into_test = 
		// 	from p in sample
		// 	select p.X into x
		// 	where x > 2
		// 	select x;

		// 	foreach(var p in into_test)
		// 	print(p);

		// var orderby_test = 
		// from p in sample
		// orderby p.X descending
		// select p;

		// foreach (var p in orderby_test) print(p);

		// var join_test = 
		// from p in sample
		// join q in sample1 on p.X equals q.X
		// select new {p.X,p.Y,q.W};

		// foreach(var p in join_test) print(p);

		
		var let_test =
			from p in sample
			let sumZ = p.Z.Sum()
			select new {p.X,sumZ};

		foreach(var p in let_test) print(p);
	}
}
