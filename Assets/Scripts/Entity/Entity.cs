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

        //getter、setter
        public int Hp => _hp;

        public Vector2Int Pos => _pos;

        public virtual void Initialize(Vector2Int pos)
        {
            _hp = MaxHp;
            _pos = pos;
        }

        public void Move(Direction direction)
        {
            //TODO:引数および中身の追加
            Debug.Log(direction);
        }

        public void OnDamage(int damageNum)
        {
            //TODO:仮実装
            _hp -= damageNum;
        }
    }
}