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
    string choice;

    die dice1 - new die();
    die dice2 - new die();
    die dice3 - new die();
    die dice4 - new die();
    die dice5 - new die();

    public void  SevensOut()
    {
        while true
        {
            valued1 = dice1.roll;
            valued2 = dice2.roll;
            total = valued1 + valued2;
            if (total = 7)
            {
                rtotal1 = +total;
                break
            }
            elif(valued1 == valued2)
            {
                total = total*2;
            }
            rtotal1 = +total;
        }
        return rtotal1
    }
}