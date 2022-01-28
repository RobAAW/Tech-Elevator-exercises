namespace Exercises.Classes
{
    public class Elevator
    {

        public int CurrentLevel { get; private set; }
        public int NumberOfLevels { get; private set; }
        public bool DoorIsOpen { get; private set; }

        public Elevator (int numberOfLevels)
        {
            NumberOfLevels = numberOfLevels;
            DoorIsOpen = false;
            CurrentLevel = 1;
        }

        

        public void OpenDoor()
        {
            if (!DoorIsOpen)
            {
                DoorIsOpen = true;
            }
        }

        public void CloseDoor()
        {
            if (DoorIsOpen)
            {
                DoorIsOpen = false;
            }
        }

        public void GoUp(int desiredFloor)
        {
            if (DoorIsOpen)
            {
                DoorIsOpen = false;
            } 
            else if (desiredFloor > CurrentLevel && desiredFloor <= NumberOfLevels)
            {
                CurrentLevel = desiredFloor;
            }
        }

        public void GoDown(int desiredFloor)
        {
            if (DoorIsOpen)
            {
                DoorIsOpen = false;
            }
            else if (desiredFloor < CurrentLevel && desiredFloor >= 1)
            {
                CurrentLevel = desiredFloor;
            }
        }


        
        


    }
}
