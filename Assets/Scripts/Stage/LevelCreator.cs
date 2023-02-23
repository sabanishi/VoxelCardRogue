namespace Stage
{
    public class LevelCreator
    {
        public int[,] FloorArray { get; private set; }
        public int[,] ObjArray { get; private set; }
        public  LevelCreator(int levelNum)
        {
            CreateFloor(levelNum);
            CreateObj(levelNum);
        }
        
        //床を作成する
        private void CreateFloor(int levelNum)
        {
            //TODO: 仮実装
            FloorArray = new int[30, 30];
        }
        
        //オブジェクトを作成する
        private void CreateObj(int levelNum)
        {
            //TODO:仮実装
            ObjArray = new int[30, 30];
        }
    }
}