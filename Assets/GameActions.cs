
public class GameActions
{
    static GameState gameState;
    
    private GameActions()
    {

    }

    static GameActions()
    {
        gameState = GameState.Use;
    }
    public static int Increment()
    {
        return ++gameState.Count.Value;
    }
    public static int Decrement()
    {
        return --gameState.Count.Value;
        
    }
    public static int IncrementByAmount(int number)
    {
        return gameState.Count.Value+=number;
    }
}