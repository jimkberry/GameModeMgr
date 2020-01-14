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
		string ModeName();
	};

}

