using MyList;

ArrayList list = new ArrayList();
Console.WriteLine(list);
ArrayList list2 = new ArrayList(new int[] { 1, 2, 3 });
Console.WriteLine(list2);
ArrayList list3 = new ArrayList(5);
Console.WriteLine(list3);

Console.WriteLine(list3.Equals(list2));
