class Die 
{
    static Random rand = new Random();

    public int dice_roll()
    {
        int value= rand.Next(1, 7);
        return value;
    }
}