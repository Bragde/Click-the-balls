using System;
using UnityEngine;
using Random = UnityEngine.Random;

public static class Utils
{
    #region ENUMS

    public enum Direction { Up, Down, Left, Right };

    #endregion

    #region METHODS

    public static Vector3 RandomForce(Direction direction = Direction.Up, float min = 9, float max = 15) => direction switch
    {
        Direction.Up => Vector3.up * Random.Range(min, max),
        Direction.Down => Vector3.down * Random.Range(min, max),
        Direction.Left => Vector3.left * Random.Range(min, max),
        Direction.Right => Vector3.right * Random.Range(min, max),
        _ => throw new ArgumentOutOfRangeException(nameof(direction), $"Not expected direction value: {direction}")
    };

    public static float RandomTorque(float min = -10, float max = 10)
    {
        return Random.Range(min, max);
    }

    public static Vector3 RandomSpawnPos(float xMin = -4, float xMax = 4, float yMin = -2, float yMax = -2, float zMin = 0, float zMax = 0)
    {
        return new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), Random.Range(zMin, zMax));
    }

    #endregion
}