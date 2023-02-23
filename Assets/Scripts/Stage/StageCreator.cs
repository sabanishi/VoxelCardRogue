using UnityEngine;

namespace Stage
{
    public class StageCreator:MonoBehaviour
    {
        [SerializeField] private GameObject floorPrefab;
        public void Start()
        {
            //TODO: 仮実装
            Initialize(0);
        }

        private void Initialize(int levelNum)
        {
            CreateStage(levelNum);
        }

        //ステージを作る
        private void CreateStage(int levelNum)
        {
            LevelCreator levelCreator = new LevelCreator(levelNum);
            //ステージの内容を表すint二次元配列の取得
            int[,] floorArray = levelCreator.FloorArray;
            int[,] objArray = levelCreator.ObjArray;

            for (int x = 0; x < floorArray.GetLength(0); x++)
            {
                for (int y = 0; y < floorArray.GetLength(1); y++)
                {
                    PutFloor(x,y,floorArray[x,y]);
                    PutObject(x,y,objArray[x,y]);
                }
            }
        }
        
        //指定した位置に床を生成する
        private void PutFloor(int x, int y, int floorNum)
        {
            GameObject obj=null;
            switch (floorNum)
            {
                case 0:
                    //通常の床
                    obj = Instantiate(floorPrefab, gameObject.transform);
                    obj.transform.localPosition = new Vector3(x, 0, y);
                    break;
                default:
                    Debug.LogError("PutFloorで設定外の数字が呼ばれました: "+floorNum);
                    break;
            }
        }
        
        //指定した位置にオブジェクトを生成する
        private void PutObject(int x, int y, int objNum)
        {
            switch (objNum)
            {
                case 0:
                    break;
                default:
                    Debug.LogError("PutObjectで設定外の数字が呼ばれました: "+objNum);
                    break;
            }
        }
    }
}