using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ParentClass : MonoBehaviour
{
    [System.Serializable]
    public class ListWrapper
    {
        public string childName;
        public Color color;
    }

    public List<ListWrapper> childs = new List<ListWrapper>();

    private List<ChildClass> childClasses = new List<ChildClass>();

    void Start()
    {
        for (int i = 0; i < childs.Count; i++)
        {
            GameObject go = new GameObject();
            ChildClass child = go.AddComponent<ChildClass>();

            // Properties can be used just like variables
            child.Color = childs[i].color;

            childClasses.Add(child);
        }
    }

    void Update()
    {
        ColorUpdater();
    }

    //if something changes it gets updated
    void ColorUpdater() {
        for (int i = 0; i < childs.Count; i++)
        {
            if (childs[i].color != childClasses[i].Color)
            {
                childClasses[i].Color = childs[i].color;
            }
        }
    }
}