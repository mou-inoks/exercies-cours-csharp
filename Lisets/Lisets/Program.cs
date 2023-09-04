var list = new List<int>() { 1, 526, 12, 5, 346};

int t = 0;

//foreach(var elem in list)
//{
//    if (elem % 2 == 1)
//        t += (elem*elem);
//}

//Console.WriteLine(t);

Console.Write(list.Where(x => x % 2 == 1).Select(x => x* x).Sum());