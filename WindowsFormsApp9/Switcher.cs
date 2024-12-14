namespace NetWorkEquipmentForms
{
    public class Switcher : NetWorkEquipment
    {
        public int Ports { get; set; }

        public override string ToString()
        {
            return $"Свитч: Модель = {Model}, Порты = {Ports}, Цена = {Price}, Скорость передачи данных = {DataRate}";
        }
    }
}
