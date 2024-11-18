namespace NetWorkEquipmentForms
{
    public class Switcher : NetWorkEquipment
    {
        private int ports;

        public int Ports
        {
            get { return ports; }
            set
            {
                if (value > 0 && value <= 10)
                    ports = value;
                else
                    ports = 0;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"\nКоличество портов: {Ports}";
        }
    }
}
