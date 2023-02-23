namespace System.InputSystem
{
    public class PlayerInput :IInput
    {
        //TODO:プレイヤーに関する処理の追加
        public void Input(string keyName)
        {
            UnityEngine.Debug.Log(keyName);
        }
    }
}