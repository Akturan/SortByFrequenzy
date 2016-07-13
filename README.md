# SortByFrequenzy

####Sort elements by frequency

```
using SortByFrequenzy;
```

```
List<int> liste = new List<int>() { 5, 4, 6, 9, 5, 4, 3, 2, 5, 6, 8 };
var result = Sort.byFrequenzy(liste, true);

foreach (var item in result)
{
	Console.WriteLine(item);
}
```

```
int[] adam = new int[] { 
	1,2,3,4,5,5,4,1,5,4,6,8,8,1,8,1,4
};

var k = Sort.byFrequenzy(adam, true);

foreach (var i in k)
{
	Console.WriteLine(i);
}
```

```
string[] names = new string[] {
	"Max",
	"Müller",
	"Ronaldo",
	"Peter",
	"Vadim",
	"Peter",
	"Max"
};

var sName = Sort.byFrequenzy(names, true);

foreach(var iName in sName)
{
	Console.WriteLine(iName);
}
```