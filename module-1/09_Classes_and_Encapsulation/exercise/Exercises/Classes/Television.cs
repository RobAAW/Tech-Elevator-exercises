namespace Exercises.Classes
{
    public class Television
    {

        public bool IsOn { get; private set; }
        public int CurrentChannel { get; private set; }
        public int CurrentVolume { get; private set; }

        public Television()
        {
            IsOn = false;
            CurrentChannel = 3;
            CurrentVolume = 2;
        }

        public void TurnOff()
        {
            if (IsOn)
            {
                IsOn = false;
            }
        }

        public void TurnOn()
        {
            if (!IsOn)
            {
                IsOn = true;
            }
        }

        public void ChangeChannel (int newChannel)
        {
            if (!IsOn)
            {
                IsOn = true;
            }

            else if (newChannel >= 3 && newChannel <= 18)
            {
                CurrentChannel = newChannel;
            }
            
        }

        public void ChannelUp()
        {
            if (!IsOn)
            {
                IsOn = true;
            }
            else if (CurrentChannel >= 3 && CurrentChannel < 18)
            {
                CurrentChannel += 1;
            }
            else if (CurrentChannel == 18)
            {
                CurrentChannel = 3;
            }
        }

        public void ChannelDown()
        {
            if (!IsOn)
            {
                IsOn = true;
            }
            else if (CurrentChannel > 3 && CurrentChannel <= 18)
            {
                CurrentChannel -= 1;
            }
            else if (CurrentChannel == 3)
            {
                CurrentChannel = 18;
            }
        }

        public void RaiseVolume()
        {
            if (!IsOn)
            {
                IsOn = true;
            }
            else if (CurrentVolume >= 0 && CurrentVolume < 10)
            {
                CurrentVolume += 1;
            }
        }

        public void LowerVolume()
        {
            if (!IsOn)
            {
                IsOn = true;
            }
            else if (CurrentVolume > 0 && CurrentVolume <= 10)
            {
                CurrentVolume -= 1;
            }

        }


    }
}
