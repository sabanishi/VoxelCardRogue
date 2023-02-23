using Entity;
using UnityEngine;

namespace System.InputSystem
{
    public class PlayerInput :IInput
    {
        private readonly Player _player;

        public PlayerInput()
        {
            _player= GameObject.FindWithTag("Player").GetComponent<Player>();
        }
        
        public void Input(string keyName)
        {
            if (_player == null) return;
            switch (keyName)
            {
                case "W":
                    _player.Move(Direction.Up);
                    break;
                case "A":
                    _player.Move(Direction.Left);
                    break;
                case "S":
                    _player.Move(Direction.Down);
                    break;
                case "D":
                    _player.Move(Direction.Right);
                    break;
                default:
                    Debug.Log("PlayerInputのInput()で想定外の引数が渡されました: "+keyName);
                    break;
            }
        }
    }
}