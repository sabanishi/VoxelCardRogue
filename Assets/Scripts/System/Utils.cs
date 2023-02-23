using UnityEngine;

namespace System
{
    public class Utils
    {
        private Utils(){}

        public static Vector2Int CalcVector2(Direction direction)
        {
            switch (direction)
            {
                case Direction.Down:
                    return Vector2Int.down;
                case Direction.Left:
                    return Vector2Int.left;
                case Direction.Right:
                    return Vector2Int.right;
                case Direction.Up:
                    return Vector2Int.up;
                default:
                    Debug.LogError("UtilsのCalcVector2で想定外の引数が渡されました: "+direction);
                    return Vector2Int.zero;
            }
        }
    }
}