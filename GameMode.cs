using System.Collections.Generic;

namespace GameModeMgr 
{
	public interface IGameMode
	{			
		void Setup(ModeManager mgr, IGameInstance gameInst);
		void Start( object param = null);
		void Loop(float frameSecs);
		void Pause();
		void Resume(string prevModeName, object prevModeResult);
		object End();    
        bool HandleCmd(object cmd);
		string ModeName();
	};


	public abstract class BaseGameMode : IGameMode
	{	
		protected Dictionary<string,dynamic> _cmdDispatch;  	
		public ModeManager manager; 
		public IGameInstance gameInst;
			
		public void Setup(ModeManager mgr, IGameInstance gInst = null)
		{
			// Called by manager before Start()
			// Not virtual
			// TODO: this should be the engine and not the modeMgr - but what IS an engine...
 			_cmdDispatch = new Dictionary<string, dynamic>();
			manager = mgr;
			gameInst = gInst;

		}

		public virtual void Start( object param = null)	{}

		public virtual void Loop(float frameSecs) {}

		public virtual void Pause() {}
		public virtual void Resume(string prevModeName, object prevModeResult) {}	
		public virtual object End() { return null;}     

        public virtual bool HandleCmd(object cmd)
        {
            return _cmdDispatch[cmd.GetType().Name](cmd);        
        }	
        public virtual string ModeName() => this.GetType().Name;		   	
	};
}

