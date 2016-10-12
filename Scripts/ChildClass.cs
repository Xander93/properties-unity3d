using UnityEngine;
using System.Collections;

public class ChildClass : MonoBehaviour
{
    //Member variables can be referred to as
    //fields.
	[SerializeField]
    private Color _color;

    //Color is a basic property
    public Color Color
    {
        get
        {
            //Some other code
            return _color;
        }
        set
        {
            //Some other code
            _color = value;
        }
    }
}