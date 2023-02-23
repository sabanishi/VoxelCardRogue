using UnityEngine;

namespace Entity
{
    public abstract class Entity:MonoBehaviour
    {
        //フィールド
        private int _hp;
        protected int _maxHp;
        
        //getter、setter
        public int Hp => _hp;

        protected void Initialize()
        {
            _hp = _maxHp;
        }

        public void Move()
        {
            //TODO:引数および中身の追加
        }

        public void OnDamage(int damageNum)
        {
            //TODO:仮実装
            _hp -= damageNum;
        }
    }
}