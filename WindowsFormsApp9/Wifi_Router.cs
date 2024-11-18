namespace NetWorkEquipmentForms
{
    public class Wifi_Router : NetWorkEquipment
    {
        private int antennas; // Количество антенн

        public int Antennas
        {
            get { return antennas; }
            set
            {
                if (value > 0 && value <= 10)
                    antennas = value;
                else
                    antennas = 0;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"\nКоличество антенн: {Antennas}";
        }
    }
}