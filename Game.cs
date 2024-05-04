internal class Game
{
    int d1;
    int d2;
    int d3;
    int d4;
    int d5;
    int total;
    int rtotal1;
    int rtotal2;
    bool playing = True


    Die dice1 - new Die();
    Die dice2 - new die();
    Die dice3 - new Die();
    Die dice4 - new Die();
    Die dice5 - new Die();

    public void  SevensOut()
    {
        while playing = true
        {
            valued1 = dice1.dice_roll;
            valued2 = dice2.dice_roll;
            total = valued1 + valued2;
            if (total = 7)
            {
                rtotal1 = rtotal1+total;
                break
            }
            elif(valued1 == valued2)
            {
                total = total*2;
            }
            rtotal1 = rtotal1+total;
        }
        return rtotal1
    }
}