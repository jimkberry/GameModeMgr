namespace GameModeMgr
{
    // ReSharper disable UnusedType.Global,ClassNeverInstantiated.Global
    public interface IGameInstance
    {
        // ReSharper disable UnusedMember.Global
        void Start(int initialMode);
        bool Loop(float frameSecs);
        void End();
    }

    public class GameInstanceData
    {

    }

}