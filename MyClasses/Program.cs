﻿using MyList;

ArrayList list = new ArrayList();
list.Write();
list.AddLast(5);
list.Write();
list.AddLast(5);
list.Write();
list.AddLast(5);
list.Write();
list.AddLast(5);
list.Write();
list.AddFirst(3);
list.Write();
list.AddFirst(2);
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
list.DeleteNByIndex(2,2);
list.Write();