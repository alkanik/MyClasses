﻿using MyList;

ArrayList list = new ArrayList();
list.Write();
list.AddLast(5);
list.Write();
list.AddLast(1);
list.Write();
list.AddLast(5);
list.Write();
list.AddLast(8);
list.Write();
list.AddFirst(7);
list.Write();
list.AddFirst(5);
list.Write();
list.AddLast(5);
list.Write();
list.AddByIndex(2, 1);
list.Write();
list.AddByIndex(2, 0);
list.Write();
list.AddByIndex(2, -1);
list.Write();
list.DeleteLast();
list.Write();
list.DeleteFirst();
list.Write();
list.DeleteByIndex(2);
list.Write();
//list.DeleteNLast(2);
//list.Write();
//list.DeleteNFirst(2);
//list.Write();
//list.DeleteNByIndex(2,2);
//list.Write();
//Console.WriteLine(list.FindIndexByValue(7));
list.ChangeValueByIndex(2,17) ;
list.Write();
list.Reverse();
list.Write();
//Console.WriteLine(list.FindMax());
//Console.WriteLine(list.FindMin());
//Console.WriteLine(list.FindIndexMax());
//Console.WriteLine(list.FindIndexMin());
//list.SortAscending();
//list.Write();
//list.SortDescending();
//list.Write();
//Console.WriteLine(list.DeleteFirstValue(-1));
Console.WriteLine(list.DeleteAllByValue(5));
list.Write();