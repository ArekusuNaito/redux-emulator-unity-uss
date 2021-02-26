using UniRx;

[System.Serializable]
public class GameState 
{
    #region Static Region for Context
        
    
    public static GameState Use
    {
        get{return self;}
    }
    
    private static GameState self;
    static  GameState()
    {
        self = new GameState();
        
    }
    private GameState()
    {

    }

    #endregion

    ReactiveProperty<int> count = new ReactiveProperty<int>(0);

    public ReactiveProperty<int> Count
    {
        get{return count;}
    }
}

