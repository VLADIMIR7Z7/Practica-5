namespace NetWorkEquipmentForms
{
    // Базовый класс для сетевого оборудования
    public class NetWorkEquipment
    {
        public string Model { get; set; } = "Неизвестно";
        private int price;
        private int dataRate;

        public int Price
        {
            get => price;
            set
            {
                if (value > 0)
                    price = value;
                else
                    System.Windows.Forms.MessageBox.Show("Цена введена неверно");
            }
        }

        public int DataRate
        {
            get => dataRate;
            set
            {
                if (value > 0 && value <= 1000)
                    dataRate = value;
                else
                    System.Windows.Forms.MessageBox.Show("Неверный ввод скорости передачи данных");
            }
        }

        public override string ToString()
        {
            return $"\nМодель: {Model}\nЦена: {Price} рублей\nСкорость передачи данных: {DataRate} мб/с";
        }
    }
}