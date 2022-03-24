using MyList;

MyArrayList list = new MyArrayList();
Console.WriteLine(list);
MyArrayList list2 = new MyArrayList(new int[] { 1, 2, 3 });
Console.WriteLine(list2);
MyArrayList list3 = new MyArrayList(5);
Console.WriteLine(list3);

Console.WriteLine(list3.Equals(list2));
