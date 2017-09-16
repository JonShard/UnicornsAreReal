using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Helpfunctions
{
    public static float getAngle(Vector2 v1, Vector2 v2)                                        //Retuns the angle between two points.
    {
        float angle = 0;

        float deltaX = v1.x - v2.x;
        float deltaY = v2.y - v1.y;     //revesed Y

        angle = Mathf.Atan2(deltaX, deltaY);
        angle = toDegrees(angle);

        return angle;
    }


    static float toRadians(float degrees)
    {
        return degrees * (3.14f / 180);
    }


    static float toDegrees(float radians)
    {
        return radians * (180 / 3.14f);
    }

}
