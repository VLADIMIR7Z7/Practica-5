namespace NetWorkEquipmentForms
{
    public class NetWorkEquipment
    {
        public string Model { get; set; }
        public int Price { get; set; }
        public int DataRate { get; set; }

        public override string ToString()
        {
            return $"Сетевое оборудование: Модель = {Model}, Цена = {Price}, Скорость передачи данных = {DataRate}";
        }
    }
}