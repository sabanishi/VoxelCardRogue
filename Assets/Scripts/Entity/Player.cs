using System;
using System.Transactions;
using UnityEngine;

namespace Entity
{
    public class Player:Entity
    {
        //TODO: 仮実装
        private void Start()
        {
            Initialize(new Vector2Int(3,0));
        }

        public override void Initialize(Vector2Int pos)
        {   
            base.Initialize(pos);
            MaxHp = 30;
        }
    }
}