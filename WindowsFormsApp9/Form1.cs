using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NetWorkEquipmentForms
{
    public partial class Form1 : Form
    {
        private List<NetWorkEquipment> devices = new List<NetWorkEquipment>();

        public Form1()
        {
            InitializeComponent();
        }

                                   
                       
        private int GetValidInt(string input, int min, int max)
        {
            if (int.TryParse(input, out int value) && value >= min && value <= max)
            {
                return value;
            }
            else
            {
                MessageBox.Show("Неверный ввод. Попробуйте еще раз.");
                return 0; // Возвращаем 0 или любое другое значение по умолчанию
            }
        }

        private void btnAddEquipment_Click_1(object sender, EventArgs e)
        {
            Form inputForm = new Form();
            inputForm.Text = "Ввод данных";
            inputForm.Size = new System.Drawing.Size(300, 200);

            Label lblModel = new Label();
            lblModel.Text = "Введите модель:";
            lblModel.Location = new System.Drawing.Point(10, 10);
            inputForm.Controls.Add(lblModel);

            TextBox txtModel = new TextBox();
            txtModel.Location = new System.Drawing.Point(10, 30);
            inputForm.Controls.Add(txtModel);

            Label lblPrice = new Label();
            lblPrice.Text = "Введите цену:";
            lblPrice.Location = new System.Drawing.Point(10, 60);
            inputForm.Controls.Add(lblPrice);

            TextBox txtPrice = new TextBox();
            txtPrice.Location = new System.Drawing.Point(10, 80);
            inputForm.Controls.Add(txtPrice);

            Label lblDataRate = new Label();
            lblDataRate.Text = "Введите скорость передачи данных:";
            lblDataRate.Location = new System.Drawing.Point(10, 110);
            inputForm.Controls.Add(lblDataRate);

            TextBox txtDataRate = new TextBox();
            txtDataRate.Location = new System.Drawing.Point(10, 130);
            inputForm.Controls.Add(txtDataRate);

            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.Location = new System.Drawing.Point(100, 160);
            btnOK.DialogResult = DialogResult.OK;
            inputForm.AcceptButton = btnOK;
            inputForm.Controls.Add(btnOK);

            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                var netWorkEquipment = new NetWorkEquipment
                {
                    Model = txtModel.Text,
                    Price = GetValidInt(txtPrice.Text, 1, 100000),
                    DataRate = GetValidInt(txtDataRate.Text, 1, 1000)
                };
                devices.Add(netWorkEquipment);
                MessageBox.Show("Сетевое оборудование добавлено.");
            }
        }

        private void btnAddWifiRouter_Click_1(object sender, EventArgs e)
        {
            Form inputForm = new Form();
            inputForm.Text = "Ввод данных";
            inputForm.Size = new System.Drawing.Size(300, 250);

            Label lblModel = new Label();
            lblModel.Text = "Введите модель:";
            lblModel.Location = new System.Drawing.Point(10, 10);
            inputForm.Controls.Add(lblModel);

            TextBox txtModel = new TextBox();
            txtModel.Location = new System.Drawing.Point(10, 30);
            inputForm.Controls.Add(txtModel);

            Label lblAntennas = new Label();
            lblAntennas.Text = "Введите количество антенн:";
            lblAntennas.Location = new System.Drawing.Point(10, 60);
            inputForm.Controls.Add(lblAntennas);

            TextBox txtAntennas = new TextBox();
            txtAntennas.Location = new System.Drawing.Point(10, 80);
            inputForm.Controls.Add(txtAntennas);

            Label lblPrice = new Label();
            lblPrice.Text = "Введите цену:";
            lblPrice.Location = new System.Drawing.Point(10, 110);
            inputForm.Controls.Add(lblPrice);

            TextBox txtPrice = new TextBox();
            txtPrice.Location = new System.Drawing.Point(10, 130);
            inputForm.Controls.Add(txtPrice);

            Label lblDataRate = new Label();
            lblDataRate.Text = "Введите скорость передачи данных:";
            lblDataRate.Location = new System.Drawing.Point(10, 160);
            inputForm.Controls.Add(lblDataRate);

            TextBox txtDataRate = new TextBox();
            txtDataRate.Location = new System.Drawing.Point(10, 180);
            inputForm.Controls.Add(txtDataRate);

            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.Location = new System.Drawing.Point(100, 210);
            btnOK.DialogResult = DialogResult.OK;
            inputForm.AcceptButton = btnOK;
            inputForm.Controls.Add(btnOK);

            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                var wifiRouter = new Wifi_Router
                {
                    Model = txtModel.Text,
                    Antennas = GetValidInt(txtAntennas.Text, 1, 10),
                    Price = GetValidInt(txtPrice.Text, 1, 100000),
                    DataRate = GetValidInt(txtDataRate.Text, 1, 1000)
                };
                devices.Add(wifiRouter);
                MessageBox.Show("Wi-Fi маршрутизатор добавлен.");
            }
        }

        private void btnAddSwitcher_Click_1(object sender, EventArgs e)
        {
            Form inputForm = new Form();
            inputForm.Text = "Ввод данных";
            inputForm.Size = new System.Drawing.Size(300, 250);

            Label lblModel = new Label();
            lblModel.Text = "Введите модель:";
            lblModel.Location = new System.Drawing.Point(10, 10);
            inputForm.Controls.Add(lblModel);

            TextBox txtModel = new TextBox();
            txtModel.Location = new System.Drawing.Point(10, 30);
            inputForm.Controls.Add(txtModel);

            Label lblPorts = new Label();
            lblPorts.Text = "Введите количество портов:";
            lblPorts.Location = new System.Drawing.Point(10, 60);
            inputForm.Controls.Add(lblPorts);

            TextBox txtPorts = new TextBox();
            txtPorts.Location = new System.Drawing.Point(10, 80);
            inputForm.Controls.Add(txtPorts);

            Label lblPrice = new Label();
            lblPrice.Text = "Введите цену:";
            lblPrice.Location = new System.Drawing.Point(10, 110);
            inputForm.Controls.Add(lblPrice);

            TextBox txtPrice = new TextBox();
            txtPrice.Location = new System.Drawing.Point(10, 130);
            inputForm.Controls.Add(txtPrice);

            Label lblDataRate = new Label();
            lblDataRate.Text = "Введите скорость передачи данных:";
            lblDataRate.Location = new System.Drawing.Point(10, 160);
            inputForm.Controls.Add(lblDataRate);

            TextBox txtDataRate = new TextBox();
            txtDataRate.Location = new System.Drawing.Point(10, 180);
            inputForm.Controls.Add(txtDataRate);

            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.Location = new System.Drawing.Point(100, 210);
            btnOK.DialogResult = DialogResult.OK;
            inputForm.AcceptButton = btnOK;
            inputForm.Controls.Add(btnOK);

            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                var switcher = new Switcher
                {
                    Model = txtModel.Text,
                    Ports = GetValidInt(txtPorts.Text, 1, 10),
                    Price = GetValidInt(txtPrice.Text, 1, 100000),
                    DataRate = GetValidInt(txtDataRate.Text, 1, 1000)
                };
                devices.Add(switcher);
                MessageBox.Show("Свитч добавлен.");
            }
        }

        private void btnShowDevices_Click_1(object sender, EventArgs e)
        {
            txtOutput.Clear();
            if (devices.Count > 0)
            {
                foreach (var device in devices)
                {
                    txtOutput.AppendText(device.ToString() + Environment.NewLine);
                }
            }
            else
            {
                txtOutput.AppendText("Устройства не найдены.");
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}