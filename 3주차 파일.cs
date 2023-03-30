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
        hash.Add(1, "����");
        hash.Add(1.2f, "�Ǽ�");
        hash.Add("�ȳ��ϼ���.���ϴ�", "���ڿ�");

        foreach(object key in hash.Keys)
        {
            Debug.Log($"hash[key]={hash[key]}");
        }

        if (hash.ContainsKey("Slime"))
        {
            Debug.Log($"Slime Ű ����");
        }

        if (hash.ContainsValue("Goblin"))
        {
            Debug.Log($"{goblin} �� ����");
        }

        Debug.Log($"hashtable count: {hash.Count}");

        hash.Remove("Slime");

        Debug.Log($"hashtable count: {hash.Count}");

        hash.Clear();

        Debug.Log($"hashtable count: {hash.Count}");







        /*stack �ǽ�
        Stack stack = new Stack();

        for(int i=0;i<5;++i)
        {
            stack.Push(i);
        }

        Debug.Log($"Stack Count: {stack.Count}");

        Debug.Log($"�������� �߰��� ���: {stack.Peek()}");

        Debug.Log($"Stack Count: {stack.Count}");

        object data = stack.Pop();
        Debug.Log($"���ÿ��� �������� ������:{data}");


        Debug.Log($"Stack Count: {stack.Count}");

        stack.Clear();


        Debug.Log($"Stack Count: {stack.Count}");



        /* Queue �ǽ�
        Queue queue = new Queue();

        for(int i=0;i<5;++i)
        {
            queue.Enqueue(i);
        }

        Debug.Log($"Queue Count :{queue.Count} ");

        Debug.Log($"���� 0�� ���: {queue.Peek()}");

        Debug.Log($"Queue Count :{queue.Count} ");

        object data = queue.Dequeue();
        Debug.Log($"ť���� �������� ������ : {data}");
        Debug.Log($"Queue Count :{queue.Count} ");

        queue.Clear();

        Debug.Log($"Queue Count :{queue.Count} ");


        /* ArrayList �ǽ�
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