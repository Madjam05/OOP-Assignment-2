internal class Testing
   {
        Game Test = new Game();
        Die TestDie = new Die();
        public void TestRolls()
        {
            for (int i = 0; i < 500; i++)
            {
                int testvalue = TestDie.dice_roll();

                Debug.Assert(testvalue < 7 && testvalue > 0);

                int testsum = TestDie.dice_roll();            

                Debug.Assert(testsum < 19 && testsum > 2);      
            
            }
        }
   }