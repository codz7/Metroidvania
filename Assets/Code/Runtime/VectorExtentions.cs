
using UnityEngine;

public static class VectorExtentions 
{
    public static Vector2 To2dXY(this Vector3 me)
    {
        return new Vector2(me.x, me.y);
    }
}
