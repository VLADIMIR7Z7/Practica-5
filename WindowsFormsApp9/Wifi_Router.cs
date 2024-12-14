namespace NetWorkEquipmentForms
{
    public class Wifi_Router : NetWorkEquipment
    {
        public int Antennas { get; set; }

        public override string ToString()
        {
            return $"Wi-Fi маршрутизатор: Модель = {Model}, Антенны = {Antennas}, Цена = {Price}, Скорость передачи данных = {DataRate}";
        }
    }
}