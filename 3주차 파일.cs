using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class NewBehaviourScript : MonoBehaviour
{ 

    private void Awake()
    {

        Hashtable hash = new Hashtable();

        Goblin goblin = new Goblin();
        Slime slime = new Slime();

        hash["Goblin"] = goblin;

        hash.Add("Slime", slime);
        hash.Add(1, "정수");
        hash.Add(1.2f, "실수");
        hash.Add("안녕하세요.접니다", "문자열");

        foreach(object key in hash.Keys)
        {
            Debug.Log($"hash[key]={hash[key]}");
        }

        if (hash.ContainsKey("Slime"))
        {
            Debug.Log($"Slime 키 존재");
        }

        if (hash.ContainsValue("Goblin"))
        {
            Debug.Log($"{goblin} 값 존재");
        }

        Debug.Log($"hashtable count: {hash.Count}");

        hash.Remove("Slime");

        Debug.Log($"hashtable count: {hash.Count}");

        hash.Clear();

        Debug.Log($"hashtable count: {hash.Count}");







        /*stack 실습
        Stack stack = new Stack();

        for(int i=0;i<5;++i)
        {
            stack.Push(i);
        }

        Debug.Log($"Stack Count: {stack.Count}");

        Debug.Log($"마지막에 추가된 요소: {stack.Peek()}");

        Debug.Log($"Stack Count: {stack.Count}");

        object data = stack.Pop();
        Debug.Log($"스택에서 빠져나온 데이터:{data}");


        Debug.Log($"Stack Count: {stack.Count}");

        stack.Clear();


        Debug.Log($"Stack Count: {stack.Count}");



        /* Queue 실습
        Queue queue = new Queue();

        for(int i=0;i<5;++i)
        {
            queue.Enqueue(i);
        }

        Debug.Log($"Queue Count :{queue.Count} ");

        Debug.Log($"현재 0번 요소: {queue.Peek()}");

        Debug.Log($"Queue Count :{queue.Count} ");

        object data = queue.Dequeue();
        Debug.Log($"큐에서 빠져나온 데이터 : {data}");
        Debug.Log($"Queue Count :{queue.Count} ");

        queue.Clear();

        Debug.Log($"Queue Count :{queue.Count} ");


        /* ArrayList 실습
        ArrayList arraylist = new ArrayList();

        Debug.log(arraylist.Add(10));
        PrintArrayList(arraylist);

        arraylist.Insert(1, 100);

        PrintArrayList(arraylist);

        ICollection<int> data = new ICollection<int>();
        data.Add(1);
        data.Add(3);
        data.Add(2);
        arraylist.AddRange(data);

        PrintArrayList(arraylist);

        arraylist.Sort();

        PrintArrayList(arraylist);


        arraylist.Remove(10);

        PrintArrayList(arraylist);

        arraylist.RemoveAt(0);

        PrintArrayList(arraylist);

        arraylist.RemoveRange(0, 2);

        PrintArrayList(arraylist);


        arraylist.Clear();

        Debug.Log(arraylist.Count);
    }

    public void PrintArrayList(ArrayList list)
    {
        Debug.Log("=======================================");

        for(int i=0;i<list.Count;++i)
        {
            Debug.Log($"list[{i}]= {list[i]}");
        }
    }




*/


}
}
public class Goblin { }


public class Slime { }