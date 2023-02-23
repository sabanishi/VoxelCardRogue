using System;
using UnityEngine;

namespace Entity
{
    public abstract class Entity:MonoBehaviour
    {
        //フィールド
        private int _hp;
        protected int MaxHp;
        private Vector2Int _pos;
        private Transform _transform;

        //getter、setter
        public int Hp => _hp;

        public Vector2Int Pos => _pos;

        public virtual void Initialize(Vector2Int pos)
        {
            _hp = MaxHp;
            _pos = pos;
            _transform = transform;
            UpdatePosition();
        }

        //前後左右に1マス移動する
        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Down:
                    _pos = _pos + new Vector2Int(0, -1);
                    break;
                case Direction.Left:
                    _pos = _pos + new Vector2Int(-1, 0);
                    break;
                case Direction.Right:
                    _pos = _pos + new Vector2Int(1, 0);
                    break;
                case Direction.Up:
                    _pos = _pos + new Vector2Int(0, 1);
                    break;
            }
            //transform.positionの更新
            UpdatePosition();
        }
        
        //transform.positionを更新する
        private void UpdatePosition()
        {
            _transform.position = new Vector3(_pos.x, 0, _pos.y);
        }

        public void OnDamage(int damageNum)
        {
            //TODO:仮実装
            _hp -= damageNum;
        }
    }
}