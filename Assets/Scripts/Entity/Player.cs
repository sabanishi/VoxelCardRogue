using System.Transactions;
using UnityEngine;

namespace Entity
{
    public class Player:Entity
    {
        public override void Initialize(Vector2Int pos)
        {   
            base.Initialize(pos);
            MaxHp = 30;
        }
    }
}