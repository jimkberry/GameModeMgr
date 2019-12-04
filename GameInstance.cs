namespace GameModeMgr
{
    public interface IGameInstance
    {
        void Start(int initialMode);
        bool Loop(float frameSecs);
    }

    public class GameInstanceData
    {

    }

}